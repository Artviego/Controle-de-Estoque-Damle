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
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).BeginInit();
            SuspendLayout();
            // 
            // dtGridEstoque
            // 
            dtGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridEstoque.Dock = DockStyle.Fill;
            dtGridEstoque.Location = new Point(0, 0);
            dtGridEstoque.Name = "dtGridEstoque";
            dtGridEstoque.Size = new Size(800, 450);
            dtGridEstoque.TabIndex = 0;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(dtGridEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridEstoque;
    }
}