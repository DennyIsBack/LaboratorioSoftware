namespace Trabalho2.Interfaces
{
    partial class PesquisadorManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisadorManutencao));
            groupBox1 = new GroupBox();
            Aluno = new RadioButton();
            Professor = new RadioButton();
            txtLattes = new TextBox();
            Lattes = new Label();
            txtInstituicao = new TextBox();
            Instituicao = new Label();
            txtEmail = new TextBox();
            Email = new Label();
            Nome = new TextBox();
            Area = new TextBox();
            Id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Salvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(Aluno);
            groupBox1.Controls.Add(Professor);
            groupBox1.Controls.Add(txtLattes);
            groupBox1.Controls.Add(Lattes);
            groupBox1.Controls.Add(txtInstituicao);
            groupBox1.Controls.Add(Instituicao);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(Nome);
            groupBox1.Controls.Add(Area);
            groupBox1.Controls.Add(Id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(719, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Aluno
            // 
            Aluno.AutoSize = true;
            Aluno.Location = new Point(298, 389);
            Aluno.Name = "Aluno";
            Aluno.Size = new Size(99, 33);
            Aluno.TabIndex = 11;
            Aluno.TabStop = true;
            Aluno.Text = "Aluno";
            Aluno.UseVisualStyleBackColor = true;
            // 
            // Professor
            // 
            Professor.AutoSize = true;
            Professor.Location = new Point(135, 389);
            Professor.Name = "Professor";
            Professor.Size = new Size(142, 33);
            Professor.TabIndex = 10;
            Professor.TabStop = true;
            Professor.Text = "Professor";
            Professor.UseVisualStyleBackColor = true;
            // 
            // txtLattes
            // 
            txtLattes.Location = new Point(135, 312);
            txtLattes.Name = "txtLattes";
            txtLattes.Size = new Size(560, 35);
            txtLattes.TabIndex = 9;
            // 
            // Lattes
            // 
            Lattes.AutoSize = true;
            Lattes.Location = new Point(8, 318);
            Lattes.Name = "Lattes";
            Lattes.Size = new Size(83, 29);
            Lattes.TabIndex = 8;
            Lattes.Text = "Lattes:";
            // 
            // txtInstituicao
            // 
            txtInstituicao.Location = new Point(135, 257);
            txtInstituicao.Name = "txtInstituicao";
            txtInstituicao.Size = new Size(560, 35);
            txtInstituicao.TabIndex = 7;
            // 
            // Instituicao
            // 
            Instituicao.AutoSize = true;
            Instituicao.Location = new Point(8, 263);
            Instituicao.Name = "Instituicao";
            Instituicao.Size = new Size(126, 29);
            Instituicao.TabIndex = 6;
            Instituicao.Text = "Instituição:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(560, 35);
            txtEmail.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(9, 208);
            Email.Name = "Email";
            Email.Size = new Size(80, 29);
            Email.TabIndex = 4;
            Email.Text = "Email:";
            // 
            // Nome
            // 
            Nome.Location = new Point(135, 88);
            Nome.Margin = new Padding(4, 5, 4, 5);
            Nome.Name = "Nome";
            Nome.Size = new Size(560, 35);
            Nome.TabIndex = 2;
            // 
            // Area
            // 
            Area.Location = new Point(135, 147);
            Area.Margin = new Padding(4, 5, 4, 5);
            Area.Name = "Area";
            Area.Size = new Size(560, 35);
            Area.TabIndex = 3;
            // 
            // Id
            // 
            Id.Enabled = false;
            Id.Location = new Point(135, 33);
            Id.Margin = new Padding(4, 5, 4, 5);
            Id.Name = "Id";
            Id.Size = new Size(90, 35);
            Id.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 29);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 29);
            label2.TabIndex = 1;
            label2.Text = "Área:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 29);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // Salvar
            // 
            Salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Salvar.BackColor = Color.MidnightBlue;
            Salvar.FlatAppearance.BorderSize = 0;
            Salvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Salvar.FlatStyle = FlatStyle.Flat;
            Salvar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Salvar.ForeColor = Color.White;
            Salvar.Location = new Point(479, 479);
            Salvar.Margin = new Padding(4, 5, 4, 5);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(257, 67);
            Salvar.TabIndex = 14;
            Salvar.Text = "SALVAR";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // PesquisadorManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(752, 564);
            Controls.Add(Salvar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(759, 373);
            Name = "PesquisadorManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisadores";
            Load += PesquisadorManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox Nome;
        private TextBox Area;
        private Label label3;
        private Label label2;
        public TextBox Id;
        private Button Salvar;
        private Label Email;
        private TextBox txtEmail;
        private Label Instituicao;
        private RadioButton Professor;
        private TextBox txtLattes;
        private Label Lattes;
        private TextBox txtInstituicao;
        private RadioButton Aluno;
    }
}