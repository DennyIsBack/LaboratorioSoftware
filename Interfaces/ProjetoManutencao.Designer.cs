namespace Trabalho2.Interfaces
{
    partial class ProjetoManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjetoManutencao));
            Salvar = new Button();
            groupBox1 = new GroupBox();
            DataFinal = new DateTimePicker();
            cbxArea = new ComboBox();
            label9 = new Label();
            cbxInstituicao = new ComboBox();
            label8 = new Label();
            cbxType = new ComboBox();
            label4 = new Label();
            DataInicial = new DateTimePicker();
            Titulo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Id = new TextBox();
            groupBox2 = new GroupBox();
            txtPesquisador = new TextBox();
            label10 = new Label();
            RemoverPesquisador = new Button();
            IncluirPesquisador = new Button();
            ListView = new ListView();
            chkFinalizado = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            Salvar.Location = new Point(608, 542);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(180, 40);
            Salvar.TabIndex = 18;
            Salvar.Text = "SALVAR";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataFinal);
            groupBox1.Controls.Add(cbxArea);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbxInstituicao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbxType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DataInicial);
            groupBox1.Controls.Add(Titulo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 147);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // DataFinal
            // 
            DataFinal.Checked = false;
            DataFinal.CustomFormat = " ";
            DataFinal.Format = DateTimePickerFormat.Custom;
            DataFinal.Location = new Point(301, 92);
            DataFinal.Name = "DataFinal";
            DataFinal.Size = new Size(145, 26);
            DataFinal.TabIndex = 11;
            DataFinal.ValueChanged += DataFinal_ValueChanged;
            DataFinal.KeyDown += DataFinal_KeyDown;
            // 
            // cbxArea
            // 
            cbxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxArea.FormattingEnabled = true;
            cbxArea.Location = new Point(418, 20);
            cbxArea.Margin = new Padding(2);
            cbxArea.Name = "cbxArea";
            cbxArea.Size = new Size(343, 28);
            cbxArea.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 25);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 9;
            label9.Text = "Área do conhecimento:";
            // 
            // cbxInstituicao
            // 
            cbxInstituicao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInstituicao.FormattingEnabled = true;
            cbxInstituicao.Location = new Point(545, 89);
            cbxInstituicao.Margin = new Padding(2);
            cbxInstituicao.Name = "cbxInstituicao";
            cbxInstituicao.Size = new Size(216, 28);
            cbxInstituicao.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 95);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 7;
            label8.Text = "Instituição:";
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(62, 20);
            cbxType.Margin = new Padding(2);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(166, 28);
            cbxType.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 95);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Data Final:";
            // 
            // DataInicial
            // 
            DataInicial.CustomFormat = " ";
            DataInicial.Format = DateTimePickerFormat.Custom;
            DataInicial.Location = new Point(92, 92);
            DataInicial.Name = "DataInicial";
            DataInicial.Size = new Size(122, 26);
            DataInicial.TabIndex = 3;
            DataInicial.ValueChanged += DataInicial_ValueChanged;
            DataInicial.KeyDown += DataInicial_KeyDown;
            // 
            // Titulo
            // 
            Titulo.Location = new Point(62, 55);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(699, 26);
            Titulo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 59);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 95);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Data Inicial:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo: ";
            // 
            // Id
            // 
            Id.Enabled = false;
            Id.Location = new Point(19, 8);
            Id.Name = "Id";
            Id.Size = new Size(64, 23);
            Id.TabIndex = 1;
            Id.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPesquisador);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(RemoverPesquisador);
            groupBox2.Controls.Add(IncluirPesquisador);
            groupBox2.Controls.Add(ListView);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 246);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisadores";
            // 
            // txtPesquisador
            // 
            txtPesquisador.Location = new Point(74, 20);
            txtPesquisador.Name = "txtPesquisador";
            txtPesquisador.Size = new Size(418, 26);
            txtPesquisador.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 24);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 11;
            label10.Text = "Nome:";
            // 
            // RemoverPesquisador
            // 
            RemoverPesquisador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoverPesquisador.BackColor = Color.MidnightBlue;
            RemoverPesquisador.FlatAppearance.BorderSize = 0;
            RemoverPesquisador.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            RemoverPesquisador.FlatStyle = FlatStyle.Flat;
            RemoverPesquisador.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RemoverPesquisador.ForeColor = Color.White;
            RemoverPesquisador.Location = new Point(646, 55);
            RemoverPesquisador.Name = "RemoverPesquisador";
            RemoverPesquisador.Size = new Size(124, 33);
            RemoverPesquisador.TabIndex = 23;
            RemoverPesquisador.Text = "REMOVER";
            RemoverPesquisador.UseVisualStyleBackColor = false;
            RemoverPesquisador.Click += RemoverPesquisador_Click;
            // 
            // IncluirPesquisador
            // 
            IncluirPesquisador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IncluirPesquisador.BackColor = Color.MidnightBlue;
            IncluirPesquisador.FlatAppearance.BorderSize = 0;
            IncluirPesquisador.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            IncluirPesquisador.FlatStyle = FlatStyle.Flat;
            IncluirPesquisador.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IncluirPesquisador.ForeColor = Color.White;
            IncluirPesquisador.Location = new Point(646, 16);
            IncluirPesquisador.Name = "IncluirPesquisador";
            IncluirPesquisador.Size = new Size(124, 33);
            IncluirPesquisador.TabIndex = 19;
            IncluirPesquisador.Text = "INCLUIR";
            IncluirPesquisador.UseVisualStyleBackColor = false;
            IncluirPesquisador.Click += IncluirPesquisador_Click;
            // 
            // ListView
            // 
            ListView.FullRowSelect = true;
            ListView.Location = new Point(6, 55);
            ListView.Name = "ListView";
            ListView.Size = new Size(634, 177);
            ListView.TabIndex = 0;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // chkFinalizado
            // 
            chkFinalizado.AutoSize = true;
            chkFinalizado.Enabled = false;
            chkFinalizado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkFinalizado.Location = new Point(13, 435);
            chkFinalizado.Margin = new Padding(2);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(153, 24);
            chkFinalizado.TabIndex = 26;
            chkFinalizado.Text = "Projeto finalizado ";
            chkFinalizado.UseVisualStyleBackColor = true;
            chkFinalizado.Visible = false;
            // 
            // ProjetoManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 594);
            Controls.Add(chkFinalizado);
            Controls.Add(groupBox2);
            Controls.Add(Salvar);
            Controls.Add(groupBox1);
            Controls.Add(Id);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(814, 243);
            Name = "ProjetoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projetos";
            Load += ProjetoManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Salvar;
        private GroupBox groupBox1;
        private TextBox Titulo;
        public TextBox Id;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DataInicial;
        private Label label4;
        private GroupBox groupBox2;
        private ListView ListView;
        private Button IncluirPesquisador;
        private Button RemoverPesquisador;
        private ComboBox cbxType;
        private Label label8;
        private ComboBox cbxArea;
        private Label label9;
        private ComboBox cbxInstituicao;
        private Label label10;
        private TextBox txtPesquisador;
        private CheckBox chkFinalizado;
        private DateTimePicker DataFinal;
    }
}