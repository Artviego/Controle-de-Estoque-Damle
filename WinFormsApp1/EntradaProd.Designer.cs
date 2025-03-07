namespace WinFormsApp1
{
    partial class EntradaProd
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
            dtgEntrada = new DataGridView();
            groupBox1 = new GroupBox();
            txtQuantidadeMin = new TextBox();
            label2 = new Label();
            txtQuantidadeMax = new TextBox();
            label1 = new Label();
            lbAtual = new Label();
            txtQuantidadeAtual = new TextBox();
            lbQuantidade = new Label();
            txtID = new TextBox();
            lbID = new Label();
            btnAlterar = new Button();
            btnCadastrarQuantidade = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEntrada).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPesquisa);
            groupBox2.Controls.Add(txtFiltro);
            groupBox2.Controls.Add(cboFiltro);
            groupBox2.Controls.Add(btnFiltro);
            groupBox2.Location = new Point(12, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 67);
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
            // dtgEntrada
            // 
            dtgEntrada.BackgroundColor = SystemColors.ButtonFace;
            dtgEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEntrada.Location = new Point(238, 143);
            dtgEntrada.Name = "dtgEntrada";
            dtgEntrada.Size = new Size(669, 245);
            dtgEntrada.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQuantidadeMin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtQuantidadeMax);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbAtual);
            groupBox1.Controls.Add(txtQuantidadeAtual);
            groupBox1.Controls.Add(lbQuantidade);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lbID);
            groupBox1.Location = new Point(12, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 254);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // txtQuantidadeMin
            // 
            txtQuantidadeMin.Location = new Point(78, 198);
            txtQuantidadeMin.Name = "txtQuantidadeMin";
            txtQuantidadeMin.Size = new Size(58, 23);
            txtQuantidadeMin.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 180);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 24;
            label2.Text = "Mínima";
            // 
            // txtQuantidadeMax
            // 
            txtQuantidadeMax.Location = new Point(139, 139);
            txtQuantidadeMax.Name = "txtQuantidadeMax";
            txtQuantidadeMax.Size = new Size(58, 23);
            txtQuantidadeMax.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 121);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 22;
            label1.Text = "Máxima";
            // 
            // lbAtual
            // 
            lbAtual.AutoSize = true;
            lbAtual.Location = new Point(20, 121);
            lbAtual.Name = "lbAtual";
            lbAtual.Size = new Size(35, 15);
            lbAtual.TabIndex = 21;
            lbAtual.Text = "Atual";
            // 
            // txtQuantidadeAtual
            // 
            txtQuantidadeAtual.Location = new Point(20, 139);
            txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            txtQuantidadeAtual.Size = new Size(58, 23);
            txtQuantidadeAtual.TabIndex = 20;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(20, 95);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 19;
            lbQuantidade.Text = "Quantidade";
            // 
            // txtID
            // 
            txtID.Location = new Point(20, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(87, 23);
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
            btnAlterar.Location = new Point(141, 394);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(91, 26);
            btnAlterar.TabIndex = 25;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCadastrarQuantidade
            // 
            btnCadastrarQuantidade.BackColor = Color.Gainsboro;
            btnCadastrarQuantidade.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrarQuantidade.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnCadastrarQuantidade.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCadastrarQuantidade.FlatStyle = FlatStyle.Flat;
            btnCadastrarQuantidade.Location = new Point(12, 394);
            btnCadastrarQuantidade.Name = "btnCadastrarQuantidade";
            btnCadastrarQuantidade.Size = new Size(91, 26);
            btnCadastrarQuantidade.TabIndex = 26;
            btnCadastrarQuantidade.Text = "Cadastrar";
            btnCadastrarQuantidade.UseVisualStyleBackColor = false;
            btnCadastrarQuantidade.Click += btnCadastrarQuantidade_Click;
            // 
            // EntradaProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(911, 450);
            Controls.Add(btnCadastrarQuantidade);
            Controls.Add(btnAlterar);
            Controls.Add(groupBox1);
            Controls.Add(dtgEntrada);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntradaProd";
            Text = "EntradaProd";
            Load += EntradaProd_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEntrada).EndInit();
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
        private DataGridView dtgEntrada;
        private GroupBox groupBox1;
        private TextBox txtID;
        private Label lbID;
        private TextBox txtQuantidadeMin;
        private Label label2;
        private TextBox txtQuantidadeMax;
        private Label label1;
        private Label lbAtual;
        private TextBox txtQuantidadeAtual;
        private Label lbQuantidade;
        private Button btnAlterar;
        private Button btnCadastrarQuantidade;
    }
}