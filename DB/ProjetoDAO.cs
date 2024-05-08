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

            sql = @"INSERT INTO projeto (id, nome, area_de_atuacao, id_resultado)
                    VALUES (@Id, @Nome, @AreaDeAtuacao, @IdResultado)";

            connection.Execute(sql, projeto, transaction);

            sql = @"INSERT INTO projeto_pesquisador (id_projeto, id_pesquisador)
                    VALUES (@Id, @IdPesquisador)";

            foreach (var pesquisador in projeto.Pesquisadores)
            {
                connection.Execute(sql, new { Id = projeto.Id, IdPesquisador = pesquisador.Id }, transaction);
            }

            transaction.Commit();
        }

        public void Update(Projeto projeto)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"UPDATE projeto
                       SET nome = @Nome,
                           area_de_atuacao = @AreaDeAtuacao,
                           id_resultado = @IdResultado
                     WHERE id = @Id";

            connection.Execute(sql, projeto, transaction);

            sql = @"DELETE FROM projeto_pesquisador
                     WHERE id_projeto = @Id";

            connection.Execute(sql, new { Id = projeto.Id }, transaction);

            sql = @"INSERT INTO projeto_pesquisador (id_projeto, id_pesquisador)
                    VALUES (@Id, @IdPesquisador)";

            foreach (var pesquisador in projeto.Pesquisadores)
            {
                connection.Execute(sql, new { Id = projeto.Id, IdPesquisador = pesquisador.Id }, transaction);
            }

            transaction.Commit();
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);
            connection.Open();
            using NpgsqlTransaction transaction = connection.BeginTransaction();

            sql = @"DELETE FROM projeto_pesquisador
                     WHERE id_projeto = @Id";

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
                       SET data_final = current_date
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
                sql += " AND upper(nome) LIKE upper(CONCAT('%', @Titulo, '%'))";
            }

            sql += " AND data_inicial = @DataInicial";

            sql += " ORDER BY nome";

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
                sql = @"SELECT pesquisador.id, pesquisador.nome, pesquisador.area
                          FROM pesquisador
                          JOIN projeto_pesquisador ON pesquisador.id = projeto_pesquisador.id_pesquisador
                          WHERE projeto_pesquisador.id_projeto = @Id";

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
                  FROM projeto_pesquisador
                  WHERE id_projeto = @IdProjeto
                  AND id_pesquisador = @IdPesquisador";

            return connection.QuerySingle<bool>(sql, new { IdProjeto = idProjeto, IdPesquisador = idPesquisador });
        }
    }
}