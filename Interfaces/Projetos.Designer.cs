namespace Trabalho2.Interfaces
{
    partial class Projetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projetos));
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataInicialFiltro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TituloFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.PictureBox();
            this.VisualizarResultado = new System.Windows.Forms.Button();
            this.FinalizarProjeto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesquisar
            // 
            this.Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pesquisar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.ForeColor = System.Drawing.Color.White;
            this.Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("Pesquisar.Image")));
            this.Pesquisar.Location = new System.Drawing.Point(858, 59);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(54, 54);
            this.Pesquisar.TabIndex = 35;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detalhes.BackColor = System.Drawing.Color.MidnightBlue;
            this.Detalhes.FlatAppearance.BorderSize = 0;
            this.Detalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalhes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Detalhes.ForeColor = System.Drawing.Color.White;
            this.Detalhes.Image = ((System.Drawing.Image)(resources.GetObject("Detalhes.Image")));
            this.Detalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Detalhes.Location = new System.Drawing.Point(858, 257);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(180, 40);
            this.Detalhes.TabIndex = 34;
            this.Detalhes.Text = "DETALHES";
            this.Detalhes.UseVisualStyleBackColor = false;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // Novo
            // 
            this.Novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Novo.BackColor = System.Drawing.Color.MidnightBlue;
            this.Novo.FlatAppearance.BorderSize = 0;
            this.Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Novo.ForeColor = System.Drawing.Color.White;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Novo.Location = new System.Drawing.Point(858, 119);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(180, 40);
            this.Novo.TabIndex = 33;
            this.Novo.Text = "NOVO";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Editar.FlatAppearance.BorderSize = 0;
            this.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.Location = new System.Drawing.Point(858, 165);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(180, 40);
            this.Editar.TabIndex = 32;
            this.Editar.Text = "EDITAR";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.BackColor = System.Drawing.Color.MidnightBlue;
            this.Excluir.FlatAppearance.BorderSize = 0;
            this.Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Excluir.ForeColor = System.Drawing.Color.White;
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Excluir.Location = new System.Drawing.Point(858, 211);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(180, 40);
            this.Excluir.TabIndex = 31;
            this.Excluir.Text = "EXCLUIR";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DataInicialFiltro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TituloFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 64);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // DataInicialFiltro
            // 
            this.DataInicialFiltro.CustomFormat = " ";
            this.DataInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicialFiltro.Location = new System.Drawing.Point(708, 26);
            this.DataInicialFiltro.Name = "DataInicialFiltro";
            this.DataInicialFiltro.Size = new System.Drawing.Size(122, 27);
            this.DataInicialFiltro.TabIndex = 36;
            this.DataInicialFiltro.ValueChanged += new System.EventHandler(this.DataInicialFiltro_ValueChanged);
            this.DataInicialFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataInicialFiltro_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Inicial:";
            // 
            // TituloFiltro
            // 
            this.TituloFiltro.Location = new System.Drawing.Point(68, 26);
            this.TituloFiltro.Name = "TituloFiltro";
            this.TituloFiltro.Size = new System.Drawing.Size(524, 27);
            this.TituloFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título:";
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListView.FullRowSelect = true;
            this.ListView.Location = new System.Drawing.Point(12, 119);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(836, 469);
            this.ListView.TabIndex = 29;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.DoubleClick += new System.EventHandler(this.DoubleClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "PROJETOS";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(1024, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(20, 20);
            this.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnFechar.TabIndex = 36;
            this.BtnFechar.TabStop = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // VisualizarResultado
            // 
            this.VisualizarResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizarResultado.BackColor = System.Drawing.Color.MidnightBlue;
            this.VisualizarResultado.FlatAppearance.BorderSize = 0;
            this.VisualizarResultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.VisualizarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizarResultado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisualizarResultado.ForeColor = System.Drawing.Color.White;
            this.VisualizarResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VisualizarResultado.Location = new System.Drawing.Point(858, 389);
            this.VisualizarResultado.Name = "VisualizarResultado";
            this.VisualizarResultado.Size = new System.Drawing.Size(180, 54);
            this.VisualizarResultado.TabIndex = 37;
            this.VisualizarResultado.Text = "VISUALIZAR RESULTADO";
            this.VisualizarResultado.UseVisualStyleBackColor = false;
            this.VisualizarResultado.Click += new System.EventHandler(this.VisualizarResultado_Click);
            // 
            // FinalizarProjeto
            // 
            this.FinalizarProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalizarProjeto.BackColor = System.Drawing.Color.MidnightBlue;
            this.FinalizarProjeto.FlatAppearance.BorderSize = 0;
            this.FinalizarProjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FinalizarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalizarProjeto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinalizarProjeto.ForeColor = System.Drawing.Color.White;
            this.FinalizarProjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinalizarProjeto.Location = new System.Drawing.Point(858, 329);
            this.FinalizarProjeto.Name = "FinalizarProjeto";
            this.FinalizarProjeto.Size = new System.Drawing.Size(180, 54);
            this.FinalizarProjeto.TabIndex = 38;
            this.FinalizarProjeto.Text = "FINALIZAR PROJETO";
            this.FinalizarProjeto.UseVisualStyleBackColor = false;
            this.FinalizarProjeto.Click += new System.EventHandler(this.FinalizarProjeto_Click);
            // 
            // Projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.FinalizarProjeto);
            this.Controls.Add(this.VisualizarResultado);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projetos";
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.Projetos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Pesquisar;
        private Button Detalhes;
        private Button Novo;
        private Button Editar;
        private Button Excluir;
        private GroupBox groupBox1;
        private TextBox TituloFiltro;
        private Label label2;
        private ListView ListView;
        private Label label1;
        private Label label3;
        private DateTimePicker DataInicialFiltro;
        private PictureBox BtnFechar;
        private Button VisualizarResultado;
        private Button FinalizarProjeto;
    }
}