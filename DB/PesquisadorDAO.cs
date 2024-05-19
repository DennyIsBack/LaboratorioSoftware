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
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = @"UPDATE pesquisador
                       SET nome = @nome,
                           email = @email,
                           instituicao = @instituicao,
                           lattes = @lattes,
                           tipo = @tipo
                     WHERE id = @id";

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
                MessageBox.Show($"Erro ao atualizar cadastro.{Environment.NewLine}{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro ao atualizar cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
    }
}