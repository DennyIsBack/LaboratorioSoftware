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
            this.Salvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DataInicial = new System.Windows.Forms.DateTimePicker();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoverPesquisador = new System.Windows.Forms.Button();
            this.IdPesquisador = new System.Windows.Forms.TextBox();
            this.IdPesquisadorLabel = new System.Windows.Forms.Label();
            this.IncluirPesquisador = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Visualizar = new System.Windows.Forms.Button();
            this.Descricao_Arquivo = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.IdResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(608, 542);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(180, 40);
            this.Salvar.TabIndex = 18;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DataInicial);
            this.groupBox1.Controls.Add(this.Titulo);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 134);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // DataFinal
            // 
            this.DataFinal.CustomFormat = " ";
            this.DataFinal.Enabled = false;
            this.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFinal.Location = new System.Drawing.Point(345, 89);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(122, 27);
            this.DataFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Final:";
            // 
            // DataInicial
            // 
            this.DataInicial.CustomFormat = " ";
            this.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicial.Location = new System.Drawing.Point(117, 89);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(122, 27);
            this.DataInicial.TabIndex = 3;
            this.DataInicial.ValueChanged += new System.EventHandler(this.DataInicial_ValueChanged);
            this.DataInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataInicial_KeyDown);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(117, 55);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(653, 27);
            this.Titulo.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(117, 20);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(64, 27);
            this.Id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoverPesquisador);
            this.groupBox2.Controls.Add(this.IdPesquisador);
            this.groupBox2.Controls.Add(this.IdPesquisadorLabel);
            this.groupBox2.Controls.Add(this.IncluirPesquisador);
            this.groupBox2.Controls.Add(this.ListView);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 246);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisadores";
            // 
            // RemoverPesquisador
            // 
            this.RemoverPesquisador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoverPesquisador.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoverPesquisador.FlatAppearance.BorderSize = 0;
            this.RemoverPesquisador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RemoverPesquisador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverPesquisador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoverPesquisador.ForeColor = System.Drawing.Color.White;
            this.RemoverPesquisador.Location = new System.Drawing.Point(646, 55);
            this.RemoverPesquisador.Name = "RemoverPesquisador";
            this.RemoverPesquisador.Size = new System.Drawing.Size(124, 33);
            this.RemoverPesquisador.TabIndex = 23;
            this.RemoverPesquisador.Text = "REMOVER";
            this.RemoverPesquisador.UseVisualStyleBackColor = false;
            this.RemoverPesquisador.Click += new System.EventHandler(this.RemoverPesquisador_Click);
            // 
            // IdPesquisador
            // 
            this.IdPesquisador.Location = new System.Drawing.Point(43, 22);
            this.IdPesquisador.Name = "IdPesquisador";
            this.IdPesquisador.Size = new System.Drawing.Size(64, 27);
            this.IdPesquisador.TabIndex = 22;
            // 
            // IdPesquisadorLabel
            // 
            this.IdPesquisadorLabel.AutoSize = true;
            this.IdPesquisadorLabel.Location = new System.Drawing.Point(6, 25);
            this.IdPesquisadorLabel.Name = "IdPesquisadorLabel";
            this.IdPesquisadorLabel.Size = new System.Drawing.Size(31, 21);
            this.IdPesquisadorLabel.TabIndex = 21;
            this.IdPesquisadorLabel.Text = "ID:";
            // 
            // IncluirPesquisador
            // 
            this.IncluirPesquisador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirPesquisador.BackColor = System.Drawing.Color.MidnightBlue;
            this.IncluirPesquisador.FlatAppearance.BorderSize = 0;
            this.IncluirPesquisador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IncluirPesquisador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirPesquisador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncluirPesquisador.ForeColor = System.Drawing.Color.White;
            this.IncluirPesquisador.Location = new System.Drawing.Point(646, 16);
            this.IncluirPesquisador.Name = "IncluirPesquisador";
            this.IncluirPesquisador.Size = new System.Drawing.Size(124, 33);
            this.IncluirPesquisador.TabIndex = 19;
            this.IncluirPesquisador.Text = "INCLUIR";
            this.IncluirPesquisador.UseVisualStyleBackColor = false;
            this.IncluirPesquisador.Click += new System.EventHandler(this.IncluirPesquisador_Click);
            // 
            // ListView
            // 
            this.ListView.FullRowSelect = true;
            this.ListView.Location = new System.Drawing.Point(6, 55);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(634, 177);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Visualizar);
            this.groupBox3.Controls.Add(this.Descricao_Arquivo);
            this.groupBox3.Controls.Add(this.Descricao);
            this.groupBox3.Controls.Add(this.IdResultado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 130);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Visualizar.FlatAppearance.BorderSize = 0;
            this.Visualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Visualizar.ForeColor = System.Drawing.Color.White;
            this.Visualizar.Location = new System.Drawing.Point(450, 87);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(126, 30);
            this.Visualizar.TabIndex = 25;
            this.Visualizar.Text = "VISUALIZAR";
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // Descricao_Arquivo
            // 
            this.Descricao_Arquivo.Enabled = false;
            this.Descricao_Arquivo.Location = new System.Drawing.Point(103, 88);
            this.Descricao_Arquivo.Name = "Descricao_Arquivo";
            this.Descricao_Arquivo.Size = new System.Drawing.Size(340, 27);
            this.Descricao_Arquivo.TabIndex = 24;
            // 
            // Descricao
            // 
            this.Descricao.Enabled = false;
            this.Descricao.Location = new System.Drawing.Point(103, 53);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(667, 27);
            this.Descricao.TabIndex = 22;
            // 
            // IdResultado
            // 
            this.IdResultado.Location = new System.Drawing.Point(103, 20);
            this.IdResultado.Name = "IdResultado";
            this.IdResultado.Size = new System.Drawing.Size(64, 27);
            this.IdResultado.TabIndex = 20;
            this.IdResultado.Leave += new System.EventHandler(this.IdResultado_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Arquivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID:";
            // 
            // ProjetoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 250);
            this.Name = "ProjetoManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.ProjetoManutencao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private DateTimePicker DataFinal;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView ListView;
        private Button IncluirPesquisador;
        private Button Visualizar;
        private TextBox Descricao_Arquivo;
        private TextBox Descricao;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label IdPesquisadorLabel;
        private Button RemoverPesquisador;
        private TextBox IdResultado;
        private TextBox IdPesquisador;
    }
}