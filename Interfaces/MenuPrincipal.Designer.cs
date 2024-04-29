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
            MenuVertical.Controls.Add(BtnProjetos);
            MenuVertical.Controls.Add(BtnResultados);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(BtnPesquisadores);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(6, 5, 6, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(357, 985);
            MenuVertical.TabIndex = 0;
            // 
            // BtnProjetos
            // 
            BtnProjetos.FlatAppearance.BorderSize = 0;
            BtnProjetos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BtnProjetos.FlatStyle = FlatStyle.Flat;
            BtnProjetos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProjetos.ForeColor = Color.White;
            BtnProjetos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProjetos.Location = new Point(0, 280);
            BtnProjetos.Margin = new Padding(6, 5, 6, 5);
            BtnProjetos.Name = "BtnProjetos";
            BtnProjetos.Size = new Size(357, 77);
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
            BtnResultados.Location = new Point(0, 193);
            BtnResultados.Margin = new Padding(6, 5, 6, 5);
            BtnResultados.Name = "BtnResultados";
            BtnResultados.Size = new Size(357, 77);
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
            label1.Location = new Point(8, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 47);
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
            BtnPesquisadores.Location = new Point(0, 107);
            BtnPesquisadores.Margin = new Padding(6, 5, 6, 5);
            BtnPesquisadores.Name = "BtnPesquisadores";
            BtnPesquisadores.Size = new Size(357, 77);
            BtnPesquisadores.TabIndex = 2;
            BtnPesquisadores.Text = "Pesquisadores";
            BtnPesquisadores.UseVisualStyleBackColor = true;
            BtnPesquisadores.Click += BtnPesquisadores_Click;
            // 
            // Painel
            // 
            Painel.BackColor = Color.WhiteSmoke;
            Painel.Dock = DockStyle.Fill;
            Painel.Location = new Point(357, 0);
            Painel.Margin = new Padding(6, 5, 6, 5);
            Painel.Name = "Painel";
            Painel.Size = new Size(1506, 985);
            Painel.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1863, 985);
            Controls.Add(Painel);
            Controls.Add(MenuVertical);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MinimumSize = new Size(1876, 1013);
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
    }
}