using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Interfaces;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class PesquisadorManutencao : Form
    {
        private readonly ValidationPesquisador validacaoPesquisador = new();
        private readonly PesquisadorDAO pesquisadorDAO = new();
        private readonly AreaDAO areaDAO = new AreaDAO();
        private readonly string manutencao;
        private readonly int idListView;

        public PesquisadorManutencao(string man, int id = -1)
        {
            InitializeComponent();
            manutencao = man;
            idListView = id;
        }

        private void PesquisadorManutencao_Load(object sender, EventArgs e)
        {
            if (manutencao == "Incluir")
            {
                CarregaAreas(ref cmbArea);
            }
            else if (manutencao == "Editar")
            {
                if (!(idListView == -1))
                {
                    Pesquisador pesquisador = SetPesquisador(idListView);

                    SetCampos(pesquisador);

                    CarregaAreas(ref cmbArea);
                }
            }
            else if (manutencao == "Detalhes")
            {
                txbNome.Enabled = false;
                cmbArea.Enabled = false;
                txbEmail.Enabled = false;
                txbInstituicao.Enabled = false;
                txbLattes.Enabled = false;
                rdbProfessor.Enabled = false;
                rdbAluno.Enabled = false;
                btnSalvar.Visible = false;

                if (!(idListView == -1))
                {
                    Pesquisador pesquisador =SetPesquisador(idListView);

                    SetCampos(pesquisador);
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

            int? idAreaNullable = pesquisadorDAO.GetIdAreaAtuacao(idListView);
            int idArea = idAreaNullable ?? -1;

            if (manutencao == "Incluir")
            {
                try
                {
                    if (pesquisadorDAO.EmailExiste(txbEmail.Text))
                    {
                        MessageBox.Show("Email já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Pesquisador pesquisador = new()
                    {
                        Id = pesquisadorDAO.RetornaProximoId(),
                        Nome = txbNome.Text,
                        AreaAtuacao = new Area() { Id = idArea, Nome = cmbArea.Text },
                        Email = txbEmail.Text,
                        Instituicao = txbInstituicao.Text,
                        Lattes = txbLattes.Text,
                        Tipo = GetTipo()
                    };

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
            else if (manutencao == "Editar")
            {
                if (!(idListView == -1))
                {
                    try
                    {
                       Pesquisador pesquisador = SetPesquisador(idListView);

                        bool sucessoEdicao = pesquisadorDAO.Update(pesquisador);

                        if (sucessoEdicao)
                        {
                            MessageBox.Show("Edição realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao editar cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao atualizar cadastro.{Environment.NewLine}{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void SetTipo(string tipo)
        {
            if (string.Equals(tipo, "professor", StringComparison.OrdinalIgnoreCase))
            {
                rdbProfessor.Checked = true;
            }
            else
            {
                rdbAluno.Checked = true;
            }
        }

        private Pesquisador SetPesquisador(int id)
        {
            Pesquisador pesquisador = pesquisadorDAO.RecuperarID(id);

            int? idAreaNullable = pesquisadorDAO.GetIdAreaAtuacao(id);
            int idArea = idAreaNullable ?? -1;

            if (!(idArea == -1))
            {
                var nomesArea = areaDAO.RecuperarNomeArea(idArea);
                string nomeArea = nomesArea[0];

                pesquisador.AreaAtuacao = new() { Id = idArea, Nome = nomeArea };

            }
            return pesquisador;
        }

        public void SetCampos(Pesquisador pesquisador)
        {
            SetTipo(pesquisador.Tipo);

            txbNome.Text = pesquisador.Nome;
            txbInstituicao.Text = pesquisador.Instituicao;
            cmbArea.Text = pesquisador.AreaAtuacao.Nome;
            txbEmail.Text = pesquisador.Email;
            txbLattes.Text = pesquisador.Lattes;
        }
    }
}