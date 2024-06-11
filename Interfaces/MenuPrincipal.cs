namespace Trabalho2.Interfaces
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormInPainel(object form)
        {
            if (Painel.Controls.Count > 0)
            {
                if (Painel.Controls[0].Name == form.GetType().Name)
                {
                    return;
                }

                Painel.Controls.RemoveAt(0);
            }

            if (form is Form fh)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                Painel.Controls.Add(fh);
                Painel.Tag = fh;
                fh.Show();
            }
        }

        private void BtnPesquisadores_Click(object sender, EventArgs e)
        {
            BtnPesquisadores.BackColor = Color.FromArgb(45, 45, 48);
            BtnResultados.BackColor = Color.FromArgb(25, 25, 112);
            BtnProjetos.BackColor = Color.FromArgb(25, 25, 112);
            BtnInstituicao.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Pesquisadores(this));
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            BtnPesquisadores.BackColor = Color.FromArgb(25, 25, 112);
            BtnResultados.BackColor = Color.FromArgb(45, 45, 48);
            BtnProjetos.BackColor = Color.FromArgb(25, 25, 112);
            BtnInstituicao.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Resultados(this));
        }

        private void BtnProjetos_Click(object sender, EventArgs e)
        {
            BtnPesquisadores.BackColor = Color.FromArgb(25, 25, 112);
            BtnResultados.BackColor = Color.FromArgb(25, 25, 112);
            BtnProjetos.BackColor = Color.FromArgb(45, 45, 48);
            BtnInstituicao.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Projetos(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnPesquisadores.BackColor = Color.FromArgb(25, 25, 112);
            BtnResultados.BackColor = Color.FromArgb(25, 25, 112);
            BtnProjetos.BackColor = Color.FromArgb(25, 25, 112);
            BtnInstituicao.BackColor = Color.FromArgb(45, 45, 48);
            AbrirFormInPainel(new Instituicoes(this));
        }
    }
}