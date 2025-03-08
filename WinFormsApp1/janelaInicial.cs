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

namespace WinFormsApp1
{
    public partial class janelaInicial : Form
    {
        public janelaInicial()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocation;

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

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void janelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
