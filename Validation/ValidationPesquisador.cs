using Trabalho2.DB;

namespace Trabalho2.Validation
{
    public class ValidationPesquisador
    {
        public bool DadosPesquisador(string nome, string area, string email, string instituicao, string lattes, string tipo)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(area) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(instituicao) || string.IsNullOrWhiteSpace(lattes) || string.IsNullOrWhiteSpace(tipo))
            {
                return false;
            }
            return true;
        }
    }
}