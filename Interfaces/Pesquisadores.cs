using Dapper;
using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Windows.Forms;
using Trabalho2.DB;
using Trabalho2.Model;

namespace Trabalho2.Interfaces
{
    public partial class Pesquisadores : Form
    {
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly MenuPrincipal formMenuPrincipal;
        public int IdListBox { get; set; }

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
                    cmbArea.Items.Add("");
                    foreach (var area in areas.OrderBy(x => x.Nome))
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
            lvPesquisadores.Font = new Font(lvPesquisadores.Font, FontStyle.Bold);
            lvPesquisadores.Columns.Add("ID", 50);
            lvPesquisadores.Columns.Add("Nome", 450);
            lvPesquisadores.Columns.Add("Área", 450);
        }

        private void CarregarRegistros(string tabela, string nome, string areaAtuacao)
        {
            var pesquisadorDAO = new PesquisadorDAO();
            var areaDAO = new AreaDAO();
            List<Pesquisador> pesquisadores;

            if (string.IsNullOrEmpty(areaAtuacao))
            {
                pesquisadores = pesquisadorDAO.RecuperarPesquisadores(tabela, nome);
            }
            else
            {
                pesquisadores = pesquisadorDAO.RecuperarPesquisadoresPorArea(tabela, nome, areaAtuacao);
            }

            lvPesquisadores.Items.Clear();

            foreach (var pesquisador in pesquisadores)
            {
                string areaNome = "Sem área";

                if (pesquisador.AreaAtuacao != null)
                {
                    var nomesArea = areaDAO.RecuperarNomeArea(pesquisador.AreaAtuacao.Id);
                    if (nomesArea.Count > 0)
                    {
                        areaNome = nomesArea[0];
                    }
                }

                var item = new ListViewItem(new string[]
                {
            pesquisador.Id.ToString(),
            pesquisador.Nome ?? string.Empty,
            areaNome
                });

                lvPesquisadores.Items.Add(item);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros("Pesquisador", txbNome.Text, cmbArea.Text);
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new PesquisadorManutencao("Incluir").ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvPesquisadores.SelectedItems[0];
            PesquisadorManutencao form = new("Editar", IdListBox);
            form.ShowDialog();
            //CarregarRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvPesquisadores.SelectedItems[0];

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pesquisadorDAO.Delete(int.Parse(item.SubItems[0].Text));
                lvPesquisadores.Items.Remove(lvPesquisadores.SelectedItems[0]);
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = lvPesquisadores.SelectedItems[0];
            PesquisadorManutencao form = new("Detalhes", IdListBox);
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (lvPesquisadores.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lvPesquisadores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void lvPesquisadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPesquisadores.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPesquisadores.SelectedItems[0];

                string id = selectedItem.SubItems[0].Text;

                if (int.TryParse(id, out int idInt))
                {
                    IdListBox = idInt;
                }

            }
        }
    }
}