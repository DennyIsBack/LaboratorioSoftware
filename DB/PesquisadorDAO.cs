using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Trabalho2.Interfaces;
using System.Diagnostics;

namespace Trabalho2.DB
{
    public class PesquisadorDAO
    {
        string? sql;

        public bool Insert(Pesquisador pesquisador)
        {
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = @"INSERT INTO pesquisador (id, nome, email, instituicao, lattes, tipo, areaatuacao_id)
                           VALUES (@id, @nome, @email, @instituicao, @lattes, @tipo, @areaatuacao_id)";

                int rowsAffected = connection.Execute(sql, new
                {
                    id = pesquisador.Id,
                    nome = pesquisador.Nome,
                    email = pesquisador.Email,
                    instituicao = pesquisador.Instituicao,
                    lattes = pesquisador.Lattes,
                    tipo = pesquisador.Tipo,
                    areaatuacao_id = pesquisador.AreaAtuacao.Id

                });

                return rowsAffected > 0;
            }
        }

        public bool Update(Pesquisador pesquisador)
        {
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = $@"UPDATE pesquisador SET nome = '{pesquisador.Nome}', email = '{pesquisador.Email}', instituicao = '{pesquisador.Instituicao}', lattes = '{pesquisador.Lattes}', tipo = '{pesquisador.Tipo}', areaatuacao_id = {pesquisador.AreaAtuacao.Id} WHERE id = {pesquisador.Id}";

                Debug.WriteLine(sql);

                int rowsAffected = connection.Execute(sql);

                return rowsAffected > 0;
            }
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

        public Pesquisador RecuperarID(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                     FROM pesquisador
                     WHERE id = @id";

            return connection.QuerySingle<Pesquisador>(sql, param: new { id });
        }

        //public int RecuperarID(int id)
        //{
        //    using NpgsqlConnection connection = new(StringConexao.stringConexao);

        //    sql = @"SELECT id
        //             FROM pesquisador
        //             WHERE id = @id";

        //    return connection.QuerySingle<int>(sql, param: new { id });
        //}

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
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"SELECT COALESCE(MAX(id), 0) + 1 FROM pesquisador";

            return connection.QuerySingle<int>(sql);
        }

        public bool EmailExiste(string email)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"SELECT COUNT(*) FROM pesquisador WHERE email = @email";

            int count = connection.ExecuteScalar<int>(sql, param: new { email });

            return count > 0;
        }

        public List<Pesquisador> RecuperarPesquisadores(string tabela, string nome)
        {
            string queryPesquisadores = $@"SELECT p.id, p.nome, p.areaatuacao_id 
                                   FROM {tabela} p 
                                   WHERE p.nome LIKE @Nome";

            using (var connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                connection.Open();

                var pesquisadoresQueryResult = connection.Query(queryPesquisadores, new { Nome = $"%{nome}%" }).AsList();

                var areaDAO = new AreaDAO();
                var pesquisadores = new List<Pesquisador>();

                foreach (var result in pesquisadoresQueryResult)
                {
                    var id = (int)result.id;
                    var nomePesquisador = (string)result.nome;
                    var idAreaAtuacao = (int?)result.areaatuacao_id;

                    string nomeArea = "Sem área";
                    if (idAreaAtuacao != null)
                    {
                        var nomesArea = areaDAO.RecuperarNomeArea(idAreaAtuacao.Value);
                        if (nomesArea.Count > 0)
                        {
                            nomeArea = nomesArea[0];
                        }
                    }

                    var pesquisador = new Pesquisador
                    {
                        Id = id,
                        Nome = nomePesquisador,
                        AreaAtuacao = idAreaAtuacao != null ? new Area { Id = idAreaAtuacao.Value, Nome = nomeArea } : null
                    };

                    pesquisadores.Add(pesquisador);
                }

                return pesquisadores;
            }
        }
        public int? GetIdAreaAtuacao(int id)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"SELECT areaatuacao_id
                   FROM pesquisador
                   WHERE id = @id";

            return connection.QuerySingleOrDefault<int?>(sql, param: new { id });
        }

        public List<Pesquisador> RecuperarPesquisadoresPorArea(string tabela, string nome, string areaAtuacao)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                string sql = @"SELECT p.id, p.nome, p.areaatuacao_id 
                       FROM pesquisador p 
                       INNER JOIN areaatuacao a ON p.areaatuacao_id = a.id 
                       WHERE (@nome IS NULL OR p.nome LIKE @Nome) 
                       AND (@areaAtuacao IS NULL OR a.nome = @AreaAtuacao)";

                connection.Open();

                var pesquisadoresQueryResult = connection.Query(sql, new { Nome = $"%{nome}%", AreaAtuacao = areaAtuacao }).AsList();

                var pesquisadores = new List<Pesquisador>();

                AreaDAO areaDao = new();

                foreach (var result in pesquisadoresQueryResult)
                {
                    var id = (int)result.id;
                    var nomePesquisador = (string)result.nome;
                    var idAreaAtuacao = (int?)result.areaatuacao_id;

                    string nomeArea = "Sem área";
                    if (idAreaAtuacao != null)
                    {
                        var nomesArea = areaDao.RecuperarNomeArea(idAreaAtuacao.Value);
                        if (nomesArea.Count > 0)
                        {
                            nomeArea = nomesArea[0];
                        }
                    }

                    var pesquisador = new Pesquisador
                    {
                        Id = id,
                        Nome = nomePesquisador,
                        AreaAtuacao = idAreaAtuacao != null ? new Area { Id = idAreaAtuacao.Value, Nome = nomeArea } : null
                    };

                    pesquisadores.Add(pesquisador);
                }

                return pesquisadores;
            }
        }
    }
}