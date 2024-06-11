﻿namespace Trabalho2.Interfaces
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
            ListView = new ListView();
            groupBox1 = new GroupBox();
            DescricaoFiltro = new TextBox();
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
            label1.Location = new Point(17, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 40);
            label1.TabIndex = 16;
            label1.Text = "RESULTADOS";
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
            ListView.TabIndex = 17;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.DoubleClick += DoubleClick_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(DescricaoFiltro);
            groupBox1.Controls.Add(Pesquisar);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 82);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1193, 107);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // DescricaoFiltro
            // 
            DescricaoFiltro.Location = new Point(149, 43);
            DescricaoFiltro.Margin = new Padding(4, 5, 4, 5);
            DescricaoFiltro.Name = "DescricaoFiltro";
            DescricaoFiltro.Size = new Size(960, 35);
            DescricaoFiltro.TabIndex = 1;
            // 
            // Pesquisar
            // 
            Pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pesquisar.BackColor = Color.MidnightBlue;
            Pesquisar.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            Pesquisar.FlatStyle = FlatStyle.Flat;
            Pesquisar.ForeColor = Color.White;
            Pesquisar.Image = (Image)resources.GetObject("Pesquisar.Image");
            Pesquisar.Location = new Point(1106, 45);
            Pesquisar.Margin = new Padding(4, 5, 4, 5);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(62, 34);
            Pesquisar.TabIndex = 27;
            Pesquisar.UseVisualStyleBackColor = false;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 0;
            label2.Text = "Descrição:";
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
            Detalhes.Location = new Point(1230, 360);
            Detalhes.Margin = new Padding(4, 5, 4, 5);
            Detalhes.Name = "Detalhes";
            Detalhes.Size = new Size(257, 67);
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
            Novo.Location = new Point(1230, 130);
            Novo.Margin = new Padding(4, 5, 4, 5);
            Novo.Name = "Novo";
            Novo.Size = new Size(257, 67);
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
            Editar.Location = new Point(1230, 207);
            Editar.Margin = new Padding(4, 5, 4, 5);
            Editar.Name = "Editar";
            Editar.Size = new Size(257, 67);
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
            Excluir.Location = new Point(1230, 284);
            Excluir.Margin = new Padding(4, 5, 4, 5);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(257, 67);
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
            BtnFechar.Location = new Point(1463, 8);
            BtnFechar.Margin = new Padding(4, 5, 4, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(29, 33);
            BtnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnFechar.TabIndex = 28;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1500, 1000);
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
        private ListView ListView;
        private GroupBox groupBox1;
        private TextBox DescricaoFiltro;
        private Label label2;
        private Button Pesquisar;
        private Button Detalhes;
        private Button Novo;
        private Button Editar;
        private Button Excluir;
        private PictureBox BtnFechar;
    }
}