using Dapper;
using Npgsql;
using Trabalho2.Model;

namespace Trabalho2.DB
{
    public class ResultadoDAO
    {
        string? sql;

        public void Insert(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"insert into resultado values (@id, @descricao, @descricao_arquivo, @arquivo)";

            connection.Execute(sql, param: new
            {
                id = resultado.Id,
                descricao = resultado.Descricao,
                descricao_arquivo = resultado.Descricao_Arquivo,
                arquivo = resultado.Arquivo
            });
        }

        public void Update(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"update resultado
                       set descricao = @descricao,
                           descricao_arquivo = @descricao_arquivo,
                           arquivo = @arquivo
                     where id = @id";

            connection.Execute(sql, param: new
            {
                descricao = resultado.Descricao,
                descricao_arquivo = resultado.Descricao_Arquivo,
                arquivo = resultado.Arquivo,
                id = resultado.Id
            });
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"delete from resultado
                     where id = @id";

            connection.Execute(sql, param: new { id });
        }

        public List<Resultado> RecuperarTodosFiltrado(string descricaoResultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select *
                      from resultado
                     where 1 = 1";

            if (!string.IsNullOrWhiteSpace(descricaoResultado))
            {
                sql += " and upper(descricao) like upper(CONCAT('%', @descricao, '%'))";
            }

            sql += " order by descricao";

            return (List<Resultado>)connection.Query<Resultado>(sql, param: new { descricao = descricaoResultado });
        }

        public Resultado RecuperarPorId(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select *
                      from resultado
                     where id = @id";

            return connection.QuerySingle<Resultado>(sql, param: new { id });
        }

        public bool ExisteResultado(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select count(*)
                      from resultado
                     where id = @id";

            return connection.QuerySingle<bool>(sql, param: new { id });
        }

        public bool ExisteResultadoProjeto(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select count(*)
                      from projeto
                     where id_resultado = @id";

            return connection.QuerySingle<bool>(sql, param: new { id });
        }

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select coalesce(max(id), 0) + 1
                      from resultado";

            return connection.QuerySingle<int>(sql);
        }

        public byte[] RetornaArquivo(int id_projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select resultado.arquivo
                      from projeto, resultado
                     where projeto.id_resultado = resultado.id
                       and projeto.id = @id_projeto";

            return connection.Query<byte[]>(sql, param: new { id_projeto }).SingleOrDefault();
        }

        public string RetornaDescricaoArquivo(int id_projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select resultado.descricao_arquivo
                      from projeto, resultado
                     where projeto.id_resultado = resultado.id
                       and projeto.id = @id_projeto";

            return connection.QuerySingle<string>(sql, param: new { id_projeto });
        }
    }
}