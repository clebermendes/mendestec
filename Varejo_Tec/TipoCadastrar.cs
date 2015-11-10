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
    public partial class TipoCadastrar : Form
    {
        public TipoCadastrar()
        {
            InitializeComponent();
            PreencherCodigo();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ChecarCampos())
            {
                TipoDTO tipo = new TipoDTO();
                tipo.tipo_nome = (this.txt_descricao.Text);

                try
                {
                    if (GeralRN.InsertType(tipo))
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!");
                        this.btn_limpar_Click(sender, e);
                    }
                }
                catch (Exception erro)
                {
                    throw erro;
                }

            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            PreencherCodigo();
            this.txt_descricao.Clear();
        }

        private void PreencherCodigo()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastCodeType();
            this.txt_codigo.Text = (codigo + 1).ToString();
        }

        private bool ChecarCampos()
        {
            if (!(this.txt_descricao.Text.Equals(string.Empty)))
                return true;
            else
                MessageBox.Show("Favor preencher todos os campos!"); return false;
        }

        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Produto().Show();
        }
    }
}
