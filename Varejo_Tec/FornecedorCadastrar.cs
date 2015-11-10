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
    public partial class FornecedorCadastrar : Form
    {
        public FornecedorCadastrar()
        {
            InitializeComponent();
            PreencherCodigo();
            PreencherComboEstado();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(ChecarCampos())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.cnpj = this.txt_cnpj.Text;
                fornecedor.email = this.txt_email.Text;
                fornecedor.complemento = this.txt_complemento.Text;
                fornecedor.cidade_id = this.cbx_cidade.SelectedIndex;
                fornecedor.estado_id = Convert.ToByte(this.cbx_estado.SelectedIndex);
                fornecedor.cep = this.txt_cep.Text;
                fornecedor.numero = this.txt_numero.Text;
                fornecedor.nome = this.txt_nome.Text;
                fornecedor.nomeFantasia = this.txt_nome_fantasia.Text;
                fornecedor.bairro = this.txt_bairro.Text;
                fornecedor.telefone = this.txt_telefone.Text;


                try
                {
                    if (GeralRN.InsertFornecedor(fornecedor))
                    {
                        MessageBox.Show("Fornecedor cadastrado com sucesso!");
                        this.btn_limpar_Click(sender, e);
                    }
                        
                }
                catch(Exception erro)
                {
                    throw erro;
                }

            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            PreencherCodigo();
            this.txt_nome.Clear();
            this.txt_nome_fantasia.Clear();
            this.txt_cnpj.Clear();
            this.cbx_estado.SelectedIndex = 0;
            this.cbx_cidade.Items.Clear();
            this.txt_complemento.Clear();
            this.txt_telefone.Clear();
            this.txt_numero.Clear();
            this.txt_cep.Clear();
            this.txt_bairro.Clear();
            this.txt_email.Clear();
        }

        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Principal().Show();
        }

        private void PreencherCodigo()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastBarCodeForne();
            this.txt_codigo.Text = (codigo + 1).ToString();
        }

        private void PreencherComboEstado()
        {
            cbx_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_estado.DataSource = GeralRN.GetAllEstados();
            cbx_estado.ValueMember = "EstadoId";
            cbx_estado.DisplayMember = "Sigla";
            cbx_estado.Update();
        }

        private void PreencherComboCidade(int estado_id)
        {
            cbx_cidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_cidade.DataSource = GeralRN.GetAllCidades(estado_id);
            cbx_cidade.ValueMember = "CidadeId";
            cbx_cidade.DisplayMember = "Nome";
            cbx_cidade.Update();
        }

        private bool ChecarCampos()
        {
            if (!(this.txt_nome.Text.Equals(string.Empty) && this.txt_nome_fantasia.Text.Equals(string.Empty) && this.txt_telefone.Text.Equals(string.Empty) && this.txt_complemento.Text.Equals(string.Empty) && this.txt_email.Text.Equals(string.Empty)))
                return true;
            else
                MessageBox.Show("Favor preencher todos os campos!"); return false;
        }

        private void cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cbx_estado.SelectedIndex.Equals(0)))
            {
                PreencherComboCidade(Convert.ToInt32(cbx_estado.SelectedIndex));
            }
        }

    }
}
