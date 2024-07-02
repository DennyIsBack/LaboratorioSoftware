using Trabalho2.DB;
using Trabalho2.Interfaces;

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

        public bool DataFinalEntrada(DateTimePicker dataInicial)
        {
            if (dataInicial.CustomFormat == " ")
            {
                MessageBox.Show("Informe a data final!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public int? PesquisadorEntrada(ListView listView, string text, Dictionary<string, int> pesquisadores)
        {
            if (pesquisadores.TryGetValue(text, out int id))
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text == id.ToString())
                    {
                        MessageBox.Show("Este pesquisador já foi informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }

                return id;
            }
            else
            {
                MessageBox.Show("Não existe pesquisador com o filtro informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
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