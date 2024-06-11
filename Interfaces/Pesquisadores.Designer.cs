namespace Trabalho2.Interfaces
{
    partial class Pesquisadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisadores));
            BtnFechar = new PictureBox();
            label1 = new Label();
            Detalhes = new Button();
            Novo = new Button();
            Editar = new Button();
            Excluir = new Button();
            lvPesquisadores = new ListView();
            groupBox1 = new GroupBox();
            btnPesquisar = new Button();
            cmbArea = new ComboBox();
            label3 = new Label();
            txbNome = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            BtnFechar.TabIndex = 1;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 15;
            label1.Text = "PESQUISADORES";
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
            Detalhes.TabIndex = 20;
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
            Novo.TabIndex = 19;
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
            Editar.TabIndex = 18;
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
            Excluir.TabIndex = 17;
            Excluir.Text = "EXCLUIR";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
            // 
            // lvPesquisadores
            // 
            lvPesquisadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvPesquisadores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvPesquisadores.FullRowSelect = true;
            lvPesquisadores.Location = new Point(17, 198);
            lvPesquisadores.Margin = new Padding(4, 5, 4, 5);
            lvPesquisadores.Name = "lvPesquisadores";
            lvPesquisadores.Size = new Size(1193, 779);
            lvPesquisadores.TabIndex = 16;
            lvPesquisadores.UseCompatibleStateImageBehavior = false;
            lvPesquisadores.View = View.Details;
            lvPesquisadores.SelectedIndexChanged += lvPesquisadores_SelectedIndexChanged;
            lvPesquisadores.DoubleClick += DoubleClick_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(cmbArea);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 82);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1288, 107);
            groupBox1.TabIndex = 21;
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
            btnPesquisar.Location = new Point(1180, 40);
            btnPesquisar.Margin = new Padding(4, 5, 4, 5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(55, 38);
            btnPesquisar.TabIndex = 22;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += Pesquisar_Click;
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(687, 40);
            cmbArea.Margin = new Padding(4, 5, 4, 5);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(494, 37);
            cmbArea.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 29);
            label3.TabIndex = 2;
            label3.Text = "Área:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(106, 43);
            txbNome.Margin = new Padding(4, 5, 4, 5);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(494, 35);
            txbNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // Pesquisadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1500, 1000);
            Controls.Add(groupBox1);
            Controls.Add(Detalhes);
            Controls.Add(Novo);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(lvPesquisadores);
            Controls.Add(label1);
            Controls.Add(BtnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1500, 1000);
            Name = "Pesquisadores";
            Text = "Pesquisadores";
            Load += Pesquisadores_Load;
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BtnFechar;
        private Label label1;
        private Button Detalhes;
        private Button Novo;
        private Button Editar;
        private Button Excluir;
        public ListView lvPesquisadores;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txbNome;
        private Label label2;
        private Button btnPesquisar;
        private ComboBox cmbArea;
    }
}