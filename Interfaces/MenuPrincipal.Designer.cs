namespace Trabalho2.Interfaces
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            MenuVertical = new Panel();
            BtnInstituicao = new Button();
            BtnProjetos = new Button();
            BtnResultados = new Button();
            label1 = new Label();
            BtnPesquisadores = new Button();
            Painel = new Panel();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.MidnightBlue;
            MenuVertical.Controls.Add(BtnInstituicao);
            MenuVertical.Controls.Add(BtnProjetos);
            MenuVertical.Controls.Add(BtnResultados);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(BtnPesquisadores);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 3, 4, 3);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 591);
            MenuVertical.TabIndex = 0;
            // 
            // BtnInstituicao
            // 
            BtnInstituicao.FlatAppearance.BorderSize = 0;
            BtnInstituicao.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BtnInstituicao.FlatStyle = FlatStyle.Flat;
            BtnInstituicao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInstituicao.ForeColor = Color.White;
            BtnInstituicao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInstituicao.Location = new Point(0, 212);
            BtnInstituicao.Margin = new Padding(4, 3, 4, 3);
            BtnInstituicao.Name = "BtnInstituicao";
            BtnInstituicao.Size = new Size(250, 46);
            BtnInstituicao.TabIndex = 8;
            BtnInstituicao.Text = "Instituições";
            BtnInstituicao.UseVisualStyleBackColor = true;
            BtnInstituicao.Click += button1_Click;
            // 
            // BtnProjetos
            // 
            BtnProjetos.FlatAppearance.BorderSize = 0;
            BtnProjetos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BtnProjetos.FlatStyle = FlatStyle.Flat;
            BtnProjetos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProjetos.ForeColor = Color.White;
            BtnProjetos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProjetos.Location = new Point(0, 168);
            BtnProjetos.Margin = new Padding(4, 3, 4, 3);
            BtnProjetos.Name = "BtnProjetos";
            BtnProjetos.Size = new Size(250, 46);
            BtnProjetos.TabIndex = 7;
            BtnProjetos.Text = "Projetos";
            BtnProjetos.UseVisualStyleBackColor = true;
            BtnProjetos.Click += BtnProjetos_Click;
            // 
            // BtnResultados
            // 
            BtnResultados.FlatAppearance.BorderSize = 0;
            BtnResultados.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BtnResultados.FlatStyle = FlatStyle.Flat;
            BtnResultados.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnResultados.ForeColor = Color.White;
            BtnResultados.ImageAlign = ContentAlignment.MiddleLeft;
            BtnResultados.Location = new Point(0, 116);
            BtnResultados.Margin = new Padding(4, 3, 4, 3);
            BtnResultados.Name = "BtnResultados";
            BtnResultados.Size = new Size(250, 46);
            BtnResultados.TabIndex = 6;
            BtnResultados.Text = "Resultados";
            BtnResultados.UseVisualStyleBackColor = true;
            BtnResultados.Click += BtnResultados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 31);
            label1.TabIndex = 5;
            label1.Text = "UNIVERSIDADE";
            // 
            // BtnPesquisadores
            // 
            BtnPesquisadores.FlatAppearance.BorderSize = 0;
            BtnPesquisadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BtnPesquisadores.FlatStyle = FlatStyle.Flat;
            BtnPesquisadores.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisadores.ForeColor = Color.White;
            BtnPesquisadores.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPesquisadores.Location = new Point(0, 64);
            BtnPesquisadores.Margin = new Padding(4, 3, 4, 3);
            BtnPesquisadores.Name = "BtnPesquisadores";
            BtnPesquisadores.Size = new Size(250, 46);
            BtnPesquisadores.TabIndex = 2;
            BtnPesquisadores.Text = "Pesquisadores";
            BtnPesquisadores.UseVisualStyleBackColor = true;
            BtnPesquisadores.Click += BtnPesquisadores_Click;
            // 
            // Painel
            // 
            Painel.BackColor = SystemColors.Control;
            Painel.Dock = DockStyle.Fill;
            Painel.Location = new Point(250, 0);
            Painel.Margin = new Padding(4, 3, 4, 3);
            Painel.Name = "Painel";
            Painel.Size = new Size(1054, 591);
            Painel.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 591);
            Controls.Add(Painel);
            Controls.Add(MenuVertical);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1318, 623);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel Painel;
        public Button BtnPesquisadores;
        private Label label1;
        public Button BtnProjetos;
        public Button BtnResultados;
        public Button BtnInstituicao;
    }
}