namespace WinFormsApp1
{
    partial class Produtos
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
            dtgProdutos = new DataGridView();
            groupBox1 = new GroupBox();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtCategoria = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            lbModelo = new Label();
            lbAno = new Label();
            lbCategoria = new Label();
            lbNome = new Label();
            lbID = new Label();
            btnCadastrar = new Button();
            btnEx = new Button();
            groupBox2 = new GroupBox();
            lbPesquisa = new Label();
            txtFiltro = new TextBox();
            cboFiltro = new ComboBox();
            btnFiltro = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.BackgroundColor = SystemColors.ButtonFace;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgProdutos.Location = new Point(311, 95);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(588, 295);
            dtgProdutos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtAno);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lbModelo);
            groupBox1.Controls.Add(lbAno);
            groupBox1.Controls.Add(lbCategoria);
            groupBox1.Controls.Add(lbNome);
            groupBox1.Controls.Add(lbID);
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 238);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(165, 44);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(103, 23);
            txtModelo.TabIndex = 12;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(165, 168);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(70, 23);
            txtAno.TabIndex = 11;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(36, 168);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(103, 23);
            txtCategoria.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(199, 23);
            txtNome.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(87, 23);
            txtID.TabIndex = 2;
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Location = new Point(165, 26);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(48, 15);
            lbModelo.TabIndex = 6;
            lbModelo.Text = "Modelo";
            // 
            // lbAno
            // 
            lbAno.AutoSize = true;
            lbAno.Location = new Point(165, 150);
            lbAno.Name = "lbAno";
            lbAno.Size = new Size(29, 15);
            lbAno.TabIndex = 5;
            lbAno.Text = "Ano";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(36, 150);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 4;
            lbCategoria.Text = "Categoria";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(36, 86);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(36, 26);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 2;
            lbID.Text = "ID";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gainsboro;
            btnCadastrar.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(165, 364);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(91, 26);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnSalvar_Click;
            // 
            // btnEx
            // 
            btnEx.BackColor = Color.Gainsboro;
            btnEx.FlatAppearance.BorderColor = Color.Silver;
            btnEx.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnEx.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEx.FlatStyle = FlatStyle.Flat;
            btnEx.Location = new Point(397, 29);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(91, 26);
            btnEx.TabIndex = 20;
            btnEx.Text = "Excluir";
            btnEx.UseVisualStyleBackColor = false;
            btnEx.Click += btnEx_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPesquisa);
            groupBox2.Controls.Add(btnEx);
            groupBox2.Controls.Add(txtFiltro);
            groupBox2.Controls.Add(cboFiltro);
            groupBox2.Controls.Add(btnFiltro);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 67);
            groupBox2.TabIndex = 21;
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
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Gainsboro;
            btnAlterar.FlatAppearance.BorderColor = Color.Silver;
            btnAlterar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnAlterar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Location = new Point(48, 364);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(91, 26);
            btnAlterar.TabIndex = 22;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += button1_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(911, 441);
            Controls.Add(btnAlterar);
            Controls.Add(groupBox2);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(dtgProdutos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Produtos";
            Text = "Produtos";
            Load += Produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgProdutos;
        private GroupBox groupBox1;
        private Label lbNome;
        private Label lbID;
        private Label lbModelo;
        private Label lbAno;
        private Label lbCategoria;
        private TextBox txtAno;
        private TextBox txtCategoria;
        private TextBox txtNome;
        private TextBox txtID;
        private ComboBox cboQuantidade;
        private TextBox txtModelo;
        private Button btnCadastrar;
        private Button btnEx;
        private GroupBox groupBox2;
        private Label lbPesquisa;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
        private Button btnFiltro;
        private Button btnAlterar;
    }
}