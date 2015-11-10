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
    public partial class ProdutoConsulta : Form
    {
        public ProdutoConsulta()
        {
            InitializeComponent();
            PreencherComboTipo();
            
        }

        private void PreencherComboTipo()
        {
            cbx_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_tipo.DataSource = GeralRN.GetTipos(); 
            cbx_tipo.ValueMember = "codigo";
            cbx_tipo.DisplayMember = "nome_tipo";
            cbx_tipo.Update();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!(this.cbx_tipo.SelectedIndex.Equals(0)))
            {
                dt = GeralRN.GetProductbyFilter(this.cbx_tipo.SelectedIndex, this.txt_codigo.Text, this.txt_tamanho.Text, this.txt_descricao.Text);
                this.dtgrid_produtos.DataSource = dt;
                this.btn_editar.Visible = true;
            }
            else if (!(string.IsNullOrWhiteSpace(this.txt_codigo.Text) && string.IsNullOrWhiteSpace(this.txt_tamanho.Text) &&  string.IsNullOrWhiteSpace(this.txt_descricao.Text)))
            {
                dt = GeralRN.GetProductbyFilter(this.txt_codigo.Text, this.txt_tamanho.Text, this.txt_descricao.Text);
                this.dtgrid_produtos.DataSource = dt;
                this.btn_editar.Visible = true;
            }
                else
                    MessageBox.Show("Preencha algum campo para filtrar!");

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.txt_codigo.Clear();
            this.txt_descricao.Clear();
            this.txt_tamanho.Clear();
            this.cbx_tipo.SelectedIndex = 0;
            CleanGridView();
        }

        private void CleanGridView()
        {
            this.dtgrid_produtos.DataSource = null;
            this.dtgrid_produtos.Rows.Clear();
            this.dtgrid_produtos.Refresh();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Varejo_Tec.Produto().Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(this.dtgrid_produtos.SelectedCells.Count.Equals(1))
            {
                int selectedrowindex = dtgrid_produtos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dtgrid_produtos.Rows[selectedrowindex];
                string codigo = selectedrow.Cells[1].Value.ToString();
                SessionRN.getInstance().add(Constantes.COD_PRODUTO, codigo);
                this.Hide();
                new Varejo_Tec.ProdutoEditar().Show();
            }
            
        }
    }
}
