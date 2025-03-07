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
    public partial class EntradaProd : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private Peca peca;

        public EntradaProd()
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
            dtgEntrada.DataSource = dt;
        }

        private void EntradaProd_Load(object sender, EventArgs e)
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
                dtgEntrada.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os campos devem ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botão de cadastro das quantidades
        private void btnCadastrarQuantidade_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("UPDATE peca SET quantidade_atual = @qtd_atual, quantidade_max = @qtd_max, quantidade_min = @qtd_min WHERE id_peca = @id", conexao))
                {
                    command.Parameters.AddWithValue("@id", txtID.Text);
                    command.Parameters.AddWithValue("@qtd_atual", txtQuantidadeAtual.Text);
                    command.Parameters.AddWithValue("@qtd_max", txtQuantidadeMax.Text);
                    command.Parameters.AddWithValue("@qtd_min", txtQuantidadeMin.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Quantidades cadastradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhuma peça encontrada com este ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar quantidades. Verifique os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }

        // Botão de alterar as quantidades
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("UPDATE peca SET quantidade_atual = IF(@qtd_atual != '', @qtd_atual, quantidade_atual), quantidade_max = IF(@qtd_max != '', @qtd_max, quantidade_max), quantidade_min = IF(@qtd_min != '', @qtd_min, quantidade_min) WHERE id_peca = @id", conexao))
                {
                    command.Parameters.AddWithValue("@id", txtID.Text);

                    // Conversão segura para números
                    command.Parameters.AddWithValue("@qtd_atual", int.TryParse(txtQuantidadeAtual.Text, out int qtdAtual) ? qtdAtual : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@qtd_max", int.TryParse(txtQuantidadeMax.Text, out int qtdMax) ? qtdMax : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@qtd_min", int.TryParse(txtQuantidadeMin.Text, out int qtdMin) ? qtdMin : (object)DBNull.Value);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Quantidades alteradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhuma peça encontrada com este ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar quantidades. Verifique os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarDataGrid();
        }
    }
}
