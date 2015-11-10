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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public static bool ChecarLogin(string login, string senha)
        {
            try
            {
                if (!(GeralRN.ChecarLogin(login, senha).Equals(0)))
                    return true;
                else
                    return false;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Login.Text) | string.IsNullOrEmpty(txt_senha.Text))
            {
                MessageBox.Show("Digite seu Login e/ou Senha");
            }
            else
            {
                if (ChecarLogin(txt_Login.Text, txt_senha.Text))
                {
                    SessionRN.getInstance().add(Constantes.USUARIO_LOGADO, txt_Login.Text);
                    this.Hide();
                    new Varejo_Venda.Nova_Venda().Show();
                }
                else
                {
                    MessageBox.Show("Login e/ou Senha invalidos!");
                    this.Btn_Limpar_Click(sender, e);
                }

            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            this.txt_Login.Text = string.Empty;
            this.txt_senha.Text = string.Empty;
        }
    }
}
