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
            Pesquisar = new Button();
            Detalhes = new Button();
            Novo = new Button();
            Editar = new Button();
            Excluir = new Button();
            groupBox1 = new GroupBox();
            DataInicialFiltro = new DateTimePicker();
            label3 = new Label();
            TituloFiltro = new TextBox();
            label2 = new Label();
            ListView = new ListView();
            label1 = new Label();
            BtnFechar = new PictureBox();
            VisualizarResultado = new Button();
            FinalizarProjeto = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            SuspendLayout();
            // 
            // Pesquisar
            // 
            Pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pesquisar.BackColor = Color.MidnightBlue;
            Pesquisar.FlatAppearance.MouseDownBackColor = Color.Navy;
            Pesquisar.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            Pesquisar.FlatStyle = FlatStyle.Flat;
            Pesquisar.ForeColor = Color.White;
            Pesquisar.Image = (Image)resources.GetObject("Pesquisar.Image");
            Pesquisar.Location = new Point(1183, 43);
            Pesquisar.Margin = new Padding(4, 5, 4, 5);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(63, 35);
            Pesquisar.TabIndex = 35;
            Pesquisar.UseVisualStyleBackColor = false;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // Detalhes
            // 
            Detalhes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Detalhes.BackColor = Color.MidnightBlue;
            Detalhes.FlatAppearance.BorderSize = 0;
            Detalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Detalhes.FlatStyle = FlatStyle.Flat;
            Detalhes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Detalhes.ForeColor = Color.White;
            Detalhes.Image = (Image)resources.GetObject("Detalhes.Image");
            Detalhes.ImageAlign = ContentAlignment.MiddleLeft;
            Detalhes.Location = new Point(1226, 428);
            Detalhes.Margin = new Padding(4, 5, 4, 5);
            Detalhes.Name = "Detalhes";
            Detalhes.Size = new Size(257, 67);
            Detalhes.TabIndex = 34;
            Detalhes.Text = "DETALHES";
            Detalhes.UseVisualStyleBackColor = false;
            Detalhes.Click += Detalhes_Click;
            // 
            // Novo
            // 
            Novo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Novo.BackColor = Color.MidnightBlue;
            Novo.FlatAppearance.BorderSize = 0;
            Novo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Novo.FlatStyle = FlatStyle.Flat;
            Novo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Novo.ForeColor = Color.White;
            Novo.Image = (Image)resources.GetObject("Novo.Image");
            Novo.ImageAlign = ContentAlignment.MiddleLeft;
            Novo.Location = new Point(1226, 198);
            Novo.Margin = new Padding(4, 5, 4, 5);
            Novo.Name = "Novo";
            Novo.Size = new Size(257, 67);
            Novo.TabIndex = 33;
            Novo.Text = "NOVO";
            Novo.UseVisualStyleBackColor = false;
            Novo.Click += Novo_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Editar.BackColor = Color.MidnightBlue;
            Editar.FlatAppearance.BorderSize = 0;
            Editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.White;
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Editar.Location = new Point(1226, 275);
            Editar.Margin = new Padding(4, 5, 4, 5);
            Editar.Name = "Editar";
            Editar.Size = new Size(257, 67);
            Editar.TabIndex = 32;
            Editar.Text = "EDITAR";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // Excluir
            // 
            Excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Excluir.BackColor = Color.MidnightBlue;
            Excluir.FlatAppearance.BorderSize = 0;
            Excluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Excluir.ForeColor = Color.White;
            Excluir.Image = (Image)resources.GetObject("Excluir.Image");
            Excluir.ImageAlign = ContentAlignment.MiddleLeft;
            Excluir.Location = new Point(1226, 352);
            Excluir.Margin = new Padding(4, 5, 4, 5);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(257, 67);
            Excluir.TabIndex = 31;
            Excluir.Text = "EXCLUIR";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(DataInicialFiltro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TituloFiltro);
            groupBox1.Controls.Add(Pesquisar);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 82);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1290, 107);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // DataInicialFiltro
            // 
            DataInicialFiltro.CustomFormat = " ";
            DataInicialFiltro.Format = DateTimePickerFormat.Custom;
            DataInicialFiltro.Location = new Point(1011, 43);
            DataInicialFiltro.Margin = new Padding(4, 5, 4, 5);
            DataInicialFiltro.Name = "DataInicialFiltro";
            DataInicialFiltro.Size = new Size(173, 35);
            DataInicialFiltro.TabIndex = 36;
            DataInicialFiltro.ValueChanged += DataInicialFiltro_ValueChanged;
            DataInicialFiltro.KeyDown += DataInicialFiltro_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(854, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 2;
            label3.Text = "Data Inicial:";
            // 
            // TituloFiltro
            // 
            TituloFiltro.Location = new Point(97, 43);
            TituloFiltro.Margin = new Padding(4, 5, 4, 5);
            TituloFiltro.Name = "TituloFiltro";
            TituloFiltro.Size = new Size(747, 35);
            TituloFiltro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 0;
            label2.Text = "Título:";
            // 
            // ListView
            // 
            ListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListView.FullRowSelect = true;
            ListView.Location = new Point(17, 198);
            ListView.Margin = new Padding(4, 5, 4, 5);
            ListView.Name = "ListView";
            ListView.Size = new Size(1193, 779);
            ListView.TabIndex = 29;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.DoubleClick += DoubleClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 28;
            label1.Text = "PROJETOS";
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(1463, 8);
            BtnFechar.Margin = new Padding(4, 5, 4, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(29, 33);
            BtnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnFechar.TabIndex = 36;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // VisualizarResultado
            // 
            VisualizarResultado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VisualizarResultado.BackColor = Color.MidnightBlue;
            VisualizarResultado.FlatAppearance.BorderSize = 0;
            VisualizarResultado.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            VisualizarResultado.FlatStyle = FlatStyle.Flat;
            VisualizarResultado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            VisualizarResultado.ForeColor = Color.White;
            VisualizarResultado.ImageAlign = ContentAlignment.MiddleLeft;
            VisualizarResultado.Location = new Point(1226, 648);
            VisualizarResultado.Margin = new Padding(4, 5, 4, 5);
            VisualizarResultado.Name = "VisualizarResultado";
            VisualizarResultado.Size = new Size(257, 90);
            VisualizarResultado.TabIndex = 37;
            VisualizarResultado.Text = "VISUALIZAR RESULTADO";
            VisualizarResultado.UseVisualStyleBackColor = false;
            VisualizarResultado.Click += VisualizarResultado_Click;
            // 
            // FinalizarProjeto
            // 
            FinalizarProjeto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FinalizarProjeto.BackColor = Color.MidnightBlue;
            FinalizarProjeto.FlatAppearance.BorderSize = 0;
            FinalizarProjeto.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            FinalizarProjeto.FlatStyle = FlatStyle.Flat;
            FinalizarProjeto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FinalizarProjeto.ForeColor = Color.White;
            FinalizarProjeto.ImageAlign = ContentAlignment.MiddleLeft;
            FinalizarProjeto.Location = new Point(1226, 548);
            FinalizarProjeto.Margin = new Padding(4, 5, 4, 5);
            FinalizarProjeto.Name = "FinalizarProjeto";
            FinalizarProjeto.Size = new Size(257, 90);
            FinalizarProjeto.TabIndex = 38;
            FinalizarProjeto.Text = "FINALIZAR PROJETO";
            FinalizarProjeto.UseVisualStyleBackColor = false;
            FinalizarProjeto.Click += FinalizarProjeto_Click;
            // 
            // Projetos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1500, 1000);
            Controls.Add(FinalizarProjeto);
            Controls.Add(VisualizarResultado);
            Controls.Add(BtnFechar);
            Controls.Add(Detalhes);
            Controls.Add(Novo);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(groupBox1);
            Controls.Add(ListView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Projetos";
            Text = "Projetos";
            Load += Projetos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
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