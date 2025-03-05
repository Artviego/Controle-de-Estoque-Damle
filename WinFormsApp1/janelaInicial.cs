using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class janelaInicial : Form
    {
        public janelaInicial()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            loadform(new Estoque());
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            loadform(new Produtos());
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            loadform(new EntradaProd());
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            loadform(new SaidaProd());
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
