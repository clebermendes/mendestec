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
    public partial class Cancelar_Item : Form
    {
        string clicked = null;
        public Cancelar_Item()
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
                MessageBox.Show("Preencha o código do produto!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetText()
        {
            return txt_produto.Text;
        }

        public string Clicked()
        {
            return clicked;
        }

        private void txt_produto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btn_aplicar_Click(sender, e);
        }
    }
}
