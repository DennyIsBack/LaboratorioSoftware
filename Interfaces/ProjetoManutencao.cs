using System.Diagnostics;
using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class ProjetoManutencao : Form
    {
        private readonly ValidationProjeto validacaoProjeto = new();
        private readonly ValidationResultado validacaoResultado = new();
        private readonly ProjetoDAO projetoDAO = new();
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly AreaDAO areaDAO = new AreaDAO();
        private readonly InstituicaoDAO instituicaoDAO = new InstituicaoDAO();
        private readonly string manutencao;
        private byte[]? arquivo;
        private Dictionary<string, int> pesquisadoresDictionary;

        public ProjetoManutencao(string man)
        {
            InitializeComponent();
            manutencao = man;

            // Configure os comboboxs
            cbxType.DataSource = new List<string>()
            {
                "Projeto científico",
                "Artigo científico"
            };
            cbxArea.DataSource = areaDAO.RecuperarAreas();

            var instituicoes = instituicaoDAO.RecuperarTodosFiltrado();
            cbxInstituicao.DataSource = instituicoes.Select(x => x.Nome).ToList();

            // Configure o TextBox para autocomplete
            pesquisadoresDictionary = pesquisadorDAO.RecuperarTodosFiltrado("", "")
                .ToDictionary(p => p.Nome, p => p.Id);

            var autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(pesquisadoresDictionary.Keys.ToArray());

            txtPesquisador.AutoCompleteCustomSource = autoCompleteCollection;
            txtPesquisador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPesquisador.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void ProjetoManutencao_Load(object sender, EventArgs e)
        {
            AdicionaColunas();

            if (manutencao == "Incluir")
            {
                Id.Text = projetoDAO.RetornaProximoId().ToString();
            }
            else
            {
                Projeto projeto = projetoDAO.RecuperarPorId(int.Parse(Id.Text));
                Titulo.Text = projeto.Nome;
                DataInicial.Text = projeto.DataInicial.ToString();
                if (projeto.DataFinal != null && projeto.DataFinal != DateTime.MinValue)
                    DataFinal.Text = projeto.DataFinal.ToString();
                cbxArea.SelectedItem = projeto.AreaDeAtuacao?.Nome;
                cbxInstituicao.SelectedItem = projeto.Instituicao?.Nome;
                cbxType.SelectedItem = projeto.Tipo;
                chkFinalizado.Checked = projeto.Finalizado;
                DataFinal.Enabled = true;
                chkFinalizado.Enabled = true;

                if (projeto.DataFinal.Date != null && projeto.DataFinal.Date != DateTime.MinValue)
                {
                    DataFinal.CustomFormat = "dd/MM/yyyy";
                    DataFinal.Text = projeto.DataFinal.ToString();
                    Titulo.Enabled = false;
                    DataInicial.Enabled = false;
                }

                for (int i = 0; i < projeto.Pesquisadores?.Count; i++)
                {
                    ListViewItem listItem = new(projeto.Pesquisadores[i].Id.ToString())
                    {
                        Font = new Font(ListView.Font, FontStyle.Regular)
                    };
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, projeto.Pesquisadores[i].Nome));
                    if (projeto.Pesquisadores[i].AreaAtuacao != null && !string.IsNullOrEmpty(projeto.Pesquisadores[i]?.AreaAtuacao?.Nome))
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, projeto.Pesquisadores[i]?.AreaAtuacao?.Nome));

                    ListView.Items.Add(listItem);
                }

                arquivo = projeto.Resultado?.Arquivo;

                if (manutencao == "Detalhes")
                {
                    Titulo.Enabled = false;
                    DataInicial.Enabled = false;
                    DataFinal.Enabled = false;
                    cbxArea.Enabled = false;
                    cbxInstituicao.Enabled = false;
                    cbxType.Enabled = false;
                    chkFinalizado.Enabled = false;

                    label10.Visible = false;
                    txtPesquisador.Visible = false;
                    IncluirPesquisador.Visible = false;
                    RemoverPesquisador.Visible = false;
                    Salvar.Visible = false;

                    ListView.Dock = DockStyle.Fill;
                }
            }
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 50);
            ListView.Columns.Add("Nome", 560);
            ListView.Columns.Add("Área", 160);
        }

        private void DataInicial_ValueChanged(object sender, EventArgs e)
        {
            DataInicial.CustomFormat = "dd/MM/yyyy";
        }

        private void DataInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DataInicial.CustomFormat = " ";
            }
        }

        private void DataFinal_ValueChanged(object sender, EventArgs e)
        {
            DataFinal.CustomFormat = "dd/MM/yyyy";
        }

        private void DataFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DataFinal.CustomFormat = " ";
            }
        }

        private void IncluirPesquisador_Click(object sender, EventArgs e)
        {
            var valid = validacaoProjeto.PesquisadorEntrada(ListView, txtPesquisador.Text, pesquisadoresDictionary);
            if (valid == null)
            {
                return;
            }

            Pesquisador pesquisador = pesquisadorDAO.RecuperarID(Convert.ToInt32(valid));

            ListViewItem listItem = new(pesquisador.Id.ToString())
            {
                Font = new Font(ListView.Font, FontStyle.Regular)
            };
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, pesquisador.Nome));
            if (pesquisador.AreaAtuacao != null && !string.IsNullOrEmpty(pesquisador.AreaAtuacao.Nome))
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, pesquisador.AreaAtuacao.Nome));
            ListView.Items.Add(listItem);

            txtPesquisador.Text = null;
        }

        private void RemoverPesquisador_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListView.Items.RemoveAt(ListView.SelectedIndices[0]);
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

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoProjeto.TituloEntrada(Titulo.Text))
            {
                Titulo.Focus();
                return;
            }

            if (!validacaoProjeto.DataInicialEntrada(DataInicial))
            {
                DataInicial.Focus();
                return;
            }

            if (!validacaoProjeto.VerificaPesquisadores(ListView))
            {
                return;
            }

            var AreaId = areaDAO.GetIdByName(cbxArea.SelectedValue.ToString());

            var listInstituicao = instituicaoDAO.RecuperarTodosFiltrado(cbxInstituicao.Text);

            int instituicaoId = 0;

            foreach (var inst in listInstituicao)
            {
                if (cbxInstituicao.Text == inst.Nome)
                {
                    instituicaoId = inst.Id;
                }
            }

            Projeto projeto = new()
            {
                Id = int.Parse(Id.Text),
                Nome = Titulo.Text,
                DataInicial = DataInicial.Value,
                //DataFinal = DataFinal.Value,
                Finalizado = chkFinalizado.Checked,
                Pesquisadores = new(),
                AreaDeAtuacao = new Area() { Id = AreaId },
                Instituicao = new Instituicao() { Id = instituicaoId },
                Tipo = cbxType.Text,

            };

            foreach (ListViewItem item in ListView.Items)
            {
                Pesquisador pesquisador = new()
                {
                    Id = int.Parse(item.SubItems[0].Text)
                };

                projeto.Pesquisadores.Add(pesquisador);
            }

            if (manutencao == "Incluir")
            {
                projetoDAO.Insert(projeto);
            }
            else
            {
                projetoDAO.Update(projeto);
            }

            Close();
        }
    }
}