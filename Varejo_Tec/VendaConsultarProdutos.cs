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
    public partial class VendaConsultarProdutos : Form
    {
        public VendaConsultarProdutos()
        {
            InitializeComponent();

            if (!(SessionRN.getInstance().get(Constantes.COD_VENDA).Equals(null)))
            {
                PreencherDataGrid();
                PreencherLabels();
            }
            else
                MessageBox.Show("Produto não está na sessão!");
        }


        private void PreencherDataGrid()
        {
            dtgrid_produtos.DataSource = GeralRN.GetSellingBySellingCode((string)SessionRN.getInstance().get(Constantes.COD_VENDA));
        }

        private void PreencherLabels()
        {
            VendasDTO venda = new VendasDTO();
            venda = GeralRN.GetSellingByCode2((string)SessionRN.getInstance().get(Constantes.COD_VENDA));
            lbl_pedido.Text = venda.codigo;
            lbl_date.Text = venda.dataEmissao.ToString("dd/MM/yyyy");
            lbl_pagamento.Text = GeralRN.GetPaymentName(venda.tipoPagamento);
        }

        private void btn_gerar_pdf_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            SessionRN.getInstance().remove(Constantes.COD_VENDA);
            this.Hide();
            new Varejo_Tec.Historico().Show();
        }
    }
}
