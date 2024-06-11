namespace Trabalho2.Interfaces
{
    partial class InstituicaoManutencao
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
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            txbEndereco = new TextBox();
            txbSite = new TextBox();
            Site = new Label();
            txbSigla = new TextBox();
            Endereco = new Label();
            Email = new Label();
            txbNome = new TextBox();
            label3 = new Label();
            Label = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = Color.MidnightBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(420, 311);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(229, 63);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txbEndereco);
            groupBox1.Controls.Add(txbSite);
            groupBox1.Controls.Add(Site);
            groupBox1.Controls.Add(txbSigla);
            groupBox1.Controls.Add(Endereco);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(33, 46);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(616, 255);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // txbEndereco
            // 
            txbEndereco.Location = new Point(149, 93);
            txbEndereco.Name = "txbEndereco";
            txbEndereco.Size = new Size(426, 35);
            txbEndereco.TabIndex = 10;
            // 
            // txbSite
            // 
            txbSite.Location = new Point(149, 143);
            txbSite.Name = "txbSite";
            txbSite.Size = new Size(426, 35);
            txbSite.TabIndex = 9;
            // 
            // Site
            // 
            Site.AutoSize = true;
            Site.Location = new Point(24, 151);
            Site.Name = "Site";
            Site.Size = new Size(61, 29);
            Site.TabIndex = 8;
            Site.Text = "Site:";
            // 
            // txbSigla
            // 
            txbSigla.Location = new Point(149, 197);
            txbSigla.Name = "txbSigla";
            txbSigla.Size = new Size(426, 35);
            txbSigla.TabIndex = 7;
            // 
            // Endereco
            // 
            Endereco.AutoSize = true;
            Endereco.Location = new Point(24, 96);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(124, 29);
            Endereco.TabIndex = 6;
            Endereco.Text = "Endereço:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(24, 200);
            Email.Name = "Email";
            Email.Size = new Size(74, 29);
            Email.TabIndex = 4;
            Email.Text = "Sigla:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(149, 38);
            txbNome.Margin = new Padding(4, 5, 4, 5);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(426, 35);
            txbNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 29);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Label.Location = new Point(33, 9);
            Label.Margin = new Padding(4, 0, 4, 0);
            Label.Name = "Label";
            Label.Size = new Size(79, 36);
            Label.TabIndex = 11;
            Label.Text = "Label";
            // 
            // InstituicaoManutencao
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 400);
            Controls.Add(Label);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "InstituicaoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InstituicaoManutencao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private GroupBox groupBox1;
        private TextBox txbEndereco;
        private TextBox txbSite;
        private Label Site;
        private TextBox txbSigla;
        private Label Endereco;
        private Label Email;
        private TextBox txbNome;
        private Label label3;
        private Label Label;
    }
}