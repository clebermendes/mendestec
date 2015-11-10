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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            if(!(SessionRN.getInstance().get(Constantes.USUARIO_LOGADO).Equals(null)))
            {
                this.lbl_nome_user.Text = SessionRN.getInstance().get(Constantes.USUARIO_LOGADO).ToString();
            }
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Login().Show();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Produto().Show();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Historico().Show();
        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.FornecedorCadastrar().Show();
        }
    }
}
