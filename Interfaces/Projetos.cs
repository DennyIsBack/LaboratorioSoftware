using System.Diagnostics;
using Trabalho2.DB;
using Trabalho2.Model;

namespace Trabalho2.Interfaces
{
    public partial class Projetos : Form
    {
        private readonly ProjetoDAO projetoDAO = new();
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly MenuPrincipal formMenuPrincipal;

        public Projetos(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void Projetos_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnProjetos.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 50);
            ListView.Columns.Add("Título", 600);
            ListView.Columns.Add("Data Inicial", 150);
            ListView.Columns.Add("Data Final", 150);
        }

        private void CarregarRegistros()
        {
            //ListView.Items.Clear();
            //List<Projeto> itemList = projetoDAO.RecuperarTodosFiltrado(TituloFiltro.Text, DataInicialFiltro);

            //for (int i = 0; i < itemList.Count; i++)
            //{
            //    ListViewItem listItem = new(itemList[i].Id.ToString())
            //    {
            //        Font = new Font(ListView.Font, FontStyle.Regular)
            //    };
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Titulo));
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataInicial.ToString("dd/MM/yyyy")));
            //    if (itemList[i].DataFinal.Date != Convert.ToDateTime("01/01/0001").Date)
            //    {
            //        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataFinal.ToString("dd/MM/yyyy")));
            //    }
            //    else
            //    {
            //        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, null));
            //    }
            //    ListView.Items.Add(listItem);
            //}
        }

        private void DataInicialFiltro_ValueChanged(object sender, EventArgs e)
        {
            DataInicialFiltro.CustomFormat = "dd/MM/yyyy";
        }

        private void DataInicialFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DataInicialFiltro.CustomFormat = " ";
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new ProjetoManutencao("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            ProjetoManutencao form = new("Editar");
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

            if (!string.IsNullOrWhiteSpace(item.SubItems[3].Text))
            {
                MessageBox.Show("Não poderá excluir este projeto, pois o mesmo está finalizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projetoDAO.Delete(int.Parse(item.SubItems[0].Text));
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
            ProjetoManutencao form = new("Detalhes");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private void FinalizarProjeto_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];

            if (!string.IsNullOrWhiteSpace(item.SubItems[3].Text))
            {
                MessageBox.Show("O projeto já está finalizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (resultadoDAO.RetornaArquivo(int.Parse(item.SubItems[0].Text)) == null)
            {
                MessageBox.Show("Não poderá finalizar este projeto, pois o mesmo ainda não possui resultado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirma finalizar este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projetoDAO.Finalizar(int.Parse(item.SubItems[0].Text));
                CarregarRegistros();
            }
        }

        private void VisualizarResultado_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];

            string filePath;
            byte[] arquivo = resultadoDAO.RetornaArquivo(int.Parse(item.SubItems[0].Text));

            if (arquivo == null)
            {
                MessageBox.Show("Ainda não há resultado neste projeto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filePath = "C:\\Users\\" + Environment.UserName + "\\Downloads\\" + resultadoDAO.RetornaDescricaoArquivo(int.Parse(item.SubItems[0].Text));
            File.WriteAllBytes(filePath, arquivo);
            Process.Start("explorer.exe", "/select," + filePath);
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