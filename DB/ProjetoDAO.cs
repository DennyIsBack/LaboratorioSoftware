using Dapper;
using Npgsql;
using Trabalho2.Model;

namespace Trabalho2.DB
{
    public class ProjetoDAO
    {
        string? sql;

        public void Insert(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"insert into projeto values (@id, @titulo, @data_inicial, null, @id_resultado)";

            connection.Execute(sql, param: new
            {
                id = projeto.Id,
                titulo = projeto.Titulo,
                data_inicial = projeto.DataInicial,
                id_resultado = projeto.Resultado?.Id
            }, transaction);

            sql = @"insert into projeto_pesquisador values (@id_projeto, @id_pesquisador)";

            for (int i = 0; i < projeto.PesquisadorList?.Count; i++)
            {
                connection.Execute(sql, param: new
                {
                    id_projeto = projeto.Id,
                    id_pesquisador = projeto.PesquisadorList[i].Id
                }, transaction);
            }

            transaction.Commit();
        }

        public void Update(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"update projeto
                       set titulo = @titulo,
                           data_inicial = @data_inicial,
                           id_resultado = @id_resultado
                     where id = @id";

            connection.Execute(sql, param: new
            {
                titulo = projeto.Titulo,
                data_inicial = projeto.DataInicial,
                id_resultado = projeto.Resultado?.Id,
                id = projeto.Id
            }, transaction);

            sql = @"delete from projeto_pesquisador
                     where id_projeto = @id_projeto";

            connection.Execute(sql, param: new { id_projeto = projeto.Id }, transaction);

            sql = @"insert into projeto_pesquisador values (@id_projeto, @id_pesquisador)";

            for (int i = 0; i < projeto.PesquisadorList?.Count; i++)
            {
                connection.Execute(sql, param: new
                {
                    id_projeto = projeto.Id,
                    id_pesquisador = projeto.PesquisadorList[i].Id
                }, transaction);
            }

            transaction.Commit();
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"delete from projeto_pesquisador
                     where id_projeto = @id";

            connection.Execute(sql, param: new { id }, transaction);

            sql = @"delete from projeto
                     where id = @id";

            connection.Execute(sql, param: new { id }, transaction);

            transaction.Commit();
        }

        public void Finalizar(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"update projeto
                       set data_final = current_date
                     where id = @id";

            connection.Execute(sql, param: new { id });
        }

        public List<Projeto> RecuperarTodosFiltrado(string tituloProjeto, DateTimePicker dataInicialProjeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            DefaultTypeMap.MatchNamesWithUnderscores = true;

            sql = @"select *
                      from projeto
                     where 1 = 1";

            if (!string.IsNullOrWhiteSpace(tituloProjeto))
            {
                sql += " and upper(titulo) like upper(CONCAT('%', @titulo, '%'))";
            }

            if (dataInicialProjeto.CustomFormat == "dd/MM/yyyy")
            {
                sql += " and data_inicial = @data_inicial";
            }

            sql += " order by titulo";

            return (List<Projeto>)connection.Query<Projeto>(sql,
                   param: new
                   {
                       titulo = tituloProjeto,
                       data_inicial = dataInicialProjeto.Value.Date
                   });
        }

        public Projeto RecuperarPorId(int id)
        {
            Projeto projeto;

            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select projeto.*, resultado.*
                      from projeto
                      left join resultado
                        on projeto.id_resultado = resultado.id
                     where projeto.id = @id";

            projeto = connection.Query<Projeto, Resultado, Projeto>(sql,
                      (projeto, resultado) =>
                      {
                          projeto.Resultado = resultado;
                          return projeto;
                      },
                      param: new { id }).Single();

            sql = @"select pesquisador.id, pesquisador.nome, pesquisador.area
                      from pesquisador, projeto_pesquisador
                     where pesquisador.id = projeto_pesquisador.id_pesquisador
                       and projeto_pesquisador.id_projeto = @id";

            projeto.PesquisadorList = (List<Pesquisador>)connection.Query<Pesquisador>(sql, param: new { id });

            return projeto;
        }

        public bool ExisteResultadoProjeto(int id_projeto, int id_resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select count(*)
                      from projeto
                     where id <> @id_projeto
                       and id_resultado = @id_resultado";

            return connection.QuerySingle<bool>(sql, param: new { id_projeto, id_resultado });
        }

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select coalesce(max(id), 0) + 1
                      from projeto";

            return connection.QuerySingle<int>(sql);
        }
    }
}