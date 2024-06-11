using Dapper;
using Npgsql;
using Trabalho2.Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Trabalho2.Interfaces;
using System.Diagnostics;

namespace Trabalho2.DB
{
    public class InstituicaoDAO : IDisposable
    {
        string? sql;

        public bool Insert(Instituicao instituicao)
        {
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = @"INSERT INTO instituicao (id, nome, Sigla, Endereco, Site)
                           VALUES (@id, @nome, @sigla, @endereco, @site)";

                int rowsAffected = connection.Execute(sql, new
                {
                    id = instituicao.Id,
                    Nome = instituicao.Nome,
                    Sigla = instituicao.Sigla,
                    Endereco = instituicao.Endereco,
                    Site = instituicao.Site,

                });

                return rowsAffected > 0;
            }
        }

        public bool Update(Instituicao instituicao)
        {
            {
                using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

                string sql = $@"UPDATE instituicao SET nome = '{instituicao.Nome}', sigla = '{instituicao.Sigla}', Endereco = '{instituicao.Endereco}', Site = '{instituicao.Site}' WHERE id = {instituicao.Id}";

                int rowsAffected = connection.Execute(sql);

                return rowsAffected > 0;
            }
        }

        public void Delete(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"DELETE FROM instituicao
                     WHERE id = @id";

            connection.Execute(sql, param: new { id });
        }

        public List<Instituicao> RecuperarTodosFiltrado(string nomeInstituicao = "")
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                      FROM instituicao
                     WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(nomeInstituicao))
            {
                sql += " AND upper(nome) LIKE upper(CONCAT('%', @nome, '%'))";
            }

            sql += " ORDER BY nome";

            return (List<Instituicao>)connection.Query<Instituicao>(sql,
                   param: new
                   {
                       nome = nomeInstituicao,
                       //sigla = sigla
                   });
        }

        public Instituicao RecuperarID(int id)
        {
            using NpgsqlConnection connection = new(StringConexao.stringConexao);

            sql = @"SELECT *
                     FROM instituicao
                     WHERE id = @id";

            return connection.QuerySingle<Instituicao>(sql, param: new { id });
        }   

        public int RetornaProximoId()
        {
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"SELECT COALESCE(MAX(id), 0) + 1 FROM instituicao";

            return connection.QuerySingle<int>(sql);
        }

        public bool InstituicaoExiste(string nome)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao);

            string sql = @"SELECT COUNT(*) FROM instituicao WHERE nome = @nome";

            int count = connection.ExecuteScalar<int>(sql, param: new { nome });

            return count > 0;
        } 
       
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}