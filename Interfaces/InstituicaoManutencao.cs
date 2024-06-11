using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho2.DB;
using Trabalho2.Model;
using Trabalho2.Validation;

namespace Trabalho2.Interfaces
{
    public partial class InstituicaoManutencao : Form
    {
        private readonly string manutencao;
        private readonly int idListView;
        private readonly InstituicaoDAO instituicaoDAO;
        private readonly Instituicoes instituicoesForm;
        public InstituicaoManutencao(string man, Instituicoes form, int id = -1)
        {
            InitializeComponent();
            manutencao = man;
            idListView = id;
            instituicaoDAO = new InstituicaoDAO();
            instituicoesForm = form;

            Label.Text = manutencao;

            if (manutencao == "Editar" || manutencao == "Detalhes")
            {
                Instituicao inst = instituicaoDAO.RecuperarID(idListView);

                SetFields(inst);

                if (manutencao == "Detalhes")
                {
                    txbNome.Enabled = false;
                    txbEndereco.Enabled = false;
                    txbSigla.Enabled = false;
                    txbSite.Enabled = false;
                    btnSalvar.Visible = false;
                }
            }
        }

        private void SetFields(Instituicao instuticao)
        {
            txbNome.Text = instuticao.Nome;
            txbSigla.Text = instuticao.Sigla;
            txbEndereco.Text = instuticao.Endereco;
            txbSite.Text = instuticao.Site;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidationInstituicao.Valid(txbNome.Text, txbEndereco.Text, txbSite.Text, txbSigla.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return;
            }

            if (manutencao == "Incluir")
            {
                try
                {
                    if (instituicaoDAO.InstituicaoExiste(txbNome.Text))
                    {
                        MessageBox.Show("Instituição já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Instituicao Inst = new()
                    {
                        Id = instituicaoDAO.RetornaProximoId(),
                        Nome = txbNome.Text,
                        Endereco = txbEndereco.Text,
                        Site = txbSite.Text,
                        Sigla = txbSigla.Text,
                    };

                    bool TransacaoOK = instituicaoDAO.Insert(Inst);

                    if (TransacaoOK)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir instituicao", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Instituicao Inst = new Instituicao()
                        {
                            Id = idListView,
                            Nome = txbNome.Text,
                            Endereco = txbEndereco.Text,
                            Site = txbSite.Text,
                            Sigla = txbSigla.Text,
                        };

                        bool sucessoEdicao = instituicaoDAO.Update(Inst);

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
            instituicoesForm.getInstituicoes(txbNome.Text);
        }
    }
}
