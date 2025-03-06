using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Estoque : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private Peca peca;

        public Estoque()
        {
            InitializeComponent();
            Conectar();
        }

        public void Conectar()
        {
            conexao = new MySqlConnection("server=localhost;username=root;password=;database=sistema_gestao_pecas");
            this.command = this.conexao.CreateCommand();
            this.conexao.Open();
        }

        public void NonQuery(string sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }

        public MySqlDataReader Query(string sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            this.peca = new Peca();
            MySqlDataReader temp = this.peca.ListarPecas();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridEstoque.DataSource = dt;
        }

        private void dtGridEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text;
                string campo = cboFiltro.Text;
                if (campo == "ID")
                {
                    campo = "ID_peca";
                }
                MySqlDataReader temp = this.peca.ListarPecas(campo, filtro);
                DataTable dt = new DataTable();
                dt.Load(temp);
                dtGridEstoque.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os campos devem ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
