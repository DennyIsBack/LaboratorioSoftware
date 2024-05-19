using Npgsql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Model;

namespace Trabalho2.DB
{
    internal class AreaDAO
    {
        private string sql;

        public List<string> RecuperarAreas()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                sql = @"SELECT nome FROM areaatuacao";

                return connection.Query<string>(sql).AsList();
            }
        }
        public int Insert(string nome)
        {
            int id = GetIdByName(nome);

            if (id != -1)
            {
                return id;
            }
            else
            {
                int novoId = id + 1;

                using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
                {
                    sql = @"INSERT INTO areaatuacao (id, nome) VALUES (@id, @nome)";
                    int rowsAffected = connection.Execute(sql, new { id = novoId, nome });

                    return novoId;
                }
            }
        }

        private int GetIdByName(string nome)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                string query = "SELECT COALESCE(id, -1) FROM areaatuacao WHERE nome = @nome";
                return connection.ExecuteScalar<int>(query, new { nome });
            }
        }

        public List<string> RecuperarNomeArea(int id)
        {
            string queryArea = "SELECT nome FROM areaatuacao WHERE id = @id";

            using (var connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                connection.Open();
                return connection.Query<string>(queryArea, new { id }).ToList();
            }
        }
    }
}