using Trabalho2.DB;

namespace Trabalho2.Validation
{
    public class ValidationProjeto
    {
        private readonly PesquisadorDAO pesquisadorDAO = new();

        public bool TituloEntrada(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Informe o título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool DataInicialEntrada(DateTimePicker dataInicial)
        {
            if (dataInicial.CustomFormat == " ")
            {
                MessageBox.Show("Informe a data inicial!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataInicial.Value > DateTime.Now)
            {
                MessageBox.Show("Data inicial inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool PesquisadorEntrada(ListView listView, string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Informe o ID do pesquisador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(id, out int id_int))
            {
                MessageBox.Show("O ID informado não é um número!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!pesquisadorDAO.ExistePesquisador(id_int))
            {
                MessageBox.Show("Não existe pesquisador com o ID informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    MessageBox.Show("Este pesquisador já foi informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public bool VerificaPesquisadores(ListView listView)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Informe pelo menos um pesquisador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}