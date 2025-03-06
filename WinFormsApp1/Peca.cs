using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    //id_peca ; nome ; categoria ; ano_de_fabricacao ; modelo 
    //quantidade_atual ; quantidade_max ; quantidade_min
    
    class Peca
    {
        private string id_peca;
        private string nome;
        private string categoria;
        private string ano_de_fabricacao;
        private string modelo;
        private string quantidade_atual;
        private string quantidade_max;
        private string quantidade_min;
        private Estoque estoque;
        private Produtos produto;
        
        public Peca()
        {
            this.estoque = new Estoque();
        }

        public MySqlDataReader ListarPecas()
        {
            return this.estoque.Query("SELECT * FROM peca ORDER BY nome ASC");
        }

        public MySqlDataReader ListarPecas(string campo, string filtro)
        {
            if (filtro == "")
            {
                return ListarPecas();
            }
            return this.estoque.Query("SELECT * FROM peca WHERE "+ campo + " = '"+ filtro + "' ORDER BY nome ASC");
        }

        public MySqlDataReader ExcluirPecas(string campo, string filtro)
        {
            if (filtro == "")
            {
                return ListarPecas();
            }
            return this.produto.Query("DELET ");
        }

        public string Id_peca { get => id_peca; set => id_peca = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Ano_de_fabricacao { get => ano_de_fabricacao; set => ano_de_fabricacao = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Quantidade_atual { get => quantidade_atual; set => quantidade_atual = value; }
        public string Quantidade_max { get => quantidade_max; set => quantidade_max = value; }
        public string Quantidade_min { get => quantidade_min; set => quantidade_min = value; }
    }
}
