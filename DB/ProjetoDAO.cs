using Dapper;
using Npgsql;
using Trabalho2.Model;
using System;
using System.Collections.Generic;

namespace Trabalho2.DB
{
    public class ProjetoDAO
    {
        string? sql;

        public void Insert(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            //INCLUIR resultado
            sql = @"INSERT INTO projeto (nome, area_de_atuacao, Resultado_ID, data_inicial, data_final, tipo, Instituicao_ID)
                VALUES (@Nome, @AreaDeAtuacaoId, @IdResultado, @DataInicial, @DataFinal, @Tipo, @InstituicaoId)
                RETURNING id"; // Retorna o ID gerado

            // Usamos um objeto anônimo para facilitar a passagem dos parâmetros
            var parametrosProjeto = new
            {
                projeto.Nome,
                AreaDeAtuacaoId = projeto.AreaDeAtuacao?.Id, // Lidando com a possibilidade de ser null
                projeto.IdResultado,
                projeto.DataInicial,
                projeto.DataFinal,
                projeto.Tipo,
                InstituicaoId = projeto.Instituicao?.Id // Lidando com a possibilidade de ser null
            };

            // Executamos a inserção e obtemos o ID gerado
            projeto.Id = (int)connection.ExecuteScalar(sql, parametrosProjeto, transaction);

            // Inserção na tabela intermediária projeto_pesquisador
            sql = @"INSERT INTO pesquisador (id_projeto, id_pesquisador)
                VALUES (@IdProjeto, @IdPesquisador)";

            foreach (var pesquisador in projeto.Pesquisadores)
            {
                connection.Execute(sql, new { IdProjeto = projeto.Id, IdPesquisador = pesquisador.Id }, transaction);
            }

            transaction.Commit();
        }

        public void Update(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();
            try
            {

                // Atualização na tabela projeto (incluindo todas as propriedades relevantes)
                sql = @"UPDATE projeto 
                SET nome = @Nome,
                    AreaAtuacao_ID = @AreaDeAtuacaoId,
                    Resultado_ID = @IdResultado,
                    DataInicial = @DataInicial,
                    DataFinal = @DataFinal,
                    tipo = @Tipo,
                    Instituicao_ID = @InstituicaoId
                WHERE id = @Id";

                var parametrosProjeto = new
                {
                    projeto.Id,
                    projeto.Nome,
                    AreaDeAtuacaoId = projeto.AreaDeAtuacao?.Id, // Lidando com a possibilidade de ser null
                    projeto.IdResultado,
                    projeto.DataInicial,
                    projeto.DataFinal,
                    projeto.Tipo,
                    InstituicaoId = projeto.Instituicao?.Id // Lidando com a possibilidade de ser null
                };

                connection.Execute(sql, parametrosProjeto, transaction);

                // Remoção dos pesquisadores existentes do projeto
                sql = @"DELETE FROM pesquisador
                WHERE id_projeto = @Id";

                connection.Execute(sql, new { Id = projeto.Id }, transaction);

                // Inserção dos novos pesquisadores do projeto
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
                       SET DataFinal = current_date
                     WHERE id = @Id";

            connection.Execute(sql, new { Id = id });
        }

        public List<Projeto> RecuperarTodosFiltrado(string tituloProjeto, DateTime dataInicialProjeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            DefaultTypeMap.MatchNamesWithUnderscores = true;

            sql = @"SELECT *
                      FROM projeto
                     WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(tituloProjeto))
            {
                sql += " AND upper(Nome) LIKE upper(CONCAT('%', @Titulo, '%'))";
            }

            sql += " AND DataInicial = @data_inicial";

            sql += " ORDER BY Nome";

            return connection.Query<Projeto>(sql, new { Titulo = tituloProjeto, DataInicial = dataInicialProjeto.Date }).AsList();
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