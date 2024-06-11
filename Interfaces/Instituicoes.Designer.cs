namespace Trabalho2.Interfaces
{
    partial class Instituicoes
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
            ColumnHeader IdColumn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instituicoes));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnPesquisar = new Button();
            txbNome = new TextBox();
            label2 = new Label();
            BtnFechar = new PictureBox();
            Detalhes = new Button();
            Novo = new Button();
            Editar = new Button();
            Excluir = new Button();
            ListView = new ListView();
            NomeColumn = new ColumnHeader();
            SiglaColumn = new ColumnHeader();
            IdColumn = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            SuspendLayout();
            // 
            // IdColumn
            // 
            IdColumn.DisplayIndex = 2;
            IdColumn.Text = "Id";
            IdColumn.Width = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(495, 40);
            label1.TabIndex = 16;
            label1.Text = "INSTITUIÇÕES DE ENSINO";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 104);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1198, 107);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.MidnightBlue;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(1010, 44);
            btnPesquisar.Margin = new Padding(4, 5, 4, 5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(58, 35);
            btnPesquisar.TabIndex = 26;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txbNome
            // 
            txbNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNome.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txbNome.Location = new Point(110, 44);
            txbNome.Margin = new Padding(4, 5, 4, 5);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(902, 35);
            txbNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 0;
            label2.Text = "Nome :";
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(1439, 14);
            BtnFechar.Margin = new Padding(4, 5, 4, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(29, 33);
            BtnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnFechar.TabIndex = 23;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
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
            Detalhes.Location = new Point(1219, 349);
            Detalhes.Margin = new Padding(4, 5, 4, 5);
            Detalhes.Name = "Detalhes";
            Detalhes.Size = new Size(257, 67);
            Detalhes.TabIndex = 28;
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
            Novo.Location = new Point(1219, 119);
            Novo.Margin = new Padding(4, 5, 4, 5);
            Novo.Name = "Novo";
            Novo.Size = new Size(257, 67);
            Novo.TabIndex = 27;
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
            Editar.Location = new Point(1219, 196);
            Editar.Margin = new Padding(4, 5, 4, 5);
            Editar.Name = "Editar";
            Editar.Size = new Size(257, 67);
            Editar.TabIndex = 26;
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
            Excluir.Location = new Point(1219, 273);
            Excluir.Margin = new Padding(4, 5, 4, 5);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(257, 67);
            Excluir.TabIndex = 25;
            Excluir.Text = "EXCLUIR";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
            // 
            // ListView
            // 
            ListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListView.Columns.AddRange(new ColumnHeader[] { IdColumn, NomeColumn, SiglaColumn });
            ListView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListView.FullRowSelect = true;
            ListView.Location = new Point(13, 221);
            ListView.Margin = new Padding(4, 5, 4, 5);
            ListView.MultiSelect = false;
            ListView.Name = "ListView";
            ListView.Size = new Size(1193, 621);
            ListView.TabIndex = 24;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // NomeColumn
            // 
            NomeColumn.DisplayIndex = 0;
            NomeColumn.Text = "Nome";
            NomeColumn.Width = 800;
            // 
            // SiglaColumn
            // 
            SiglaColumn.DisplayIndex = 1;
            SiglaColumn.Text = "Sigla";
            SiglaColumn.Width = 389;
            // 
            // Instituicoes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 904);
            Controls.Add(Detalhes);
            Controls.Add(Novo);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(ListView);
            Controls.Add(BtnFechar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Instituicoes";
            Text = "Instituicao";
            Load += Instituicao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txbNome;
        private Label label2;
        private PictureBox BtnFechar;
        private Button btnPesquisar;
        private Button Detalhes;
        private Button Novo;
        private Button Editar;
        private Button Excluir;
        private ListView ListView;
        private ColumnHeader NomeColumn;
        private ColumnHeader SiglaColumn;
    }
}