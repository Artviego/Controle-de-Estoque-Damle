using MySql.Data.MySqlClient;
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
    public partial class SaidaProd : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private Peca peca;

        public SaidaProd()
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
        private void AtualizarDataGrid()
        {
            this.peca = new Peca();
            MySqlDataReader temp = this.peca.ListarPecas();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtgSaida.DataSource = dt;
        }

        private void SaidaProd_Load(object sender, EventArgs e)
        {
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
                dtgSaida.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os campos devem ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Registra a saída da peça
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand verificar = new MySqlCommand("SELECT quantidade_atual, quantidade_min FROM peca WHERE id_peca = @id", conexao))
                {
                    verificar.Parameters.AddWithValue("@id", txtID.Text);
                    using (MySqlDataReader reader = verificar.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int quantidadeAtual = reader.GetInt32("quantidade_atual");
                            int quantidadeMinima = reader.GetInt32("quantidade_min");
                            int quantidadeSaida = Convert.ToInt32(txtQuantidadeSaida.Text);

                            if (quantidadeSaida > quantidadeAtual)
                            {
                                MessageBox.Show("Erro: Não há estoque suficiente para essa saída!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            int novaQuantidade = quantidadeAtual - quantidadeSaida;

                            reader.Close(); // Fecha o reader antes de executar o UPDATE

                            using (MySqlCommand command = new MySqlCommand("UPDATE peca SET quantidade_atual = @novaQuantidade WHERE id_peca = @id", conexao))
                            {
                                command.Parameters.AddWithValue("@id", txtID.Text);
                                command.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Saída de estoque registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (novaQuantidade <= quantidadeMinima)
                                {
                                    MessageBox.Show("Aviso: A quantidade da peça atingiu ou está abaixo do mínimo permitido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (novaQuantidade <= (quantidadeMinima + 5)) // Aviso antecipado
                                {
                                    MessageBox.Show("Aviso: A quantidade da peça está próxima da quantidade mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma peça encontrada com este ID!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar saída de estoque: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }

        private void lbAtual_Click(object sender, EventArgs e)
        {

        }
    }
}
