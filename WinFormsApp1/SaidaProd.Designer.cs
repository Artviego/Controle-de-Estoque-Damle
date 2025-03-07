namespace WinFormsApp1
{
    partial class SaidaProd
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
            groupBox2 = new GroupBox();
            lbPesquisa = new Label();
            txtFiltro = new TextBox();
            cboFiltro = new ComboBox();
            btnFiltro = new Button();
            dtgSaida = new DataGridView();
            groupBox1 = new GroupBox();
            txtQuantidadeSaida = new TextBox();
            lbQuantidade = new Label();
            txtID = new TextBox();
            lbID = new Label();
            btnAlterar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSaida).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPesquisa);
            groupBox2.Controls.Add(txtFiltro);
            groupBox2.Controls.Add(cboFiltro);
            groupBox2.Controls.Add(btnFiltro);
            groupBox2.Location = new Point(12, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 67);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // lbPesquisa
            // 
            lbPesquisa.AutoSize = true;
            lbPesquisa.Location = new Point(20, 14);
            lbPesquisa.Name = "lbPesquisa";
            lbPesquisa.Size = new Size(34, 15);
            lbPesquisa.TabIndex = 20;
            lbPesquisa.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(153, 31);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(121, 23);
            txtFiltro.TabIndex = 19;
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Items.AddRange(new object[] { "ID", "Nome", "Categoria", "Ano", "Modelo", "Quantidade Aual", "Quantidade  Máx", "Quantidade Mín" });
            cboFiltro.Location = new Point(20, 32);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(121, 23);
            cboFiltro.TabIndex = 1;
            // 
            // btnFiltro
            // 
            btnFiltro.BackColor = Color.Gainsboro;
            btnFiltro.FlatAppearance.BorderColor = Color.Silver;
            btnFiltro.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnFiltro.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnFiltro.FlatStyle = FlatStyle.Flat;
            btnFiltro.Location = new Point(299, 30);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(82, 23);
            btnFiltro.TabIndex = 0;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // dtgSaida
            // 
            dtgSaida.BackgroundColor = SystemColors.ButtonFace;
            dtgSaida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSaida.Location = new Point(291, 146);
            dtgSaida.Name = "dtgSaida";
            dtgSaida.Size = new Size(608, 279);
            dtgSaida.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQuantidadeSaida);
            groupBox1.Controls.Add(lbQuantidade);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lbID);
            groupBox1.Location = new Point(21, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 89);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // txtQuantidadeSaida
            // 
            txtQuantidadeSaida.Location = new Point(113, 38);
            txtQuantidadeSaida.Name = "txtQuantidadeSaida";
            txtQuantidadeSaida.Size = new Size(121, 23);
            txtQuantidadeSaida.TabIndex = 20;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(113, 20);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 19;
            lbQuantidade.Text = "Quantidade";
            // 
            // txtID
            // 
            txtID.Location = new Point(20, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(69, 23);
            txtID.TabIndex = 3;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(20, 20);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 4;
            lbID.Text = "ID";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Gainsboro;
            btnAlterar.FlatAppearance.BorderColor = Color.Silver;
            btnAlterar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnAlterar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Location = new Point(93, 323);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 26);
            btnAlterar.TabIndex = 26;
            btnAlterar.Text = "Registrar saída";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // SaidaProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(911, 450);
            Controls.Add(btnAlterar);
            Controls.Add(groupBox1);
            Controls.Add(dtgSaida);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaidaProd";
            Text = "SaidaProd";
            Load += SaidaProd_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSaida).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label lbPesquisa;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
        private Button btnFiltro;
        private DataGridView dtgSaida;
        private GroupBox groupBox1;
        private TextBox txtQuantidadeSaida;
        private Label lbQuantidade;
        private TextBox txtID;
        private Label lbID;
        private Button btnAlterar;
    }
}