using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Business;
using System.Drawing;
using System.IO;

namespace Varejo_Tec
{
    public partial class ProdutoCadastrar : Form
    {
        public ProdutoCadastrar()
        {
            InitializeComponent();
            PreencherComboTipo();
            PreencherComboFornecedor();
            PreencherCodigo();
        }

        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Produto().Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            PreencherCodigo();
            this.cbx_tipo.SelectedIndex = 0;
            this.txt_descricao.Clear();
            this.txt_preco_final.Clear();
            this.txt_preco_inicial.Clear();
            this.txt_qtde.Clear();
            this.txt_tamanho.Clear();
            this.txt_code_ref.Clear();
            this.imagem_box.Image = null;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(ChecarCampos())
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto.codBarras = this.txt_codigo.Text;
                produto.code_ref = Convert.ToInt64(this.txt_code_ref.Text);
                produto.descricao = this.txt_descricao.Text;
                produto.precoInicial = Convert.ToDouble((this.txt_preco_inicial.Text = string.IsNullOrWhiteSpace(this.txt_preco_inicial.Text) ? "0" : this.txt_preco_inicial.Text));
                produto.precoFinal = Convert.ToDouble((this.txt_preco_final.Text = string.IsNullOrWhiteSpace(this.txt_preco_final.Text) ? "0" : this.txt_preco_final.Text));
                produto.tamanho = this.txt_tamanho.Text;
                produto.tipo.codigo = this.cbx_tipo.SelectedIndex;
                produto.fornecedor.codigo = Convert.ToInt32(cbx_fornecedor.SelectedValue);
                MemoryStream ms = new MemoryStream();
                imagem_box.Image.Save(ms, imagem_box.Image.RawFormat);
                byte[] imagem = ms.GetBuffer();
                

                try
                {
                    if (GeralRN.InsertProduct(produto,imagem))
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

        private bool ChecarCampos()
        {
            if (!(this.cbx_tipo.SelectedIndex.Equals(0)))
                if (!(this.txt_code_ref.Text.Equals(string.Empty) && this.txt_preco_inicial.Text.Equals(string.Empty) && this.txt_tamanho.Text.Equals(string.Empty)))
                    return true;
            else
                MessageBox.Show("Favor preencher todos os campos!"); return false;
        }

        private void PreencherComboTipo()
        {
            cbx_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_tipo.DataSource = GeralRN.GetTipos();
            cbx_tipo.ValueMember = "codigo";
            cbx_tipo.DisplayMember = "nome_tipo";
            cbx_tipo.Update();
        }

        private void PreencherComboFornecedor()
        {
            cbx_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_fornecedor.DataSource = GeralRN.GetAllFornecedores();
            cbx_fornecedor.ValueMember = "codigo";
            cbx_fornecedor.DisplayMember = "nomeFantasia";
            cbx_fornecedor.Update();
        }

        private void PreencherCodigo()
        {
            double codigo = 0;
            codigo = GeralRN.GetLastBarCode();
            this.txt_codigo.Text = (codigo + 1).ToString();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            OpenPhoto();
        }

        private void OpenPhoto()
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.InitialDirectory = "C:/Picture/";
                file.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                file.FilterIndex = 2;
                if(file.ShowDialog() == DialogResult.OK)
                {
                    imagem_box.Image = Image.FromFile(file.FileName);
                    imagem_box.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagem_box.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            catch
            {

            }
        }
    }
}
