using Trabalho2.DB;

namespace Trabalho2.Validation
{
    public class ValidationResultado
    {
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly ProjetoDAO projetoDAO = new();

        public bool Projeto(string projeto)
        {
            if (string.IsNullOrWhiteSpace(projeto))
            {
                MessageBox.Show("Selecione o projeto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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