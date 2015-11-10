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

namespace Varejo_Tec
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
            PreencherDataGrid();
        }

        private void btn_sair_vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Principal().Show();
        }

        private void btn_add_vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.VendaCadastrar().Show();
        }

        private void btn_consultar_vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.VendaConsultar().Show();
        }

        private void PreencherDataGrid()
        {
            DataTable dt = new DataTable();
            dt = GeralRN.GetAllSellingsFromToday();
            
        }
    }
}
