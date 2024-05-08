using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;

namespace Trabalho2.DB
{
    public class ResultadoDAO
    {
        private string? sql;

        public void Insert(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"INSERT INTO resultado (id, descricao, descricao_arquivo, arquivo)
                    VALUES (@id, @descricao, @descricao_arquivo, @arquivo)";

            connection.Execute(sql, resultado);
        }

        public void Update(Resultado resultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"UPDATE resultado
                       SET descricao = @descricao,
                           descricao_arquivo = @descricao_arquivo,
                           arquivo = @arquivo
                     WHERE id = @id";

            connection.Execute(sql, resultado);
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"DELETE FROM resultado
                     WHERE id = @id";

            connection.Execute(sql, new { id });
        }

        public List<Resultado> RecuperarTodosFiltrado(string descricaoResultado)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                      FROM resultado
                     WHERE UPPER(descricao) LIKE UPPER(CONCAT('%', @descricao, '%'))
                     ORDER BY descricao";

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
                      JOIN resultado ON projeto.id_resultado = resultado.id
                     WHERE projeto.id = @id_projeto";

            return connection.QuerySingleOrDefault<byte[]>(sql, new { id_projeto });
        }

        public string RetornaDescricaoArquivo(int id_projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT resultado.descricao_arquivo
                      FROM projeto
                      JOIN resultado ON projeto.id_resultado = resultado.id
                     WHERE projeto.id = @id_projeto";

            return connection.QuerySingleOrDefault<string>(sql, new { id_projeto });
        }
    }
}