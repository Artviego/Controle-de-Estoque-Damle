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
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridEstoque
            // 
            dtGridEstoque.AllowUserToAddRows = false;
            dtGridEstoque.AllowUserToDeleteRows = false;
            dtGridEstoque.AllowUserToOrderColumns = true;
            dtGridEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridEstoque.BackgroundColor = SystemColors.ButtonFace;
            dtGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridEstoque.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridEstoque.Location = new Point(53, 192);
            dtGridEstoque.Name = "dtGridEstoque";
            dtGridEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridEstoque.Size = new Size(789, 203);
            dtGridEstoque.TabIndex = 0;
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
            label1.ForeColor = SystemColors.MenuText;
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
            btnFiltro.ForeColor = SystemColors.ActiveCaptionText;
            btnFiltro.Location = new Point(83, 112);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(82, 23);
            btnFiltro.TabIndex = 0;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 16);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 20;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(53, 115);
            label3.Name = "label3";
            label3.Size = new Size(319, 65);
            label3.TabIndex = 21;
            label3.Text = "Estoque Atual";
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(911, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dtGridEstoque);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridEstoque;
        private GroupBox groupBox1;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
        private Button btnFiltro;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}