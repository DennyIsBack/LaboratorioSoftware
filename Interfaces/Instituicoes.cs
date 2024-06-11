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

namespace Trabalho2.Interfaces
{
    public partial class Instituicoes : Form
    {
        private readonly InstituicaoDAO instituicaoDAO;

        private readonly MenuPrincipal formMenuPrincipal;

        public Instituicoes(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
            instituicaoDAO = new InstituicaoDAO();
        }

        private void Instituicao_Load(object sender, EventArgs e)
        {
            var instituicao = instituicaoDAO.RecuperarTodosFiltrado();

            ListView.Items.Clear();

            foreach (var inst in instituicao)
            {
                var item = new ListViewItem(new string[]
                {
                    inst.Id.ToString(),
                    inst?.Nome,
                    inst?.Sigla
                });

                ListView.Items.Add(item);
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnInstituicao.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        //private void AutoComplet_Event()
        //{

        //}
        private void Novo_Click(object sender, EventArgs e)
        {
            var id = ListView.SelectedItems;
            new InstituicaoManutencao("Incluir", this).ShowDialog();
            //CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (VerificaList())
            {
                ListViewItem item = ListView.SelectedItems[0];

                var id = Convert.ToInt32(item.Text);

                new InstituicaoManutencao("Editar", this, id).ShowDialog();
            }
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

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (VerificaList())
            {
                ListViewItem item = ListView.SelectedItems[0];

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    instituicaoDAO.Delete(int.Parse(item.SubItems[0].Text));
                    ListView.Items.Remove(ListView.SelectedItems[0]);
                    MessageBox.Show("Registro removido com sucesso!", "Atenção", MessageBoxButtons.OK);
                }
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var instituicao = instituicaoDAO.RecuperarTodosFiltrado(txbNome.Text);

            ListView.Items.Clear();

            foreach (var inst in instituicao)
            {
                var item = new ListViewItem(new string[]
                {
                    inst.Id.ToString(),
                    inst?.Nome,
                    inst?.Sigla
                });


                ListView.Items.Add(item);
            }
        }

        public void getInstituicoes(string text = "")
        {
            var instituicao = instituicaoDAO.RecuperarTodosFiltrado(text);

            ListView.Items.Clear();

            foreach (var inst in instituicao)
            {
                var item = new ListViewItem(new string[]
                {
                    inst.Id.ToString(),
                    inst?.Nome,
                    inst?.Sigla
                });


                ListView.Items.Add(item);
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (VerificaList())
            {
                ListViewItem item = ListView.SelectedItems[0];

                var id = Convert.ToInt32(item.Text);

                new InstituicaoManutencao("Detalhes", this, id).ShowDialog();
            }
        }
    }
}
