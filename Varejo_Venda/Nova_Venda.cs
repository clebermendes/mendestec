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

namespace Varejo_Venda
{
    public partial class Nova_Venda : Form
    {
        DataTable produtos = new DataTable();
        int count = 0;
        double total = 0;
        double subtotal = 0;
        double descont = 0;
        public Nova_Venda()
        {
            InitializeComponent();
            PreencherComboPaga();
            PreencherPedido();
            lbl_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lbl_nome_vendedor.Text = (string)SessionRN.getInstance().get(Constantes.USUARIO_LOGADO);
        }

        private void PreencherPedido()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastBarCodePedido();
            this.lbl_codigo_venda.Text = (codigo + 1).ToString();
        }

        private void PreencherComboPaga()
        {
            cbx_forma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_forma.DataSource = GeralRN.GetPaymentWays();
            cbx_forma.ValueMember = "codigo";
            cbx_forma.DisplayMember = "descricao";
            cbx_forma.Update();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar_Item cancelar = new Cancelar_Item();

            DialogResult dr = cancelar.ShowDialog(this);

            if (dr.Equals(DialogResult.Cancel))
            {
                if (cancelar.Clicked().Equals("clicked"))
                {
                    if (!(string.IsNullOrWhiteSpace(cancelar.GetText())))
                    {
                        for (int i = this.dt_produtos.Rows.Count - 1; i >= 0; i--)
                        {
                            if(this.dt_produtos.Rows[i].Cells["ITEM"].Value.Equals(cancelar.GetText()))
                            {
                                this.dt_produtos.Rows.RemoveAt(i);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Código não especificado!");
                }
            }
            cancelar.Dispose();
        }

        private void btn_add_desc_Click(object sender, EventArgs e)
        {
            Desconto desconto = new Desconto();

            DialogResult dr = desconto.ShowDialog(this);

            if (dr.Equals(DialogResult.Cancel))
            {
                if (desconto.Clicked().Equals("clicked"))
                {
                    if (!(string.IsNullOrWhiteSpace(desconto.GetText())))
                    {
                        descont = 1 - (Convert.ToDouble(desconto.GetText()) / 100);
                    }
                    else
                        MessageBox.Show("Desconto não especificado!");
                }
            }

            desconto.Dispose();
        }

        private void AdcionarProduto()
        {
            ProdutoDTO produto = new ProdutoDTO();
            
            int qtde = 0;
            if (!(GetQuantify(txt_produto.Text).Equals(1)))
            {
                qtde = GetQuantify(txt_produto.Text);
                produto = GeralRN.GetProductByCodeWithoutImage(txt_produto.Text.Remove(0, txt_produto.Text.IndexOf('*')+1));
            }
            else
            {
                qtde = GetQuantify(txt_produto.Text);
                produto = GeralRN.GetProductByCodeWithoutImage(txt_produto.Text.Remove(0, txt_produto.Text.IndexOf('*') +1));
            }

            CheckProductIntoGrid(produto.codBarras);

            if (produto.qtde >= qtde)
            {
                this.dt_produtos.Rows.Add();
                this.dt_produtos.Rows[count].Cells["CODIGO"].Value = produto.codigo;
                this.dt_produtos.Rows[count].Cells["ITEM"].Value = produto.codBarras.ToString();
                this.dt_produtos.Rows[count].Cells["QUANT"].Value = qtde.ToString();
                this.dt_produtos.Rows[count].Cells["DESCRICAO"].Value = produto.descricao.ToString();
                this.dt_produtos.Rows[count].Cells["DESCONTO"].Value = produto.desconto.ToString();
                this.dt_produtos.Rows[count].Cells["PRECO"].Value = produto.precoFinal.ToString("0.00");
                this.dt_produtos.Rows[count].Cells["TOTALL"].Value = (produto.precoFinal * qtde).ToString("0.00");
                this.lbl_total.Text = (total += (produto.precoFinal * qtde)).ToString("0.00");
                this.lbl_total_pagar.Text = (produto.precoFinal * qtde).ToString("0.00");
                this.txt_produto.Clear();
                count++;
            }
            else
            {
                MessageBox.Show("Quantidade do produto não confere com o estoque! ESTOQUE: " + produto.qtde);
                txt_produto.Clear();
            }

        }

        private int GetQuantify(string text)
        {
            if (!(text.IndexOf('*').Equals(-1)))
            {
                int quntde = Convert.ToInt32(text.Substring(0, text.IndexOf('*')));
                return quntde;
            }
            else
                return 1;
        }

        private void CheckProductIntoGrid(string codigo)
        {
            int contador = 0;
            while (contador < this.dt_produtos.Rows.Count - 1)
            {
                if (this.dt_produtos.Rows[contador].Cells["ITEM"].Value.ToString().Equals(codigo))
                {
                    this.dt_produtos.Rows[contador].Cells["QUANT"].Value = (Convert.ToInt32(this.dt_produtos.Rows[contador].Cells["QUANT"].Value) + 1).ToString();
                    break;
                }
                contador++;
            }
        }

        private void btn_cancelar_compra_Click(object sender, EventArgs e)
        {
            const string message = "Deseja cancelar essa venda?";
            const string caption = "Cancelamento";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new Varejo_Venda.Nova_Venda().Show();
            }
            
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            VendasDTO venda = new VendasDTO();
            VendaProdutoDTO vendaProduto = new VendaProdutoDTO();
            int contador = 0;

            venda.tipoPagamento = cbx_forma.SelectedIndex;

            Adicionar_Valor troco = new Adicionar_Valor();

            DialogResult dr = troco.ShowDialog(this);

            if(dr.Equals(DialogResult.Cancel))
            {
                if(troco.Clicked().Equals("clicked"))
                {
                    if (!(string.IsNullOrWhiteSpace(troco.GetText())))
                    {
                        valor = Convert.ToDouble(troco.GetText());

                        if (descont > 0)
                        {
                            venda.total = total * descont;
                            SessionRN.getInstance().add(Constantes.TROCO, (Math.Abs(venda.total - valor)).ToString());

                            if (GeralRN.InsertSelling(venda))
                            {
                                while (contador < this.dt_produtos.Rows.Count)
                                {
                                    vendaProduto.codigo_venda = this.lbl_codigo_venda.Text;
                                    vendaProduto.codigo_produto = this.dt_produtos.Rows[contador].Cells["CODIGO"].Value.ToString();
                                    vendaProduto.quantidade_ites = Convert.ToInt32(this.dt_produtos.Rows[contador].Cells["QUANT"].Value);
                                    vendaProduto.total = Convert.ToDouble(this.dt_produtos.Rows[contador].Cells["TOTALL"].Value.ToString());

                                    GeralRN.InsertingProductInSelling(vendaProduto);
                                    GeralRN.UpdatingProductQuantify(vendaProduto.codigo_produto, vendaProduto.quantidade_ites);
                                    contador++;
                                }
                                if (GeralRN.GeneratePdf(this.lbl_codigo_venda.Text, this.cbx_forma.SelectedIndex))
                                {

                                }
                            }
                        }
                        else
                        {
                            venda.total = total;

                            if (GeralRN.InsertSelling(venda))
                            {
                                while (contador < this.dt_produtos.Rows.Count)
                                {
                                    vendaProduto.codigo_venda = this.lbl_codigo_venda.Text;
                                    vendaProduto.codigo_produto = this.dt_produtos.Rows[contador].Cells["ITEM"].Value.ToString();
                                    vendaProduto.quantidade_ites = Convert.ToInt32(this.dt_produtos.Rows[contador].Cells["QUANT"].Value);
                                    vendaProduto.total = Convert.ToDouble(this.dt_produtos.Rows[contador].Cells["TOTALL"].Value.ToString());

                                    GeralRN.InsertingProductInSelling(vendaProduto);
                                    GeralRN.UpdatingProductQuantify(vendaProduto.codigo_produto, vendaProduto.quantidade_ites);
                                    contador++;
                                }
                                if (GeralRN.GeneratePdf(this.lbl_codigo_venda.Text, this.cbx_forma.SelectedIndex))
                                {
                                    RecreateSelling();
                                }
                            }
                        }

                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    if (descont > 0)
                    {
                        venda.total = total * descont;

                        if (GeralRN.InsertSelling(venda))
                        {
                            while (contador < this.dt_produtos.Rows.Count)
                            {
                                vendaProduto.codigo_venda = this.lbl_codigo_venda.Text;
                                vendaProduto.codigo_produto = this.dt_produtos.Rows[contador].Cells["CODIGO"].Value.ToString();
                                vendaProduto.quantidade_ites = Convert.ToInt32(this.dt_produtos.Rows[contador].Cells["QUANT"].Value);
                                vendaProduto.total = Convert.ToDouble(this.dt_produtos.Rows[contador].Cells["TOTALL"].Value.ToString());

                                GeralRN.InsertingProductInSelling(vendaProduto);
                                GeralRN.UpdatingProductQuantify(vendaProduto.codigo_produto, vendaProduto.quantidade_ites);
                                contador++;
                            }
                            if (GeralRN.GeneratePdf(this.lbl_codigo_venda.Text, this.cbx_forma.SelectedIndex))
                            {
                                RecreateSelling();
                            }
                        }
                    }
                    else
                    {
                        venda.total = total;

                        if (GeralRN.InsertSelling(venda))
                        {
                            while (contador < this.dt_produtos.Rows.Count)
                            {
                                vendaProduto.codigo_venda = this.lbl_codigo_venda.Text;
                                vendaProduto.codigo_produto = this.dt_produtos.Rows[contador].Cells["ITEM"].Value.ToString();
                                vendaProduto.quantidade_ites = Convert.ToInt32(this.dt_produtos.Rows[contador].Cells["QUANT"].Value);
                                vendaProduto.total = Convert.ToDouble(this.dt_produtos.Rows[contador].Cells["TOTALL"].Value.ToString());

                                GeralRN.InsertingProductInSelling(vendaProduto);
                                GeralRN.UpdatingProductQuantify(vendaProduto.codigo_produto, vendaProduto.quantidade_ites);
                                contador++;
                            }
                            if (GeralRN.GeneratePdf(this.lbl_codigo_venda.Text, this.cbx_forma.SelectedIndex))
                            {
                                RecreateSelling();
                            }
                        }
                    }
                }
            }
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
                new Varejo_Venda.Nova_Venda().Show();
            }
        }

        private void CleanPage()
        {
            PreencherPedido();
            this.txt_produto.Clear();
            total = 0;
            count = 0;
            CleanGridView();
        }

        private void CleanGridView()
        {
            this.dt_produtos.DataSource = null;
            this.dt_produtos.Rows.Clear();
            this.dt_produtos.Refresh();
        }

        private void Nova_Venda_KeyUp(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode.Equals(Keys.F4))
                btn_cancelar_compra_Click(sender, e);
            else if (e.KeyCode.Equals(Keys.F5))
                btn_finalizar_Click(sender, e);
            else if (e.KeyCode.Equals(Keys.F2))
                btn_cancelar_Click(sender, e);
            else if (e.KeyCode.Equals(Keys.F3))
                btn_add_desc_Click(sender, e);
        }

        private void txt_produto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
                AdcionarProduto();
        }
    }
}
