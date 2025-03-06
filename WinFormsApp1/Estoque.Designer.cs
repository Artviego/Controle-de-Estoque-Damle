namespace WinFormsApp1
{
    partial class Estoque
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
            dtGridEstoque = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtFiltro = new TextBox();
            cboFiltro = new ComboBox();
            btnFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridEstoque
            // 
            dtGridEstoque.AllowUserToAddRows = false;
            dtGridEstoque.AllowUserToDeleteRows = false;
            dtGridEstoque.AllowUserToOrderColumns = true;
            dtGridEstoque.BackgroundColor = SystemColors.ButtonFace;
            dtGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridEstoque.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridEstoque.Location = new Point(53, 192);
            dtGridEstoque.Name = "dtGridEstoque";
            dtGridEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridEstoque.Size = new Size(789, 203);
            dtGridEstoque.TabIndex = 0;
            dtGridEstoque.CellContentClick += dtGridEstoque_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(cboFiltro);
            groupBox1.Controls.Add(btnFiltro);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(642, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 141);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 13);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 20;
            label1.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(44, 71);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(121, 23);
            txtFiltro.TabIndex = 19;
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Items.AddRange(new object[] { "ID", "Nome", "Categoria", "Ano", "Modelo", "Quantidade Atual", "Quantidade Máx", "Quantidade Mín" });
            cboFiltro.Location = new Point(44, 31);
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
            btnFiltro.Location = new Point(83, 112);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(82, 23);
            btnFiltro.TabIndex = 0;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(911, 450);
            Controls.Add(groupBox1);
            Controls.Add(dtGridEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridEstoque;
        private GroupBox groupBox1;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
        private Button btnFiltro;
        private Label label1;
    }
}