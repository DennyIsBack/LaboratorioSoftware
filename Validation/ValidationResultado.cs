using Trabalho2.DB;

namespace Trabalho2.Validation
{
    public class ValidationResultado
    {
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly ProjetoDAO projetoDAO = new();

        public bool DescricaoEntrada(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Informe a descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool ArquivoEntrada(string descricao_Arquivo)
        {
            if (string.IsNullOrWhiteSpace(descricao_Arquivo))
            {
                MessageBox.Show("Selecione um arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool VerificaResultado(int id_projeto, int id_resultado)
        {
            if (!resultadoDAO.ExisteResultado(id_resultado))
            {
                MessageBox.Show("O resultado informado não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (projetoDAO.ExisteResultadoProjeto(id_projeto, id_resultado))
            {
                MessageBox.Show("O resultado informado já existe em outro projeto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool VerificaResultadoEntrada(string id_resultado)
        {
            if (string.IsNullOrWhiteSpace(id_resultado))
            {
                MessageBox.Show("Informe o resultado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}