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
            ListView = new ListView();
            groupBox1 = new GroupBox();
            cmbArea = new ComboBox();
            label3 = new Label();
            txbNome = new TextBox();
            label2 = new Label();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(1024, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(20, 20);
            BtnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnFechar.TabIndex = 1;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
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
            Detalhes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Detalhes.ForeColor = Color.White;
            Detalhes.Image = (Image)resources.GetObject("Detalhes.Image");
            Detalhes.ImageAlign = ContentAlignment.MiddleLeft;
            Detalhes.Location = new Point(858, 257);
            Detalhes.Name = "Detalhes";
            Detalhes.Size = new Size(180, 40);
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
            Novo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Novo.ForeColor = Color.White;
            Novo.Image = (Image)resources.GetObject("Novo.Image");
            Novo.ImageAlign = ContentAlignment.MiddleLeft;
            Novo.Location = new Point(858, 119);
            Novo.Name = "Novo";
            Novo.Size = new Size(180, 40);
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
            Editar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.White;
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Editar.Location = new Point(858, 165);
            Editar.Name = "Editar";
            Editar.Size = new Size(180, 40);
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
            Excluir.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Excluir.ForeColor = Color.White;
            Excluir.Image = (Image)resources.GetObject("Excluir.Image");
            Excluir.ImageAlign = ContentAlignment.MiddleLeft;
            Excluir.Location = new Point(858, 211);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(180, 40);
            Excluir.TabIndex = 17;
            Excluir.Text = "EXCLUIR";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
            // 
            // ListView
            // 
            ListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListView.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListView.FullRowSelect = true;
            ListView.Location = new Point(12, 119);
            ListView.Name = "ListView";
            ListView.Size = new Size(836, 469);
            ListView.TabIndex = 16;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.DoubleClick += DoubleClick_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbArea);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 64);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(481, 24);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(347, 29);
            cmbArea.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 29);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Área:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(74, 26);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(347, 27);
            txbNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 29);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.MidnightBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(858, 59);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(54, 54);
            btnPesquisar.TabIndex = 22;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += Pesquisar_Click;
            // 
            // Pesquisadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 600);
            Controls.Add(btnPesquisar);
            Controls.Add(groupBox1);
            Controls.Add(Detalhes);
            Controls.Add(Novo);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(ListView);
            Controls.Add(label1);
            Controls.Add(BtnFechar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1050, 600);
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
        private ListView ListView;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txbNome;
        private Label label2;
        private Button btnPesquisar;
        private ComboBox cmbArea;
    }
}