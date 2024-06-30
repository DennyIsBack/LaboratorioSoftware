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
            rdbAluno = new RadioButton();
            rdbProfessor = new RadioButton();
            cmbArea = new ComboBox();
            txbEmail = new TextBox();
            txbLattes = new TextBox();
            Lattes = new Label();
            txbInstituicao = new TextBox();
            Instituicao = new Label();
            Email = new Label();
            txbNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(rdbAluno);
            groupBox1.Controls.Add(rdbProfessor);
            groupBox1.Controls.Add(cmbArea);
            groupBox1.Controls.Add(txbEmail);
            groupBox1.Controls.Add(txbLattes);
            groupBox1.Controls.Add(Lattes);
            groupBox1.Controls.Add(txbInstituicao);
            groupBox1.Controls.Add(Instituicao);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rdbAluno
            // 
            rdbAluno.AutoSize = true;
            rdbAluno.Location = new Point(197, 182);
            rdbAluno.Name = "rdbAluno";
            rdbAluno.Size = new Size(68, 24);
            rdbAluno.TabIndex = 13;
            rdbAluno.TabStop = true;
            rdbAluno.Text = "Aluno";
            rdbAluno.UseVisualStyleBackColor = true;
            // 
            // rdbProfessor
            // 
            rdbProfessor.AutoSize = true;
            rdbProfessor.Location = new Point(96, 182);
            rdbProfessor.Name = "rdbProfessor";
            rdbProfessor.Size = new Size(95, 24);
            rdbProfessor.TabIndex = 12;
            rdbProfessor.TabStop = true;
            rdbProfessor.Text = "Professor";
            rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(96, 49);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(393, 28);
            cmbArea.TabIndex = 11;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(96, 85);
            txbEmail.Margin = new Padding(2);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(393, 26);
            txbEmail.TabIndex = 10;
            // 
            // txbLattes
            // 
            txbLattes.Location = new Point(96, 151);
            txbLattes.Margin = new Padding(2);
            txbLattes.Name = "txbLattes";
            txbLattes.Size = new Size(393, 26);
            txbLattes.TabIndex = 9;
            // 
            // Lattes
            // 
            Lattes.AutoSize = true;
            Lattes.Location = new Point(8, 155);
            Lattes.Margin = new Padding(2, 0, 2, 0);
            Lattes.Name = "Lattes";
            Lattes.Size = new Size(58, 20);
            Lattes.TabIndex = 8;
            Lattes.Text = "Lattes:";
            // 
            // txbInstituicao
            // 
            txbInstituicao.Location = new Point(96, 118);
            txbInstituicao.Margin = new Padding(2);
            txbInstituicao.Name = "txbInstituicao";
            txbInstituicao.Size = new Size(393, 26);
            txbInstituicao.TabIndex = 7;
            // 
            // Instituicao
            // 
            Instituicao.AutoSize = true;
            Instituicao.Location = new Point(8, 122);
            Instituicao.Margin = new Padding(2, 0, 2, 0);
            Instituicao.Name = "Instituicao";
            Instituicao.Size = new Size(86, 20);
            Instituicao.TabIndex = 6;
            Instituicao.Text = "Instituição:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(8, 89);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(52, 20);
            Email.TabIndex = 4;
            Email.Text = "Email:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(96, 17);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(393, 26);
            txbNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 20);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Área:";
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
            btnSalvar.Location = new Point(335, 234);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 40);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += Salvar_Click;
            // 
            // PesquisadorManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(526, 283);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(536, 239);
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
        private TextBox txbNome;
        private Label label3;
        private Label label2;
        private Button btnSalvar;
        private Label Email;
        private TextBox txtEmail;
        private Label Instituicao;
        private TextBox txbLattes;
        private Label Lattes;
        private TextBox txbInstituicao;
        private RadioButton rdbAluno;
        private RadioButton rdbProfessor;
        private ComboBox cmbArea;
        private TextBox txbEmail;
    }
}