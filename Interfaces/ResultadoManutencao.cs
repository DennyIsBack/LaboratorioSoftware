using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;
using PdfiumViewer;
using System.Diagnostics;

namespace Trabalho2.Interfaces
{
    public partial class ResultadoManutencao : Form
    {
        private readonly ValidationResultado validacaoResultado = new();
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly ProjetoDAO projetoDAO = new();
        private readonly string manutencao;
        private byte[]? arquivo;

        public ResultadoManutencao(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void ResultadoManutencao_Load(object sender, EventArgs e)
        {
            PopulaProjetos(cmbProjeto);

            if (manutencao == "Incluir")
            {
                Id.Text = resultadoDAO.RetornaProximoId().ToString();
            }
            else
            {
                Resultado resultado = resultadoDAO.RecuperarPorId(int.Parse(Id.Text));
                cmbProjeto.SelectedItem = projetoDAO.GetNomeProjeto(resultado.id_projeto);
                txbArquivo.Text = resultado.nome_arquivo;
                arquivo = resultado.Arquivo;

                if (manutencao == "Detalhes")
                {
                    EscolherArquivo.Visible = false;
                    Visualizar.Visible = true;
                    Visualizar.Location = new Point(609, 156);
                    Salvar.Visible = false;
                }
            }
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

        private void Visualizar_Click(object sender, EventArgs e)
        {
            Resultado resultado = resultadoDAO.RecuperarPorId(int.Parse(Id.Text));

            try
                {
                    string nomeArquivo = resultado.nome_arquivo;

                    string pastaDownloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    string caminhoCompleto = Path.Combine(pastaDownloads, nomeArquivo);

                    File.WriteAllBytes(caminhoCompleto, resultado.Arquivo);

                    Process.Start("explorer.exe", pastaDownloads);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar ou abrir o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void EscolherArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new()
            {
                Filter = "Arquivos PDF|*.pdf"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new(open.FileName);

                if (file.Length == 0)
                {
                    MessageBox.Show("O arquivo selecionado está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (file.Length > 1048576000) // 1GB
                {
                    MessageBox.Show("O arquivo selecionado é muito grande!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (file.Extension.ToLower() != ".pdf")
                {
                    MessageBox.Show("Por favor, selecione um arquivo PDF!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                arquivo = File.ReadAllBytes(open.FileName);
                txbArquivo.Text = file.Name;
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoResultado.Projeto(cmbProjeto.Text))
            {
                cmbProjeto.Focus();
                return;
            }

            if (!validacaoResultado.ArquivoEntrada(txbArquivo.Text))
            {
                return;
            }

            if (arquivo == null || arquivo.Length == 0)
            {
                MessageBox.Show("Nenhum arquivo foi selecionado ou o arquivo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (resultadoDAO.RetornaArquivo(Convert.ToInt32(projetoDAO.GetID(cmbProjeto.Text))) != null)
            {
                MessageBox.Show("O projeto selecionado já tem um resultado cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Resultado resultado = new()
            {
                Id = int.Parse(Id.Text),
                id_projeto = projetoDAO.GetID(cmbProjeto.Text),
                nome_arquivo = txbArquivo.Text,
                Arquivo = arquivo
            };

            if (manutencao == "Incluir")
            {
                bool sucessoUpdate = resultadoDAO.Insert(resultado);

                if (sucessoUpdate)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao realizar cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool sucessoUpdate = resultadoDAO.Update(resultado);

                if (sucessoUpdate)
                {
                    MessageBox.Show("Edição realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao editar cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
            Close();
        }
        private void VisualizarPDF(byte[] pdfBytes)
        {
            using (MemoryStream stream = new MemoryStream(pdfBytes))
            using (PdfDocument doc = PdfDocument.Load(stream))
            {
                using (PdfViewer viewer = new PdfViewer())
                {
                    viewer.Document = doc;
                    viewer.Dock = DockStyle.Fill;
                    panelVisualizacao.Controls.Add(viewer);
                }
            }
        }
    }
}