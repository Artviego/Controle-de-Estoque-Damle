namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtIdLogin = new TextBox();
            label2 = new Label();
            txtEmailLogin = new TextBox();
            label3 = new Label();
            txtSenhaLogin = new TextBox();
            label4 = new Label();
            btnAdicionarUsuario = new Button();
            panel1 = new Panel();
            btnSair = new Button();
            pictureBox4 = new PictureBox();
            btVerSenha = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btVerSenha).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(98, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // txtIdLogin
            // 
            txtIdLogin.BackColor = Color.LightGray;
            txtIdLogin.Location = new Point(68, 115);
            txtIdLogin.Name = "txtIdLogin";
            txtIdLogin.Size = new Size(133, 23);
            txtIdLogin.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 97);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 9;
            label2.Text = "ID";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = Color.LightGray;
            txtEmailLogin.Location = new Point(68, 178);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(133, 23);
            txtEmailLogin.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 160);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "E-mail";
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.LightGray;
            txtSenhaLogin.Location = new Point(68, 245);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(133, 23);
            txtSenhaLogin.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 227);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Senha";
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.BackColor = SystemColors.Highlight;
            btnAdicionarUsuario.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnAdicionarUsuario.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnAdicionarUsuario.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnAdicionarUsuario.FlatStyle = FlatStyle.Flat;
            btnAdicionarUsuario.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarUsuario.ForeColor = SystemColors.Window;
            btnAdicionarUsuario.Location = new Point(92, 296);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(83, 33);
            btnAdicionarUsuario.TabIndex = 18;
            btnAdicionarUsuario.Text = "Entrar";
            btnAdicionarUsuario.UseVisualStyleBackColor = false;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(-6, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 92);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.Black;
            btnSair.Location = new Point(232, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(27, 22);
            btnSair.TabIndex = 20;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(92, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // btVerSenha
            // 
            btVerSenha.Cursor = Cursors.Hand;
            btVerSenha.Image = Properties.Resources.invisivel;
            btVerSenha.Location = new Point(207, 245);
            btVerSenha.Name = "btVerSenha";
            btVerSenha.Size = new Size(21, 23);
            btVerSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            btVerSenha.TabIndex = 20;
            btVerSenha.TabStop = false;
            btVerSenha.MouseDown += btVerSenha_MouseDown;
            btVerSenha.MouseUp += btVerSenha_MouseUp;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 21);
            panel2.TabIndex = 21;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 341);
            Controls.Add(btVerSenha);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(txtSenhaLogin);
            Controls.Add(label4);
            Controls.Add(txtEmailLogin);
            Controls.Add(label3);
            Controls.Add(txtIdLogin);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btVerSenha).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdLogin;
        private Label label2;
        private TextBox txtEmailLogin;
        private Label label3;
        private TextBox txtSenhaLogin;
        private Label label4;
        private Button btnAdicionarUsuario;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Button btnSair;
        private PictureBox btVerSenha;
        private Panel panel2;
    }
}