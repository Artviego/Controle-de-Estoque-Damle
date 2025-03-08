using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private Peca peca;

        public Produtos()
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

        private void Produtos_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            this.peca = new Peca();
            MySqlDataReader temp = this.peca.ListarPecas();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtgProdutos.DataSource = dt;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                command = new MySqlCommand("INSERT INTO peca (id_peca, nome, categoria, ano_de_fabricacao, modelo) VALUES ('" + txtID.Text + "', '" + txtNome.Text + "', '" + txtCategoria.Text + "', '" + txtAno.Text + "', '" + txtModelo.Text +"')", conexao);
                command.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos inválidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }


        // Atualiza a peça
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("UPDATE peca SET nome = IF(@nome != '', @nome, nome), categoria = IF(@categoria != '', @categoria, categoria), ano_de_fabricacao = IF(@ano != '', @ano, ano_de_fabricacao), " +
                                                               "modelo = IF(@modelo != '', @modelo, modelo) " +
                                                               "WHERE id_peca = @id", conexao))
                {
                    command.Parameters.AddWithValue("@id", txtID.Text);
                    command.Parameters.AddWithValue("@nome", string.IsNullOrWhiteSpace(txtNome.Text) ? (object)DBNull.Value : txtNome.Text);
                    command.Parameters.AddWithValue("@categoria", string.IsNullOrWhiteSpace(txtCategoria.Text) ? (object)DBNull.Value : txtCategoria.Text);
                    command.Parameters.AddWithValue("@ano", string.IsNullOrWhiteSpace(txtAno.Text) ? (object)DBNull.Value : txtAno.Text);
                    command.Parameters.AddWithValue("@modelo", string.IsNullOrWhiteSpace(txtModelo.Text) ? (object)DBNull.Value : txtModelo.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Peça atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhuma peça encontrada com este ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar. Verifique os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }

        // Exclui a peça com base no ID inserido pelo usuário
        private void btnEx_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("DELETE FROM peca WHERE id_peca = @id", conexao))
                {
                    command.Parameters.AddWithValue("@id", txtFiltro.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Peça excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhuma peça encontrada com este ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Verifique o ID!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text;
                string campo = cboFiltro.Text;
                if (campo == "ID")
                {
                    campo = "id_peca";
                }
                MySqlDataReader temp = this.peca.ListarPecas(campo, filtro);
                DataTable dt = new DataTable();
                dt.Load(temp);
                dtgProdutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os campos devem ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
