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
    public partial class Desconto : Form
    {
        string clicked = null;
        public Desconto()
        {
            InitializeComponent();
        }

        public void btn_aplicar_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(GetText())))
            {
                clicked = "clicked";
                this.Close();
            }
            else
                MessageBox.Show("Preencha o desconto!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetText()
        {
            return txt_desconto.Text;
        }

        public string Clicked()
        {
            return clicked;
        }
    }
}
