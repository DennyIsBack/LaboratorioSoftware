namespace Trabalho2.Interfaces
{
    partial class PesquisadorManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisadorManutencao));
            groupBox1 = new GroupBox();
            Nome = new TextBox();
            Area = new TextBox();
            Id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Salvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(Nome);
            groupBox1.Controls.Add(Area);
            groupBox1.Controls.Add(Id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Nome
            // 
            Nome.Location = new Point(73, 53);
            Nome.Name = "Nome";
            Nome.Size = new Size(415, 27);
            Nome.TabIndex = 2;
            // 
            // Area
            // 
            Area.Location = new Point(73, 88);
            Area.Name = "Area";
            Area.Size = new Size(415, 27);
            Area.TabIndex = 3;
            // 
            // Id
            // 
            Id.Enabled = false;
            Id.Location = new Point(73, 20);
            Id.Name = "Id";
            Id.Size = new Size(64, 27);
            Id.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Área:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
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
            Salvar.Location = new Point(331, 156);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(180, 40);
            Salvar.TabIndex = 14;
            Salvar.Text = "SALVAR";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // PesquisadorManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(522, 207);
            Controls.Add(Salvar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(538, 246);
            Name = "PesquisadorManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisadores";
            Load += PesquisadorManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox Nome;
        private TextBox Area;
        private Label label3;
        private Label label2;
        public TextBox Id;
        private Button Salvar;
    }
}