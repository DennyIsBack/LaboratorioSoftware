namespace Trabalho2.Interfaces
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            label1 = new Label();
            lvResultado = new ListView();
            idColumn = new ColumnHeader();
            projetoColumn = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            cmbProjeto = new ComboBox();
            Pesquisar = new Button();
            label2 = new Label();
            Detalhes = new Button();
            Novo = new Button();
            Editar = new Button();
            Excluir = new Button();
            BtnFechar = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 16;
            label1.Text = "RESULTADOS";
            // 
            // lvResultado
            // 
            lvResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvResultado.Columns.AddRange(new ColumnHeader[] { idColumn, projetoColumn });
            lvResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvResultado.FullRowSelect = true;
            lvResultado.Location = new Point(12, 119);
            lvResultado.Name = "lvResultado";
            lvResultado.Size = new Size(836, 469);
            lvResultado.TabIndex = 17;
            lvResultado.UseCompatibleStateImageBehavior = false;
            lvResultado.View = View.Details;
            lvResultado.DoubleClick += DoubleClick_Click;
            // 
            // idColumn
            // 
            idColumn.Text = "ID";
            // 
            // projetoColumn
            // 
            projetoColumn.Text = "Projeto";
            projetoColumn.Width = 1000;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(cmbProjeto);
            groupBox1.Controls.Add(Pesquisar);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 64);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.MidnightBlue;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(776, 25);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(54, 27);
            btnLimpar.TabIndex = 29;
            btnLimpar.Text = "X";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cmbProjeto
            // 
            cmbProjeto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjeto.FormattingEnabled = true;
            cmbProjeto.Location = new Point(70, 25);
            cmbProjeto.Name = "cmbProjeto";
            cmbProjeto.Size = new Size(640, 28);
            cmbProjeto.TabIndex = 28;
            // 
            // Pesquisar
            // 
            Pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pesquisar.BackColor = Color.MidnightBlue;
            Pesquisar.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            Pesquisar.FlatStyle = FlatStyle.Flat;
            Pesquisar.ForeColor = Color.White;
            Pesquisar.Image = (Image)resources.GetObject("Pesquisar.Image");
            Pesquisar.Location = new Point(716, 25);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(54, 27);
            Pesquisar.TabIndex = 27;
            Pesquisar.UseVisualStyleBackColor = false;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Projeto:";
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
            Detalhes.Location = new Point(861, 216);
            Detalhes.Name = "Detalhes";
            Detalhes.Size = new Size(180, 40);
            Detalhes.TabIndex = 26;
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
            Novo.Location = new Point(861, 78);
            Novo.Name = "Novo";
            Novo.Size = new Size(180, 40);
            Novo.TabIndex = 25;
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
            Editar.Location = new Point(861, 124);
            Editar.Name = "Editar";
            Editar.Size = new Size(180, 40);
            Editar.TabIndex = 24;
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
            Excluir.Location = new Point(861, 170);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(180, 40);
            Excluir.TabIndex = 23;
            Excluir.Text = "EXCLUIR";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
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
            BtnFechar.TabIndex = 28;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 600);
            Controls.Add(BtnFechar);
            Controls.Add(Detalhes);
            Controls.Add(Novo);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(groupBox1);
            Controls.Add(lvResultado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Resultados";
            Text = "Resultados";
            Load += Resultados_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvResultado;
        private GroupBox groupBox1;
        private Label label2;
        private Button Pesquisar;
        private Button Detalhes;
        private Button Novo;
        private Button Editar;
        private Button Excluir;
        private PictureBox BtnFechar;
        private ColumnHeader idColumn;
        private ColumnHeader projetoColumn;
        private ComboBox cmbProjeto;
        private Button btnLimpar;
    }
}