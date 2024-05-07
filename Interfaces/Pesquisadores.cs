using Trabalho2.DB;
using Trabalho2.Model;

namespace Trabalho2.Interfaces
{
    public partial class Pesquisadores : Form
    {
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly MenuPrincipal formMenuPrincipal;

        public Pesquisadores(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void Pesquisadores_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnPesquisadores.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 50);
            ListView.Columns.Add("Nome", 450);
            ListView.Columns.Add("Área", 450);
        }

        private void CarregarRegistros()
        {
            //ListView.Items.Clear();
            //List<Pesquisador> itemList = pesquisadorDAO.RecuperarTodosFiltrado(NomeFiltro.Text, AreaFiltro.Text);

            //for (int i = 0; i < itemList.Count; i++)
            //{
            //    ListViewItem listItem = new(itemList[i].Id.ToString())
            //    {
            //        Font = new Font(ListView.Font, FontStyle.Regular)
            //    };
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Nome));
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Area));
            //    ListView.Items.Add(listItem);
            //}
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new PesquisadorManutencao("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            PesquisadorManutencao form = new("Editar");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
            CarregarRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];

            if (pesquisadorDAO.ExistePesquisadorProjeto(int.Parse(item.SubItems[0].Text)))
            {
                MessageBox.Show("Não poderá excluir este pesquisador, pois o mesmo faz parte de um projeto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pesquisadorDAO.Delete(int.Parse(item.SubItems[0].Text));
                CarregarRegistros();
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            PesquisadorManutencao form = new("Detalhes");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (ListView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}