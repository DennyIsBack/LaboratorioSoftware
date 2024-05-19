using Dapper;
using Npgsql;
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
            CarregaAreas();
            // CarregarRegistros();
        }

        public void CarregaAreas()
        {
            try
            {
                string query = "SELECT id, nome FROM areaatuacao";

                using (var connection = new NpgsqlConnection(StringConexao.stringConexao))
                {
                    connection.Open();
                    var areas = connection.Query<Area>(query);

                    cmbArea.Items.Clear();

                    foreach (var area in areas)
                    {
                        cmbArea.Items.Add(area.Nome);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar áreas de atuação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CarregarRegistros(string tabela, string nome, string areaAtuacao)
        {
            string query = $@"SELECT p.id, p.nome, a.nome AS area FROM {tabela} p JOIN areaatuacao a ON p.id = a.id WHERE p.nome LIKE '%{nome}%' AND a.nome like '%{areaAtuacao}%'";

            using (var connection = new NpgsqlConnection(StringConexao.stringConexao))
            {
                connection.Open();

                var resultados = connection.Query<Pesquisador>(query, new { Nome = nome, AreaAtuacao = areaAtuacao });

                ListView.Items.Clear();

                foreach (var resultado in resultados)
                {
                    var item = new ListViewItem(new string[]
                    {
                        resultado.Id.ToString(),
                        resultado.Nome,
                        resultado.AreaAtuacao?.Nome ?? "Sem área"
                    });
                    ListView.Items.Add(item);
                }
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros("Pesquisador", txbNome.Text, cmbArea.Text);
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new PesquisadorManutencao("Incluir").ShowDialog();
            //CarregarRegistros();
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
            //CarregarRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];

            if (pesquisadorDAO.ExistePesquisador(int.Parse(item.SubItems[0].Text)))
            {
                MessageBox.Show("Não poderá excluir este pesquisador, pois o mesmo faz parte de um projeto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pesquisadorDAO.Delete(int.Parse(item.SubItems[0].Text));
                //CarregarRegistros();
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