using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class PesquisadorManutencao : Form
    {
        private readonly ValidationPesquisador validacaoPesquisador = new();
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly string manutencao;

        public PesquisadorManutencao(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void PesquisadorManutencao_Load(object sender, EventArgs e)
        {
            if (manutencao == "Incluir")
            {
                Id.Text = pesquisadorDAO.RetornaProximoId().ToString();
            }
            else
            {
                Pesquisador pesquisador = pesquisadorDAO.RecuperarPorId(int.Parse(Id.Text));
                Nome.Text = pesquisador.Nome;
                Area.Text = pesquisador?.Area?.Descricao;

                if (manutencao == "Detalhes")
                {
                    Nome.Enabled = false;
                    Area.Enabled = false;
                    Salvar.Visible = false;
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoPesquisador.NomeEntrada(Nome.Text))
            {
                Nome.Focus();
                return;
            }

            if (!validacaoPesquisador.AreaEntrada(Area.Text))
            {
                Area.Focus();
                return;
            }

            Area AuxArea = new Area()
            {
                Descricao = Area.Text
            };

            Pesquisador pesquisador = new()
            {
                Id = int.Parse(Id.Text),
                Nome = Nome.Text,
                Area = AuxArea
            };

            if (manutencao == "Incluir")
            {
                pesquisadorDAO.Insert(pesquisador);
            }
            else
            {
                pesquisadorDAO.Update(pesquisador);
            }

            Close();
        }
    }
}