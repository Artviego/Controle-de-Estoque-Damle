using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private MySqlConnection Conexao;
        Thread t1;

        public Login()
        {
            InitializeComponent();
            Conexao = new MySqlConnection("server=localhost;username=root;password=;database=sistema_gestao_pecas");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            // Não permite dados vazios
            if (string.IsNullOrEmpty(txtIdLogin.Text) ||
                string.IsNullOrEmpty(txtEmailLogin.Text) ||
                string.IsNullOrEmpty(txtSenhaLogin.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            try
            {
                Conexao.Open();
                // Verifica se o usuário já possui uma conta no database
                string query = "SELECT COUNT(*) FROM usuario WHERE email = @email AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.AddWithValue("@id_usuario", txtIdLogin.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    this.Close();
                    t1 = new Thread(abrirJanela);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                    Conexao.Close(); // Garante que a conexão será fechada após a execução
            }
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new janelaInicial());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
