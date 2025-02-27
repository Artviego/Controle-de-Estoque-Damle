using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Thread t1;
        private MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
            Conexao = new MySqlConnection("server=localhost;username=root;password=;database=sistema_gestao_pecas");
            CarregarDadosPeca();
            CarregarDadosUsuario();
        }

        private void CarregarDadosPeca()
        {
            try
            {
                Conexao.Open();
                string query = "SELECT * FROM peca";
                MySqlDataAdapter dataA = new MySqlDataAdapter(query, Conexao);
                DataTable dataT = new DataTable();
                dataA.Fill(dataT);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void CarregarDadosUsuario()
        {
            try
            {
                string query = "SELECT * FROM usuario";
                MySqlDataAdapter dataA = new MySqlDataAdapter(query, Conexao);
                DataTable dataT = new DataTable();
                dataA.Fill(dataT);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            try
            {
                // Criar conexão com o MySQL
                Conexao.Open();
                string query = "INSERT INTO usuário (id_usuario, email, senha) " +
                               "VALUES (@id_usuario, @email, @senha)";

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                // Adiciona os dados do ID do usuário
                cmd.Parameters.AddWithValue("@id_usuario", txtID.Text);

                // Adiciona os dados do email do usuário
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                // Adiciona a senha do usuário
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                // Salva os dados do cadastro do usuário
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado!");
                CarregarDadosUsuario();

                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close(); // Garante que a conexão será fechada após a execução
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Login());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}