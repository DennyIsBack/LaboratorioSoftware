using Dapper;
using Npgsql;
using Trabalho2.Model;

namespace Trabalho2.DB
{
    public class ProjetoDAO
    {
        string? sql;
        private readonly AreaDAO areaDAO = new AreaDAO();
        private readonly InstituicaoDAO instituicaoDAO = new InstituicaoDAO();

        public void Insert(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            try
            {
                //INCLUIR resultado
                string sql = @"INSERT INTO projeto (id, nome, AreaAtuacao_ID, DataInicial, tipo, Instituicao_ID, Finalizado)
                       VALUES (@id, @Nome, @AreaDeAtuacaoId, @DataInicial, @Tipo, @InstituicaoId, @Finalizado)"; // Retorna o ID gerado

                var parameterProjeto = new
                {
                    id = RetornaProximoId(),
                    projeto.Nome,
                    AreaDeAtuacaoId = projeto.AreaDeAtuacao?.Id,
                    //ResultadoId = projeto.Resultado?.Id, 
                    DataInicial = projeto.DataInicial.ToUniversalTime(),
                    //DataFinal = projeto.DataFinal.ToUniversalTime(),
                    projeto.Tipo,
                    InstituicaoId = projeto.Instituicao?.Id, 
                    projeto.Finalizado
                };

                connection.ExecuteScalar(sql, parameterProjeto, transaction);

                // Inserção na tabela intermediária projeto_pesquisador
                sql = @"INSERT INTO Projeto_Pesquisador (Projeto_ID, Pesquisador_ID)
                VALUES (@IdProjeto, @IdPesquisador)";
                
                foreach (var pesquisador in projeto.Pesquisadores)
                {
                    connection.Execute(sql, new { IdProjeto = projeto.Id, IdPesquisador = pesquisador.Id }, transaction);
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
        }


        public void Update(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Atualização na tabela projeto (incluindo todas as propriedades relevantes)
                string sql = @"UPDATE projeto 
                       SET AreaAtuacao_ID = @AreaDeAtuacaoId,
                           DataInicial = @DataInicial,
                           tipo = @Tipo,
                           Instituicao_ID = @InstituicaoId";

               

                sql += " WHERE id = @Id";

                var parametrosProjeto = new DynamicParameters();
                parametrosProjeto.Add("Id", projeto.Id);
                parametrosProjeto.Add("AreaDeAtuacaoId", projeto.AreaDeAtuacao?.Id);
                parametrosProjeto.Add("ResultadoId", projeto.Resultado?.Id);
                parametrosProjeto.Add("DataInicial", projeto.DataInicial.ToUniversalTime());
                parametrosProjeto.Add("Tipo", projeto.Tipo);
                parametrosProjeto.Add("InstituicaoId", projeto.Instituicao?.Id);

                if (projeto.DataFinal != DateTime.MinValue)
                {
                    parametrosProjeto.Add("DataFinal", projeto.DataFinal.ToUniversalTime());
                }

                connection.Execute(sql, parametrosProjeto, transaction);

                // Remoção dos pesquisadores existentes do projeto
                sql = @"DELETE FROM Projeto_Pesquisador
                WHERE Projeto_ID = @Id";

                connection.Execute(sql, new { Id = projeto.Id }, transaction);

                sql = @"INSERT INTO Projeto_Pesquisador (Projeto_ID, Pesquisador_ID)
                VALUES (@IdProjeto, @IdPesquisador)";

                foreach (var pesquisador in projeto.Pesquisadores)
                {
                    connection.Execute(sql, new { IdProjeto = projeto.Id, IdPesquisador = pesquisador.Id }, transaction);
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Erro ao atualizar projeto: " + ex.Message);
            }
        }


        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"DELETE FROM Projeto_Pesquisador
                     WHERE Projeto_ID = @Id";

            connection.Execute(sql, new { Id = id }, transaction);

            sql = @"DELETE FROM projeto
                     WHERE id = @Id";

            connection.Execute(sql, new { Id = id }, transaction);

            transaction.Commit();
        }

        public void Finalizar(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"UPDATE projeto
                       SET Finalizado = true
                     WHERE id = @Id";

            connection.Execute(sql, new { Id = id });
        }

        public List<Projeto> RecuperarTodosFiltrado(string tituloProjeto, DateTime dataInicialProjeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            DefaultTypeMap.MatchNamesWithUnderscores = true;

            string sql = @"SELECT id, nome, areaatuacao_id, resultado_id, 
                          datainicial, datafinal, tipo, instituicao_id, 
                          finalizado
                   FROM projeto
                   WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(tituloProjeto))
            {
                sql += " AND upper(nome) LIKE upper(CONCAT('%', @Titulo, '%'))";
            }

            sql += " AND datainicial >= @DataInicial";
            sql += " ORDER BY nome";

            var parameters = new
            {
                Titulo = tituloProjeto,
                DataInicial = dataInicialProjeto.Date.ToUniversalTime()
            };

            return connection.Query<Projeto>(sql, parameters).AsList();
        }


        public Projeto RecuperarPorId(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                      FROM projeto
                     WHERE id = @Id";

            var projeto = connection.QuerySingleOrDefault<Projeto>(sql, new { Id = id });

            if (projeto != null)
            {
                sql = @"SELECT pesquisador.id, pesquisador.nome
                          FROM pesquisador
                          JOIN Projeto_Pesquisador 
                          ON pesquisador.id = Projeto_Pesquisador.Pesquisador_ID
                          WHERE Projeto_Pesquisador.Projeto_ID = @Id";

                projeto.Pesquisadores = connection.Query<Pesquisador>(sql, new { Id = id }).AsList();

                var areas = areaDAO.RecuperarAreaId(projeto.AreaAtuacao_ID);

                if (areas != null)
                {
                    projeto.AreaDeAtuacao = areas.FirstOrDefault();
                }

                var instituicao = instituicaoDAO.RecuperarID(projeto.Instituicao_ID);

                if (instituicao != null)
                    projeto.Instituicao = instituicao;
            }

            return projeto;
        }

        public bool ExisteResultadoProjeto(int id_projeto, int id_resultado)
        {
            sql = @"SELECT COUNT(*)
                      FROM projeto
                     WHERE id <> @IdProjeto
                       AND id_resultado = @IdResultado";

            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            return connection.QuerySingle<bool>(sql, new { IdProjeto = id_projeto, IdResultado = id_resultado });
        }

        public int RetornaProximoId()
        {
            sql = @"SELECT COALESCE(MAX(id), 0) + 1
                      FROM projeto";

            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            return connection.QuerySingle<int>(sql);
        }

        public bool ExistePesquisadorProjeto(int idPesquisador, int idProjeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            string sql = @"SELECT COUNT(*)
                  FROM Projeto_Pesquisador
                  WHERE Projeto_ID = @IdProjeto
                  AND Pesquisador_ID = @IdPesquisador";

            return connection.QuerySingle<bool>(sql, new { IdProjeto = idProjeto, IdPesquisador = idPesquisador });
        }
    }
}