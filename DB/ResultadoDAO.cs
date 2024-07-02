using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;
using System.Diagnostics;
using Trabalho2.Interfaces;
using System.Runtime.InteropServices;

namespace Trabalho2.DB
{
    public class ResultadoDAO
    {
        private string? sql;
        private readonly ProjetoDAO projetoDAO = new();

        public bool Insert(Resultado resultadoDAO)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"INSERT INTO resultado (id, id_projeto, arquivo, nome_arquivo)
                   VALUES (@id, @id_projeto, @arquivo, @nome_arquivo)";

            int rowsAffected = connection.Execute(sql, new
            {
                id = resultadoDAO.Id,
                id_projeto = Convert.ToInt32(resultadoDAO.id_projeto),
                nome_arquivo = resultadoDAO.nome_arquivo,
                arquivo = resultadoDAO.Arquivo
            });
            return rowsAffected > 0;
        }

        public bool Update(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            string sql = $@"UPDATE resultado SET id_projeto = '{Convert.ToInt32(resultado.id_projeto)}', arquivo = '{resultado.Arquivo}', nome_arquivo = '{resultado.nome_arquivo}' WHERE id = {resultado.Id}";

            int rowsAffected = connection.Execute(sql);

            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            sql = @"DELETE FROM resultado
                     WHERE id = @id"
            ;

            int rowsAffected = connection.Execute(sql, new { id });

            return rowsAffected > 0;
        }

        public Resultado RecuperarPorId(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT * FROM resultado WHERE id = @id";

            return connection.QuerySingleOrDefault<Resultado>(sql, new { id });
        }

        public bool ExisteResultadoNoProjeto(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT COUNT(*)
                     FROM projeto
                     WHERE id_resultado = @id";

            return connection.QuerySingle<int>(sql, new { id }) > 0;
        }

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT COALESCE(MAX(id), 0) + 1
                      FROM resultado";

            return connection.QuerySingle<int>(sql);
        }

        public byte[] RetornaArquivo(int id_projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT resultado.arquivo
                      FROM projeto
                      JOIN resultado ON resultado.id_projeto = projeto.id
                     WHERE projeto.id = @id_projeto";

            return connection.QuerySingleOrDefault<byte[]>(sql, new { id_projeto });
        }

        public string RetornaDescricaoArquivo(int id_projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT resultado.descricao_arquivo
                      FROM projeto
                      JOIN resultado ON projeto.Resultado_ID = resultado.id
                     WHERE projeto.id = @id_projeto";

            return connection.QuerySingleOrDefault<string>(sql, new { id_projeto });
        }

        public List<Resultado> CarregaRegistros(string filtro = null)
        {
            List<Resultado> resultados = new List<Resultado>();

            using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                connection.Open();

                string sql = "SELECT id, id_projeto, arquivo FROM resultado";

                if (filtro != "")
                {
                    string id = projetoDAO.GetID(filtro);
                    sql += $" WHERE id_projeto = '{id}'";
                }

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Resultado resultado = new Resultado
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            id_projeto = reader.GetInt32(reader.GetOrdinal("id_projeto")).ToString(),
                            Arquivo = (byte[])reader["arquivo"]
                        };

                        resultados.Add(resultado);
                    }
                }
            }

            return resultados;
        }
    }
}