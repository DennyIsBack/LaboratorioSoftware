using Trabalho2.DB;
using Trabalho2.Model;

namespace Trabalho2.Interfaces
{
    public partial class Resultados : Form
    {
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly ProjetoDAO projetoDAO = new();
        private readonly MenuPrincipal formMenuPrincipal;

        public Resultados(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnResultados.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void CarregaRegistros()
        {
            lvResultado.Items.Clear();

            ResultadoDAO resultadoDAO = new ResultadoDAO();
            List<Resultado> registros = resultadoDAO.CarregaRegistros(cmbProjeto.Text);

            foreach (var resultado in registros)
            {
                string projeto = projetoDAO.GetNomeProjeto(resultado.id_projeto);

                ListViewItem item = new ListViewItem(resultado.Id.ToString());

                item.SubItems.Add(projeto);

                lvResultado.Items.Add(item);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregaRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new ResultadoManutencao("Incluir").ShowDialog();
            CarregaRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvResultado.SelectedItems[0];
            ResultadoManutencao form = new("Editar");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
            CarregaRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvResultado.SelectedItems[0];

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resultadoDAO.Delete(int.Parse(item.SubItems[0].Text));
                CarregaRegistros();
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvResultado.SelectedItems[0];
            ResultadoManutencao form = new("Detalhes");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (lvResultado.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lvResultado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            PopulaProjetos(cmbProjeto);
        }

        public void PopulaProjetos(ComboBox cmbProjeto)
        {
            List<string> nomesProjetos = projetoDAO.GetListaProjetos();

            cmbProjeto.Items.Clear();

            foreach (string nomeProjeto in nomesProjetos)
            {
                cmbProjeto.Items.Add(nomeProjeto);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbProjeto.SelectedIndex = -1;
        }
            }
}