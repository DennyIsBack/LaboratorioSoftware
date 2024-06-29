using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;
using System.Diagnostics;
using Trabalho2.Interfaces;

namespace Trabalho2.DB
{
    public class ResultadoDAO
    {
        private string? sql;

        public bool Insert(Resultado resultadoDAO)
        {
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = @"INSERT INTO pesquisador (id, descricao, descriacao_projeto, arquivo)
                           VALUES (@id, @descricao, @descriacao_projeto, @arquivo)";

                int rowsAffected = connection.Execute(sql, new
                {
                    id = resultadoDAO.Id,
                    descricao = resultadoDAO.Descricao,
                    descriacao_projeto = resultadoDAO.DescricaoArquivo,
                    arquivo = resultadoDAO.Arquivo
                });
                return rowsAffected > 0;
            }
        }

        public bool Update(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
           
            string sql = $@"UPDATE resultado SET descricao = '{resultado.Descricao}', descricao_arquivo = '{resultado.DescricaoArquivo}', arquivo = '{resultado.Arquivo}' WHERE id = {resultado.Id}";

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

        public List<Resultado> RecuperarTodosFiltrado(string descricaoResultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            sql = @"SELECT *
                      FROM resultado
                     WHERE UPPER(descricao) LIKE UPPER(CONCAT('%', @descricao, '%'))
                     ORDER BY descricao"
            ;
            return connection.Query<Resultado>(sql, new { descricao = descricaoResultado }).AsList();
        }

        public Resultado RecuperarPorId(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                      FROM resultado
                     WHERE id = @id";

            return connection.QuerySingleOrDefault<Resultado>(sql, new { id });
        }

        public bool ExisteResultado(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT COUNT(*)
                      FROM resultado
                     WHERE id = @id";

            return connection.QuerySingle<int>(sql, new { id }) > 0;
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
                      JOIN resultado ON projeto.Resultado_ID = resultado.id
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
    }
}