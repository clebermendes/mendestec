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
    public partial class ProdutoEditar : Form
    {
        public ProdutoEditar()
        {
            InitializeComponent();

            if (!(SessionRN.getInstance().get(Constantes.COD_PRODUTO).Equals(null)))
            {
                PreencherComboFornecedor();
                PreencherComboTipo();
                PreencherProduto();
            }
            else
                MessageBox.Show("Produto não está na sessão!");
        }

        public void PreencherProduto()
        {
            ProdutoDTO produto = new ProdutoDTO();
            produto = GeralRN.GetProductByCode((string)SessionRN.getInstance().get(Constantes.COD_PRODUTO));
            this.txt_codigo.Text = produto.codBarras;
            this.txt_code_ref.Text = produto.code_ref.ToString();
            this.txt_descricao.Text = produto.descricao;
            this.cbx_fornecedor.SelectedValue = produto.fornecedor.codigo;
            this.cbx_tipo.SelectedIndex = produto.tipo.codigo;
            this.txt_preco_inicial.Text = produto.precoInicial.ToString();
            this.txt_preco_final.Text = produto.precoFinal.ToString();
            this.txt_qtde.Text = produto.qtde.ToString();
            this.txt_tamanho.Text = produto.tamanho;
            //FOTO
            MemoryStream ms = new MemoryStream(produto.imagem);
            imagem_box.Image = Image.FromStream(ms);
            imagem_box.SizeMode = PictureBoxSizeMode.StretchImage;
            imagem_box.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btn_ok_Click(object sender, EventArgs e)
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
                if (GeralRN.UpdateProduct(produto, imagem))
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.txt_descricao.Clear();
            this.txt_preco_final.Clear();
            this.txt_preco_inicial.Clear();
            this.txt_qtde.Clear();
            this.txt_tamanho.Clear();
            this.imagem_box.Image = null;
        }

        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            SessionRN.getInstance().remove(Constantes.COD_PRODUTO);
            this.Hide();
            new Varejo_Tec.Produto().Show();
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
                if (file.ShowDialog() == DialogResult.OK)
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
    }
}
