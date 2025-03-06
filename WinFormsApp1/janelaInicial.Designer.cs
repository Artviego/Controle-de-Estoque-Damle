namespace WinFormsApp1
{
    partial class janelaInicial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janelaInicial));
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelTop = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSaida = new Button();
            imageList1 = new ImageList(components);
            btnEstoque = new Button();
            btnEntrada = new Button();
            btnProdutos = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            mainPanel = new Panel();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightGray;
            panelTop.BorderStyle = BorderStyle.Fixed3D;
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(btnSaida);
            panelTop.Controls.Add(btnEstoque);
            panelTop.Controls.Add(btnEntrada);
            panelTop.Controls.Add(btnProdutos);
            panelTop.Location = new Point(-5, -3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(218, 507);
            panelTop.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 88);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnSaida
            // 
            btnSaida.BackColor = Color.Silver;
            btnSaida.FlatAppearance.BorderColor = Color.Black;
            btnSaida.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnSaida.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSaida.FlatStyle = FlatStyle.Flat;
            btnSaida.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaida.ForeColor = SystemColors.InactiveCaptionText;
            btnSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaida.ImageKey = "caixa-de-saida.png";
            btnSaida.ImageList = imageList1;
            btnSaida.Location = new Point(35, 382);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(147, 65);
            btnSaida.TabIndex = 4;
            btnSaida.Text = "Saída de estoque";
            btnSaida.TextAlign = ContentAlignment.MiddleRight;
            btnSaida.UseVisualStyleBackColor = false;
            btnSaida.Click += btnSaida_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "caixa-de-papelao-fechada.png");
            imageList1.Images.SetKeyName(1, "caixa-de-saida.png");
            imageList1.Images.SetKeyName(2, "caixa-de-entrada.png");
            imageList1.Images.SetKeyName(3, "abra-a-caixa-de-papelao.png");
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.Silver;
            btnEstoque.FlatAppearance.BorderColor = Color.Black;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = SystemColors.InactiveCaptionText;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.ImageKey = "caixa-de-papelao-fechada.png";
            btnEstoque.ImageList = imageList1;
            btnEstoque.Location = new Point(35, 124);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(90, 45);
            btnEstoque.TabIndex = 1;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleRight;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = Color.Silver;
            btnEntrada.FlatAppearance.BorderColor = Color.Black;
            btnEntrada.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEntrada.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrada.ForeColor = SystemColors.InactiveCaptionText;
            btnEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrada.ImageKey = "caixa-de-entrada.png";
            btnEntrada.ImageList = imageList1;
            btnEntrada.Location = new Point(35, 283);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(159, 64);
            btnEntrada.TabIndex = 3;
            btnEntrada.Text = "Entrada de estoque";
            btnEntrada.TextAlign = ContentAlignment.MiddleRight;
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.Silver;
            btnProdutos.FlatAppearance.BorderColor = Color.Black;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = SystemColors.InactiveCaptionText;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageKey = "abra-a-caixa-de-papelao.png";
            btnProdutos.ImageList = imageList1;
            btnProdutos.Location = new Point(35, 205);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(101, 48);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleRight;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkRed;
            btnSair.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnSair.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.InfoText;
            btnSair.Location = new Point(1102, -3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(38, 22);
            btnSair.TabIndex = 15;
            btnSair.Text = " X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 19);
            panel2.TabIndex = 16;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ButtonFace;
            mainPanel.Location = new Point(219, 25);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(921, 450);
            mainPanel.TabIndex = 17;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // janelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 480);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "janelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "janelaInicial";
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelTop;
        private ImageList imageList1;
        private Button btnEstoque;
        private Button btnSaida;
        private Button btnEntrada;
        private Button btnProdutos;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSair;
        private Panel panel2;
        private Panel mainPanel;
    }
}