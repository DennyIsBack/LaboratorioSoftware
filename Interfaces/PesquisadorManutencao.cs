using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class PesquisadorManutencao : Form
    {
        private readonly ValidationPesquisador validacaoPesquisador = new();
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly AreaDAO areaDAO = new AreaDAO(); // Adicionando instância de AreaDAO
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
                CarregaAreas(ref cmbArea);
            }
            else
            {
                Pesquisador pesquisador = pesquisadorDAO.RecuperarPorId(int.Parse(pesquisadorDAO.RetornaProximoId().ToString()));
                txbNome.Text = pesquisador.Nome;

                if (manutencao == "Detalhes")
                {
                    txbNome.Enabled = false;
                    cmbArea.Enabled = false;
                    Salvar.Visible = false;
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoPesquisador.DadosPesquisador(txbNome.Text, cmbArea.Text, txbEmail.Text, txbInstituicao.Text, txbLattes.Text, GetTipo()))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return;
            }

            if (pesquisadorDAO.EmailExiste(txbEmail.Text))
            {
                MessageBox.Show("Email já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pesquisador pesquisador = new()
            {
                Id = pesquisadorDAO.RetornaProximoId(),
                Nome = txbNome.Text,
                AreaAtuacao = new Area() { Nome = cmbArea.Text },
                Email = txbEmail.Text,
                Instituicao = txbInstituicao.Text,
                Lattes = txbLattes.Text,
                Tipo = GetTipo()
            };

            if (manutencao == "Incluir")
            {
                try
                {
                    pesquisador.AreaAtuacao.Id = areaDAO.Insert(pesquisador.AreaAtuacao.Nome);

                    bool sucessoPesquisador = pesquisadorDAO.Insert(pesquisador);

                    if (sucessoPesquisador)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir pesquisador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao realizar cadastro.{Environment.NewLine}{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pesquisadorDAO.Update(pesquisador);
            }
            Close();
        }

        private void CarregaAreas(ref ComboBox cmb)
        {
            List<string> areas = areaDAO.RecuperarAreas();

            cmb.Items.Clear();

            foreach (string area in areas)
            {
                cmb.Items.Add(area);
            }
        }

        private string GetTipo()
        {
            string tipo = "";

            if (rdbProfessor.Checked)
            {
                tipo = "Professor";
            }
            else if (rdbAluno.Checked)
            {
                tipo = "Aluno";
            }
            return tipo;
        }
    }
}