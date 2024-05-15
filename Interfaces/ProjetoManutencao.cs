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
        private readonly string manutencao;
        private byte[]? arquivo;

        public ProjetoManutencao(string man)
        {
            InitializeComponent();
            manutencao = man;
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
                if (projeto.DataFinal.Date != Convert.ToDateTime("01/01/0001").Date)
                {
                    DataFinal.CustomFormat = "dd/MM/yyyy";
                    DataFinal.Text = projeto.DataFinal.ToString();
                    Titulo.Enabled = false;
                    DataInicial.Enabled = false;
                    IdPesquisadorLabel.Visible = false;
                    IdPesquisador.Visible = false;
                    IncluirPesquisador.Visible = false;
                    RemoverPesquisador.Visible = false;
                    ListView.Dock = DockStyle.Fill;
                }

                for (int i = 0; i < projeto.Pesquisadores?.Count; i++)
                {
                    ListViewItem listItem = new(projeto.Pesquisadores[i].Id.ToString())
                    {
                        Font = new Font(ListView.Font, FontStyle.Regular)
                    };
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, projeto.Pesquisadores[i].Nome));
                    ListView.Items.Add(listItem);
                }

                IdResultado.Text = projeto.Resultado?.Id.ToString();
                Descricao.Text = projeto.Resultado?.Descricao;
                Descricao_Arquivo.Text = projeto.Resultado?.DescricaoArquivo;
                arquivo = projeto.Resultado?.Arquivo;

                if (manutencao == "Detalhes")
                {
                    Titulo.Enabled = false;
                    DataInicial.Enabled = false;
                    IdResultado.Enabled = false;

                    IdPesquisadorLabel.Visible = false;
                    IdPesquisador.Visible = false;
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
            ListView.Columns.Add("Área", 110);
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

        private void IncluirPesquisador_Click(object sender, EventArgs e)
        {
            if (!validacaoProjeto.PesquisadorEntrada(ListView, IdPesquisador.Text))
            {
                return;
            }

            Pesquisador pesquisador = pesquisadorDAO.RecuperarPorId(int.Parse(IdPesquisador.Text));

            ListViewItem listItem = new(pesquisador.Id.ToString())
            {
                Font = new Font(ListView.Font, FontStyle.Regular)
            };
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, pesquisador.Nome));
            ListView.Items.Add(listItem);

            IdPesquisador.Text = null;
        }

        private void RemoverPesquisador_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListView.Items.RemoveAt(ListView.SelectedIndices[0]);
        }

        private void IdResultado_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IdResultado.Text))
            {
                if (!validacaoResultado.VerificaResultado(int.Parse(Id.Text), int.Parse(IdResultado.Text)))
                {
                    LimparCamposResultado();
                    return;
                }

                Resultado resultado = resultadoDAO.RecuperarPorId(int.Parse(IdResultado.Text));
                Descricao.Text = resultado.Descricao;
                Descricao_Arquivo.Text = resultado.DescricaoArquivo;
                arquivo = resultado.Arquivo;
            }
            else
            {
                LimparCamposResultado();
            }
        }

        private void LimparCamposResultado()
        {
            IdResultado.Text = null;
            Descricao.Text = null;
            Descricao_Arquivo.Text = null;
            arquivo = null;
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            string filePath;

            if (!validacaoResultado.ArquivoEntrada(Descricao_Arquivo.Text))
            {
                return;
            }

            filePath = "C:\\Users\\" + Environment.UserName + "\\Downloads\\" + Descricao_Arquivo.Text;
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

            if (!string.IsNullOrWhiteSpace(DataFinal.Text))
            {
                if (!validacaoResultado.VerificaResultadoEntrada(IdResultado.Text))
                {
                    return;
                }
            }

            Projeto projeto = new()
            {
                Id = int.Parse(Id.Text),
                Nome = Titulo.Text,
                DataInicial = DataInicial.Value,
                Pesquisadores = new()
            };

            if (!string.IsNullOrWhiteSpace(IdResultado.Text))
            {
                if (resultadoDAO.ExisteResultado(int.Parse(IdResultado.Text)))
                {
                    projeto.Resultado = new()
                    {
                        Id = int.Parse(IdResultado.Text)
                    };
                }
            }

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