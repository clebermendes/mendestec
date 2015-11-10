namespace Varejo_Venda
{
    partial class Nova_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_codigo_venda = new System.Windows.Forms.Label();
            this.lbl_nome_vendedor = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_total_pagar = new System.Windows.Forms.Label();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dt_produtos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_forma = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cancelar_compra = new System.Windows.Forms.Button();
            this.btn_add_desc = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo_venda
            // 
            this.lbl_codigo_venda.AutoSize = true;
            this.lbl_codigo_venda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo_venda.Font = new System.Drawing.Font("Norwester", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_venda.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_codigo_venda.Location = new System.Drawing.Point(977, 7);
            this.lbl_codigo_venda.Name = "lbl_codigo_venda";
            this.lbl_codigo_venda.Size = new System.Drawing.Size(85, 32);
            this.lbl_codigo_venda.TabIndex = 12;
            this.lbl_codigo_venda.Text = "venda";
            // 
            // lbl_nome_vendedor
            // 
            this.lbl_nome_vendedor.AutoSize = true;
            this.lbl_nome_vendedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_vendedor.Font = new System.Drawing.Font("Norwester", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_vendedor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_nome_vendedor.Location = new System.Drawing.Point(581, 49);
            this.lbl_nome_vendedor.Name = "lbl_nome_vendedor";
            this.lbl_nome_vendedor.Size = new System.Drawing.Size(125, 32);
            this.lbl_nome_vendedor.TabIndex = 11;
            this.lbl_nome_vendedor.Text = "vendedor";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_produto.Font = new System.Drawing.Font("Norwester", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_produto.Location = new System.Drawing.Point(23, 82);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(191, 58);
            this.lbl_produto.TabIndex = 2;
            this.lbl_produto.Text = "produto";
            // 
            // lbl_total_pagar
            // 
            this.lbl_total_pagar.AutoSize = true;
            this.lbl_total_pagar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_pagar.Font = new System.Drawing.Font("Norwester", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total_pagar.Location = new System.Drawing.Point(1033, 182);
            this.lbl_total_pagar.Name = "lbl_total_pagar";
            this.lbl_total_pagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total_pagar.Size = new System.Drawing.Size(108, 58);
            this.lbl_total_pagar.TabIndex = 10;
            this.lbl_total_pagar.Text = "0,00";
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pago.Font = new System.Drawing.Font("Norwester", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pago.Location = new System.Drawing.Point(1033, 289);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pago.Size = new System.Drawing.Size(108, 58);
            this.lbl_pago.TabIndex = 9;
            this.lbl_pago.Text = "0,00";
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_troco.Font = new System.Drawing.Font("Norwester", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_troco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_troco.Location = new System.Drawing.Point(1033, 391);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_troco.Size = new System.Drawing.Size(108, 58);
            this.lbl_troco.TabIndex = 8;
            this.lbl_troco.Text = "0,00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Norwester", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Location = new System.Drawing.Point(926, 541);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(215, 115);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "0,00";
            // 
            // dt_produtos
            // 
            this.dt_produtos.AllowUserToAddRows = false;
            this.dt_produtos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.ITEM,
            this.DESCRICAO,
            this.QUANT,
            this.PRECO,
            this.DESCONTO,
            this.TOTALL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_produtos.Location = new System.Drawing.Point(12, 159);
            this.dt_produtos.Name = "dt_produtos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dt_produtos.Size = new System.Drawing.Size(852, 290);
            this.dt_produtos.TabIndex = 14;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Visible = false;
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.Width = 135;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 250;
            // 
            // QUANT
            // 
            this.QUANT.HeaderText = "QUANT";
            this.QUANT.Name = "QUANT";
            this.QUANT.Width = 80;
            // 
            // PRECO
            // 
            this.PRECO.HeaderText = "VALOR";
            this.PRECO.Name = "PRECO";
            // 
            // DESCONTO
            // 
            this.DESCONTO.HeaderText = "DESC.";
            this.DESCONTO.Name = "DESCONTO";
            this.DESCONTO.Width = 70;
            // 
            // TOTALL
            // 
            this.TOTALL.HeaderText = "TOTAL";
            this.TOTALL.Name = "TOTALL";
            // 
            // cbx_forma
            // 
            this.cbx_forma.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_forma.ForeColor = System.Drawing.Color.Peru;
            this.cbx_forma.FormattingEnabled = true;
            this.cbx_forma.Location = new System.Drawing.Point(24, 517);
            this.cbx_forma.Name = "cbx_forma";
            this.cbx_forma.Size = new System.Drawing.Size(333, 33);
            this.cbx_forma.TabIndex = 6;
            this.cbx_forma.Text = "pagamento";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Varejo_Venda.Properties.Resources.botao_item;
            this.btn_cancelar.Location = new System.Drawing.Point(394, 485);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(96, 94);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cancelar_compra
            // 
            this.btn_cancelar_compra.Image = global::Varejo_Venda.Properties.Resources.botao_cancelar;
            this.btn_cancelar_compra.Location = new System.Drawing.Point(394, 585);
            this.btn_cancelar_compra.Name = "btn_cancelar_compra";
            this.btn_cancelar_compra.Size = new System.Drawing.Size(96, 94);
            this.btn_cancelar_compra.TabIndex = 4;
            this.btn_cancelar_compra.UseVisualStyleBackColor = true;
            this.btn_cancelar_compra.Click += new System.EventHandler(this.btn_cancelar_compra_Click);
            // 
            // btn_add_desc
            // 
            this.btn_add_desc.Image = global::Varejo_Venda.Properties.Resources.botao_desconto;
            this.btn_add_desc.Location = new System.Drawing.Point(496, 485);
            this.btn_add_desc.Name = "btn_add_desc";
            this.btn_add_desc.Size = new System.Drawing.Size(96, 94);
            this.btn_add_desc.TabIndex = 3;
            this.btn_add_desc.UseVisualStyleBackColor = true;
            this.btn_add_desc.Click += new System.EventHandler(this.btn_add_desc_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Image = global::Varejo_Venda.Properties.Resources.botao_fechar;
            this.btn_finalizar.Location = new System.Drawing.Point(496, 585);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(96, 94);
            this.btn_finalizar.TabIndex = 5;
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // txt_produto
            // 
            this.txt_produto.Font = new System.Drawing.Font("Norwester", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(24, 92);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(831, 42);
            this.txt_produto.TabIndex = 1;
            this.txt_produto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_produto_KeyUp);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Norwester", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_date.Location = new System.Drawing.Point(449, 7);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(140, 32);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "03/11/2015";
            // 
            // Nova_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Varejo_Venda.Properties.Resources.nova_venda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1194, 699);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_add_desc);
            this.Controls.Add(this.btn_cancelar_compra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cbx_forma);
            this.Controls.Add(this.dt_produtos);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_troco);
            this.Controls.Add(this.lbl_pago);
            this.Controls.Add(this.lbl_total_pagar);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_nome_vendedor);
            this.Controls.Add(this.lbl_codigo_venda);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Nova_Venda";
            this.Text = "Nova_Venda";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nova_Venda_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dt_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo_venda;
        private System.Windows.Forms.Label lbl_nome_vendedor;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_total_pagar;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView dt_produtos;
        private System.Windows.Forms.ComboBox cbx_forma;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cancelar_compra;
        private System.Windows.Forms.Button btn_add_desc;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALL;
    }
}