using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Business;

namespace Varejo_Tec
{
    public partial class VendaCadastrar : Form
    {
        DataTable produtos = new DataTable();
        int count = 0;
        double total = 0;
        public VendaCadastrar()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            PreencherAutoCompleteTextBox();
            PreencherPedido();
            this.chklist.SetItemChecked(0, true);
        }

        private void PreencherPedido()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastBarCodePedido();
            this.lbl_pedido.Text = (codigo + 1).ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(CheckGaps().Equals(true))
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto = GeralRN.GetProductByCodeWithoutImage(this.txt_codigo.Text);
                int qtde = Convert.ToInt32(this.txt_quant.Text);

                if ((CheckProductIntoGrid(produto.codigo).Equals(-1)))
                {
                    if (produto.qtde >= qtde)
                    {
                        this.dtgrid_venda.Rows.Add();
                        this.dtgrid_venda.Rows[count].Cells["code"].Value = produto.codigo.ToString();
                        this.dtgrid_venda.Rows[count].Cells["quatde"].Value = this.txt_quant.Text;
                        this.dtgrid_venda.Rows[count].Cells["descri"].Value = produto.descricao.ToString();
                        this.dtgrid_venda.Rows[count].Cells["precoo"].Value = ("R$ ") + produto.precoFinal.ToString();
                        this.dtgrid_venda.Rows[count].Cells["totall"].Value = ("R$ ") + (produto.precoFinal * qtde).ToString();
                        this.lbl_total.Text = ("R$ ") + (total += (produto.precoFinal * qtde)).ToString();
                        count++;
                    }
                    else
                        MessageBox.Show("Quantidade do produto não confere com o estoque! ESTOQUE: " + produto.qtde);
                }
                else
                    MessageBox.Show("O produto já foi adicionado à venda!");

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
                    this.lbl_total.Text.Replace("R$ ", "");
                    total -= Convert.ToDouble(this.dtgrid_venda.Rows[i].Cells["totall"].Value.ToString().Replace("R$ ", ""));
                    this.lbl_total.Text = "R$ " + (total).ToString();
                    this.dtgrid_venda.Rows.RemoveAt(i);
                    count--;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Historico().Show();
        }

        private void chklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chklist.Items.Count; ++ix)
                if (ix != e.Index) chklist.SetItemChecked(ix, false);
        }

        private void PreencherAutoCompleteTextBox()
        {
            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            produto = GeralRN.GetAllProductsCode();

            AutoCompleteStringCollection dados = new AutoCompleteStringCollection();
            
            for(int i=0; i < produto.Count; i++)
            {
                dados.Add(produto[i].codBarras.ToString());
            }

            this.txt_codigo.AutoCompleteCustomSource = dados;
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            VendasDTO venda = new VendasDTO();
            VendaProdutoDTO vendaProduto = new VendaProdutoDTO();
            int contador = 0;

            venda.tipoPagamento = chklist.SelectedIndex;
            venda.total = total;

            if(GeralRN.InsertSelling(venda))
            {
                while (contador < this.dtgrid_venda.Rows.Count)
                {
                    vendaProduto.codigo_venda = this.lbl_pedido.Text;
                    vendaProduto.codigo_produto = this.dtgrid_venda.Rows[contador].Cells["code"].Value.ToString();
                    vendaProduto.quantidade_ites = Convert.ToInt32(this.dtgrid_venda.Rows[contador].Cells["quatde"].Value);
                    vendaProduto.total = Convert.ToDouble(this.dtgrid_venda.Rows[contador].Cells["totall"].Value.ToString().Replace("R$ ", ""));

                    GeralRN.InsertingProductInSelling(vendaProduto);
                    GeralRN.UpdatingProductQuantify(vendaProduto.codigo_produto, vendaProduto.quantidade_ites);
                    contador++;
                }
                if(GeralRN.GeneratePdf(this.lbl_pedido.Text, this.chklist.SelectedIndex))
                {
                    RecreateSelling();
                }
                
            }
        }

        private int CheckProductIntoGrid(string codigo)
        {
            int rowindex = -1;
            int contador = 0;
            while (contador < this.dtgrid_venda.Rows.Count - 1)
            {
                if (this.dtgrid_venda.Rows[contador].Cells["code"].Value.ToString().Equals(codigo))
                {
                    rowindex = contador;
                    break;
                }
                contador++;
            }
            return rowindex;
        }

        private void RecreateSelling()
        {
            const string message = "Deseja fazer outra venda?";
            const string caption = "Fazer venda";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CleanPage();
            }
            else
            {
                this.Hide();
                new Varejo_Tec.Historico().Show();
            }
                

        }

        private void CleanPage()
        {
            PreencherPedido();
            this.txt_codigo.Clear();
            this.txt_quant.Clear();
            total = 0;
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

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                if (string.IsNullOrWhiteSpace(this.txt_quant.Text))
                {
                    this.txt_quant.Text = "1";
                    btn_add_Click(sender, e);
                }
                else
                    btn_add_Click(sender, e);
            }
        }
    }
}
