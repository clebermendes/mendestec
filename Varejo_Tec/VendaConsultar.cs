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
    public partial class VendaConsultar : Form
    {
        public VendaConsultar()
        {
            InitializeComponent();
        }

        private void dtime_um_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dtime_um.Value;
            this.Text = result.ToString();
        }

        private void dtime_dois_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dtime_dois.Value;
            this.Text = result.ToString();
        }

        private void VendaConsultar_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dtime_um.Value = result;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if ((string.IsNullOrEmpty(this.txt_codigo.Text)))
            {
                if(dtime_dois.Checked)
                {
                    DateTime date = dtime_um.Value;
                    dt = GeralRN.GetSellingByDate(dtime_um.Value.ToString("yyyy-MM-dd"), dtime_dois.Value.ToString("yyyy-MM-dd"));
                    this.dtgrid_vendas.DataSource = dt;
                    this.btn_editar.Visible = true;
                }
                else
                {
                    dt = GeralRN.GetSellingByDate(dtime_um.Value.ToString("yyyy-MM-dd"));
                    this.dtgrid_vendas.DataSource = dt;
                    this.btn_editar.Visible = true;
                }
                
            }
            else if (!(string.IsNullOrEmpty(this.txt_codigo.Text)))
            {
                dt = GeralRN.GetSellingByCode(this.txt_codigo.Text);
                this.dtgrid_vendas.DataSource = dt;
                this.btn_editar.Visible = true;
            }
            else
                MessageBox.Show("Preencha algum campo para filtrar!");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            CleanGridView();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Historico().Show();
        }

        private void CleanGridView()
        {
            this.dtgrid_vendas.DataSource = null;
            this.dtgrid_vendas.Rows.Clear();
            this.dtgrid_vendas.Refresh();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dtgrid_vendas.SelectedCells.Count.Equals(1))
            {
                int selectedrowindex = dtgrid_vendas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dtgrid_vendas.Rows[selectedrowindex];
                string codigo = selectedrow.Cells[1].Value.ToString();
                SessionRN.getInstance().add(Constantes.COD_VENDA, codigo);
                this.Hide();
                new Varejo_Tec.VendaConsultarProdutos().Show();
            }
        }
    }
}
