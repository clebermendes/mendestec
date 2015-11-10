using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Model;

namespace Varejo_Tec
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            this.CarregarGridProdutos();
        }

        public void CarregarGridProdutos()
        {
            DataTable dt = new DataTable();
            
            try
            {
                dt = GeralRN.GetProducts();
                dtgrid_produtos.DataSource = dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        private void btn_sair_produto_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Principal().Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.ProdutoConsulta().Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.ProdutoCadastrar().Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.ProdutoCadastrar().Show();
        }

        private void btn_tipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.TipoCadastrar().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Pedidos().Show();

        }
    }
}
