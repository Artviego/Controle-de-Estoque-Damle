namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnAdicionarUsuario = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            btnSair = new Button();
            btVerSenha = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btVerSenha).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(371, 95);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(371, 157);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(371, 218);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.BackColor = Color.LightGray;
            txtID.Location = new Point(371, 113);
            txtID.Name = "txtID";
            txtID.Size = new Size(137, 23);
            txtID.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BackColor = Color.LightGray;
            txtSenha.Location = new Point(371, 236);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(137, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.LightGray;
            txtEmail.Location = new Point(371, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Anchor = AnchorStyles.None;
            btnAdicionarUsuario.BackColor = SystemColors.Highlight;
            btnAdicionarUsuario.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnAdicionarUsuario.FlatAppearance.BorderSize = 2;
            btnAdicionarUsuario.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnAdicionarUsuario.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnAdicionarUsuario.FlatStyle = FlatStyle.Flat;
            btnAdicionarUsuario.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarUsuario.ForeColor = SystemColors.Window;
            btnAdicionarUsuario.Location = new Point(403, 299);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(79, 26);
            btnAdicionarUsuario.TabIndex = 6;
            btnAdicionarUsuario.Text = "Salvar";
            btnAdicionarUsuario.UseVisualStyleBackColor = false;
            btnAdicionarUsuario.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 432);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 25);
            panel2.TabIndex = 22;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(155, 390);
            label9.Name = "label9";
            label9.Size = new Size(106, 14);
            label9.TabIndex = 7;
            label9.Text = "Damle Coding GP";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(167, 376);
            label8.Name = "label8";
            label8.Size = new Size(83, 14);
            label8.TabIndex = 6;
            label8.Text = "Developed By";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 15.75F);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(107, 241);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 5;
            label6.Text = "Gerenciamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 15.75F);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(147, 266);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 4;
            label7.Text = "de Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15.75F);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(147, 216);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 2;
            label5.Text = "Sistema de";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15.75F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(136, 162);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 1;
            label4.Text = "Bem-Vindo!";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(74, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(152, 138);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(371, 43);
            label10.Name = "label10";
            label10.Size = new Size(137, 29);
            label10.TabIndex = 11;
            label10.Text = "Cadastre-se";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Georgia", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(403, 385);
            button1.Name = "button1";
            button1.Size = new Size(79, 24);
            button1.TabIndex = 12;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(351, 359);
            label11.Name = "label11";
            label11.Size = new Size(193, 23);
            label11.TabIndex = 13;
            label11.Text = "Já possui uma conta?";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnSair.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.InfoText;
            btnSair.Location = new Point(553, -2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(32, 25);
            btnSair.TabIndex = 14;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btVerSenha
            // 
            btVerSenha.Cursor = Cursors.Hand;
            btVerSenha.Image = Properties.Resources.invisivel;
            btVerSenha.Location = new Point(514, 238);
            btVerSenha.Name = "btVerSenha";
            btVerSenha.Size = new Size(21, 23);
            btVerSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            btVerSenha.TabIndex = 21;
            btVerSenha.TabStop = false;
            btVerSenha.MouseDown += btVerSenha_MouseDown;
            btVerSenha.MouseUp += btVerSenha_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(585, 420);
            Controls.Add(btVerSenha);
            Controls.Add(btnSair);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btVerSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnAdicionarUsuario;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private Button btnSair;
        private PictureBox btVerSenha;
        private Panel panel2;
    }
}
