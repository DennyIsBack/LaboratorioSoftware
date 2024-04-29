using Dapper;
using Npgsql;
using Trabalho2.Model;

namespace Trabalho2.DB
{
    public class PesquisadorDAO
    {
        string? sql;

        public void Insert(Pesquisador pesquisador)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"insert into pesquisador values (@id, @nome, @area)";

            connection.Execute(sql, param: new
            {
                id = pesquisador.Id,
                nome = pesquisador.Nome,
                area = pesquisador.Area
            });
        }

        public void Update(Pesquisador pesquisador)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"update pesquisador
                       set nome = @nome,
                           area = @area
                     where id = @id";

            connection.Execute(sql, param: new
            {
                nome = pesquisador.Nome,
                area = pesquisador.Area,
                id = pesquisador.Id
            });
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"delete from pesquisador
                     where id = @id";

            connection.Execute(sql, param: new { id });
        }

        public List<Pesquisador> RecuperarTodosFiltrado(string nomePesquisador, string areaPesquisador)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select *
                      from pesquisador
                     where 1 = 1";

            if (!string.IsNullOrWhiteSpace(nomePesquisador))
            {
                sql += " and upper(nome) like upper(CONCAT('%', @nome, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(areaPesquisador))
            {
                sql += " and upper(area) like upper(CONCAT('%', @area, '%'))";
            }

            sql += " order by nome";

            return (List<Pesquisador>)connection.Query<Pesquisador>(sql,
                   param: new
                   {
                       nome = nomePesquisador,
                       area = areaPesquisador
                   });
        }

        public Pesquisador RecuperarPorId(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select *
                      from pesquisador
                     where id = @id";

            return connection.QuerySingle<Pesquisador>(sql, param: new { id });
        }

        public bool ExistePesquisador(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select count(*)
                      from pesquisador
                     where id = @id";

            return connection.QuerySingle<bool>(sql, param: new { id });
        }

        public bool ExistePesquisadorProjeto(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select count(*)
                      from projeto_pesquisador
                     where id_pesquisador = @id";

            return connection.QuerySingle<bool>(sql, param: new { id });
        }

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"select coalesce(max(id), 0) + 1
                      from pesquisador";

            return connection.QuerySingle<int>(sql);
        }
    }
}