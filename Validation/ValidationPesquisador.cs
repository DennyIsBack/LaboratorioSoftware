namespace Trabalho2.Validation
{
    public class ValidationPesquisador
    {
        public bool NomeEntrada(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool AreaEntrada(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe a área!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}