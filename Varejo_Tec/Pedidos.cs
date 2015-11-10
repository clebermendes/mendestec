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
    public partial class Pedidos : Form
    {
        DataTable produtos = new DataTable();
        int count = 0;
        int forne = 0;
        double total = 0;
        public Pedidos()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            PreencherPedido();
            PreencherComboFornecedor();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckGaps().Equals(true))
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto = GeralRN.GetProductByCodeWithoutImage(this.txt_codigo.Text);
                int qtde = Convert.ToInt32(this.txt_quant.Text);
                if (CheckFornecedorProduto(produto))
                {
                    if ((CheckProductIntoGrid(produto.codigo).Equals(-1)))
                    {
                        this.dtgrid_venda.Rows.Add();
                        this.dtgrid_venda.Rows[count].Cells["code"].Value = produto.codigo.ToString();
                        this.dtgrid_venda.Rows[count].Cells["quatde"].Value = this.txt_quant.Text;
                        this.dtgrid_venda.Rows[count].Cells["codigo"].Value = produto.code_ref.ToString();
                        this.dtgrid_venda.Rows[count].Cells["precoInicial"].Value = produto.precoInicial.ToString();
                        this.dtgrid_venda.Rows[count].Cells["precototal"].Value = (produto.precoInicial * qtde).ToString();
                        this.lbl_total.Text = ("R$ ") + (total += (produto.precoInicial * qtde)).ToString();
                        count++;
                    }
                    else
                        MessageBox.Show("O produto já foi adicionado à venda!");
                }
                else
                    MessageBox.Show("O produto não pertence ao fornecedor informado!");
            }
            else
                MessageBox.Show("Preencha os campos vazio!");
        }

        private void btn_less_Click(object sender, EventArgs e)
        {
            for (int i = this.dtgrid_venda.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)this.dtgrid_venda.Rows[i].Cells[0].FormattedValue)
                {
                    this.dtgrid_venda.Rows.RemoveAt(i);
                    count--;
                }
            }
        }

        private void PreencherAutoCompleteTextBox(string value)
        {
            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            produto = GeralRN.GetAllProductsCodeRef(value);

            AutoCompleteStringCollection dados = new AutoCompleteStringCollection();

            for (int i = 0; i < produto.Count; i++)
            {
                dados.Add(produto[i].code_ref.ToString());
            }
            this.txt_codigo.AutoCompleteCustomSource = dados;
        }

        private void PreencherPedido()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastCodePedido();
            this.lbl_pedido.Text = (codigo + 1).ToString();
        }

        private int CheckProductIntoGrid(string codigo)
        {
            int rowindex = -1;
            int contador = 0;
            while (contador < this.dtgrid_venda.Rows.Count - 1)
            {
                if (this.dtgrid_venda.Rows[contador].Cells["codigo"].Value.ToString().Equals(codigo))
                {
                    rowindex = contador;
                    break;
                }
                contador++;
            }
            return rowindex;
        }

        private bool CheckFornecedorProduto(ProdutoDTO produto)
        {
            if (GeralRN.CheckFornecedorProduto(produto.code_ref, produto.fornecedor.codigo).Equals(true))
                return true;
            else
                return false;
        }

        private void CleanPage()
        {
            PreencherPedido();
            this.txt_codigo.Clear();
            this.txt_quant.Clear();
            count = 0;
            CleanGridView();
        }

        private void CleanGridView()
        {
            this.dtgrid_venda.DataSource = null;
            this.dtgrid_venda.Rows.Clear();
            this.dtgrid_venda.Refresh();
        }

        private bool CheckGaps()
        {
            if (!(string.IsNullOrWhiteSpace(this.txt_codigo.Text)))
            {
                if (!(string.IsNullOrWhiteSpace(this.txt_quant.Text)))
                    return true;
                return false;
            }
            else
                return false;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Produto().Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            PedidoDTO pedido = new PedidoDTO();
            PedidoProdutosDTO pedidoProduto = new PedidoProdutosDTO();
            int contador = 0;

            pedido.fornecedor.codigo = Convert.ToInt32(cbx_fornecedor.SelectedValue);
            pedido.total = total;

            if (GeralRN.InsertPedido(pedido))
            {
                while (contador < this.dtgrid_venda.Rows.Count)
                {
                    pedidoProduto.codigo_pedido = this.lbl_pedido.Text;
                    pedidoProduto.codigo_produto = this.dtgrid_venda.Rows[contador].Cells["code"].Value.ToString();
                    pedidoProduto.quantidade_ites = Convert.ToInt32(this.dtgrid_venda.Rows[contador].Cells["quatde"].Value);
                    pedidoProduto.total = Convert.ToDouble(this.dtgrid_venda.Rows[contador].Cells["precototal"].Value.ToString().Replace("R$ ", ""));

                    GeralRN.InsertingProductInPedido(pedidoProduto);
                    contador++;
                }
                if (GeralRN.GeneratePdfPedido(this.lbl_pedido.Text, Convert.ToInt32(cbx_fornecedor.SelectedValue)))
                {
                    RecreatePedido();
                }

            }
        }

        private void RecreatePedido()
        {
            const string message = "Deseja fazer outro pedido?";
            const string caption = "Fazer pedido";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CleanPage();
            }
            else
            {
                this.Hide();
                new Varejo_Tec.Produto().Show();
            }
        }
        
        private void cbx_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (forne >= 1)
            {
                PreencherAutoCompleteTextBox(this.cbx_fornecedor.SelectedValue.ToString());

            }
            forne++;
        }

        private void PreencherComboFornecedor()
        {
            cbx_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_fornecedor.DataSource = GeralRN.GetAllFornecedores();
            cbx_fornecedor.ValueMember = "codigo";
            cbx_fornecedor.DisplayMember = "nomeFantasia";
            cbx_fornecedor.Update();
        }
    }
}
