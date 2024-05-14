using System.Diagnostics;
using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class ResultadoManutencao : Form
    {
        private readonly ValidationResultado validacaoResultado = new();
        private readonly ResultadoDAO resultadoDAO = new();
        private readonly string manutencao;
        private byte[]? arquivo;

        public ResultadoManutencao(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void ResultadoManutencao_Load(object sender, EventArgs e)
        {
            if (manutencao == "Incluir")
            {
                Id.Text = resultadoDAO.RetornaProximoId().ToString();
            }
            else
            {
                Resultado resultado = resultadoDAO.RecuperarPorId(int.Parse(Id.Text));
                Descricao.Text = resultado.Descricao;
                Descricao_Arquivo.Text = resultado.Descricao;
                arquivo = resultado.Arquivo;

                if (manutencao == "Detalhes")
                {
                    Descricao.Enabled = false;
                    EscolherArquivo.Visible = false;
                    Salvar.Visible = false;
                }
            }
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

        private void EscolherArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new()
            {
                Filter = "Todos os arquivos|*.*"
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

                arquivo = File.ReadAllBytes(open.FileName);
                Descricao_Arquivo.Text = file.Name;
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoResultado.DescricaoEntrada(Descricao.Text))
            {
                Descricao.Focus();
                return;
            }

            if (!validacaoResultado.ArquivoEntrada(Descricao_Arquivo.Text))
            {
                return;
            }

            Resultado resultado = new()
            {
                Id = int.Parse(Id.Text),
                Descricao = Descricao.Text,
                DescricaoArquivo = Descricao_Arquivo.Text,
                Arquivo = arquivo
            };

            if (manutencao == "Incluir")
            {
                resultadoDAO.Insert(resultado);
            }
            else
            {
                resultadoDAO.Update(resultado);
            }

            Close();
        }
    }
}