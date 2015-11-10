using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varejo_Venda
{
    public partial class Adicionar_Valor : Form
    {

        string clicked = null;
        public Adicionar_Valor()
        {
            InitializeComponent();
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(GetText())))
            {
                clicked = "clicked";
                this.Close();
            }
            else
                MessageBox.Show("Preencha o troco!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetText()
        {
            return txt_valor.Text;
        }

        public string Clicked()
        {
            return clicked;
        }
    }
}
