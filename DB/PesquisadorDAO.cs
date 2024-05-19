using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;

namespace Trabalho2.DB
{
    public class PesquisadorDAO
    {
        string? sql;

        public bool Insert(Pesquisador pesquisador)
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = @"INSERT INTO pesquisador (id, nome, email, instituicao, lattes, tipo)
                           VALUES (@id, @nome, @email, @instituicao, @lattes, @tipo)";

                int rowsAffected = connection.Execute(sql, new
                {
                    id = pesquisador.Id,
                    nome = pesquisador.Nome,
                    email = pesquisador.Email,
                    instituicao = pesquisador.Instituicao,
                    lattes = pesquisador.Lattes,
                    tipo = pesquisador.Tipo
                });

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir pesquisador: {ex.Message}");
                return false; 
            }
        }


        public void Update(Pesquisador pesquisador)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"UPDATE pesquisador
                       SET nome = @nome,
                           email = @email,
                           instituicao = @instituicao,
                           lattes = @lattes,
                           tipo = @tipo
                     WHERE id = @id";

            connection.Execute(sql, param: new
            {
                nome = pesquisador.Nome,
                email = pesquisador.Email,
                instituicao = pesquisador.Instituicao,
                lattes = pesquisador.Lattes,
                tipo = pesquisador.Tipo,
                id = pesquisador.Id
            });
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"DELETE FROM pesquisador
                     WHERE id = @id";

            connection.Execute(sql, param: new { id });
        }

        public List<Pesquisador> RecuperarTodosFiltrado(string nomePesquisador, string areaPesquisador)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                      FROM pesquisador
                     WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(nomePesquisador))
            {
                sql += " AND upper(nome) LIKE upper(CONCAT('%', @nome, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(areaPesquisador))
            {
                sql += " AND upper(area) LIKE upper(CONCAT('%', @area, '%'))";
            }

            sql += " ORDER BY nome";

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

            sql = @"SELECT *
                      FROM pesquisador
                     WHERE id = @id";

            return connection.QuerySingle<Pesquisador>(sql, param: new { id });
        }

        public bool ExistePesquisador(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT COUNT(*)
                      FROM pesquisador
                     WHERE id = @id";

            return connection.QuerySingle<bool>(sql, param: new { id });
        }

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT COALESCE(MAX(id), 0) + 1
                      FROM pesquisador";

            return connection.QuerySingle<int>(sql);
        }
    }
}