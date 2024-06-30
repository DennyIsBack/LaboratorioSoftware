namespace Trabalho2.Interfaces
{
    partial class ResultadoManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoManutencao));
            Salvar = new Button();
            groupBox1 = new GroupBox();
            cmbProjeto = new ComboBox();
            EscolherArquivo = new Button();
            txbArquivo = new TextBox();
            Id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Visualizar = new Button();
            panelVisualizacao = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Salvar
            // 
            Salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Salvar.BackColor = Color.MidnightBlue;
            Salvar.FlatAppearance.BorderSize = 0;
            Salvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Salvar.FlatStyle = FlatStyle.Flat;
            Salvar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Salvar.ForeColor = Color.White;
            Salvar.Location = new Point(608, 156);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(180, 40);
            Salvar.TabIndex = 16;
            Salvar.Text = "SALVAR";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbProjeto);
            groupBox1.Controls.Add(EscolherArquivo);
            groupBox1.Controls.Add(txbArquivo);
            groupBox1.Controls.Add(Id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 138);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // cmbProjeto
            // 
            cmbProjeto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjeto.FormattingEnabled = true;
            cmbProjeto.Location = new Point(103, 53);
            cmbProjeto.Name = "cmbProjeto";
            cmbProjeto.Size = new Size(667, 29);
            cmbProjeto.TabIndex = 18;
            // 
            // EscolherArquivo
            // 
            EscolherArquivo.BackColor = Color.MidnightBlue;
            EscolherArquivo.FlatAppearance.BorderSize = 0;
            EscolherArquivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            EscolherArquivo.FlatStyle = FlatStyle.Flat;
            EscolherArquivo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EscolherArquivo.ForeColor = Color.White;
            EscolherArquivo.Location = new Point(581, 87);
            EscolherArquivo.Name = "EscolherArquivo";
            EscolherArquivo.Size = new Size(189, 30);
            EscolherArquivo.TabIndex = 17;
            EscolherArquivo.Text = "ESCOLHER ARQUIVO";
            EscolherArquivo.UseVisualStyleBackColor = false;
            EscolherArquivo.Click += EscolherArquivo_Click;
            // 
            // txbArquivo
            // 
            txbArquivo.Enabled = false;
            txbArquivo.Location = new Point(103, 88);
            txbArquivo.Name = "txbArquivo";
            txbArquivo.Size = new Size(472, 27);
            txbArquivo.TabIndex = 3;
            // 
            // Id
            // 
            Id.Enabled = false;
            Id.Location = new Point(103, 20);
            Id.Name = "Id";
            Id.Size = new Size(64, 27);
            Id.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 56);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Projeto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Arquivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // Visualizar
            // 
            Visualizar.BackColor = Color.MidnightBlue;
            Visualizar.FlatAppearance.BorderSize = 0;
            Visualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Visualizar.FlatStyle = FlatStyle.Flat;
            Visualizar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Visualizar.ForeColor = Color.White;
            Visualizar.Location = new Point(423, 156);
            Visualizar.Name = "Visualizar";
            Visualizar.Size = new Size(179, 40);
            Visualizar.TabIndex = 18;
            Visualizar.Text = "VISUALIZAR ARQUIVO";
            Visualizar.UseVisualStyleBackColor = false;
            Visualizar.Visible = false;
            Visualizar.Click += Visualizar_Click;
            // 
            // panelVisualizacao
            // 
            panelVisualizacao.Location = new Point(12, 154);
            panelVisualizacao.Name = "panelVisualizacao";
            panelVisualizacao.Size = new Size(392, 82);
            panelVisualizacao.TabIndex = 19;
            // 
            // ResultadoManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 208);
            Controls.Add(panelVisualizacao);
            Controls.Add(Visualizar);
            Controls.Add(Salvar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(816, 247);
            Name = "ResultadoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            Load += ResultadoManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Salvar;
        private GroupBox groupBox1;
        public TextBox Id;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EscolherArquivo;
        private TextBox txbArquivo;
        private Button Visualizar;
        private ComboBox cmbProjeto;
        private Panel panelVisualizacao;
    }
}