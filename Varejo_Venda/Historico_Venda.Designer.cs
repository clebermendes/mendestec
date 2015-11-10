namespace Varejo_Venda
{
    partial class Historico_Venda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.lbl_nome_vendedor = new System.Windows.Forms.Label();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dt_produtos = new System.Windows.Forms.DataGridView();
            this.QUANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_troco.Font = new System.Drawing.Font("Norwester", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_troco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_troco.Location = new System.Drawing.Point(1032, 153);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_troco.Size = new System.Drawing.Size(144, 77);
            this.lbl_troco.TabIndex = 10;
            this.lbl_troco.Text = "0,00";
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pago.Font = new System.Drawing.Font("Norwester", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pago.Location = new System.Drawing.Point(755, 153);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pago.Size = new System.Drawing.Size(144, 77);
            this.lbl_pago.TabIndex = 11;
            this.lbl_pago.Text = "0,00";
            // 
            // lbl_nome_vendedor
            // 
            this.lbl_nome_vendedor.AutoSize = true;
            this.lbl_nome_vendedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_vendedor.Font = new System.Drawing.Font("Norwester", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_vendedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nome_vendedor.Location = new System.Drawing.Point(991, 297);
            this.lbl_nome_vendedor.Name = "lbl_nome_vendedor";
            this.lbl_nome_vendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_nome_vendedor.Size = new System.Drawing.Size(170, 44);
            this.lbl_nome_vendedor.TabIndex = 12;
            this.lbl_nome_vendedor.Text = "vendedor";
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pagamento.Font = new System.Drawing.Font("Norwester", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pagamento.Location = new System.Drawing.Point(963, 415);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pagamento.Size = new System.Drawing.Size(198, 44);
            this.lbl_pagamento.TabIndex = 13;
            this.lbl_pagamento.Text = "pagamento";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Norwester", 80.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_total.Location = new System.Drawing.Point(755, 539);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(242, 128);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "0,00";
            // 
            // dt_produtos
            // 
            this.dt_produtos.AllowUserToAddRows = false;
            this.dt_produtos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dt_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QUANT,
            this.CODIGO,
            this.ITEM,
            this.DESCRICAO,
            this.PRECO,
            this.DESCONTO,
            this.TOTALL});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_produtos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dt_produtos.Location = new System.Drawing.Point(24, 105);
            this.dt_produtos.Name = "dt_produtos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dt_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dt_produtos.Size = new System.Drawing.Size(583, 573);
            this.dt_produtos.TabIndex = 15;
            // 
            // QUANT
            // 
            this.QUANT.HeaderText = "QUANT";
            this.QUANT.Name = "QUANT";
            this.QUANT.Width = 80;
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
            this.ITEM.Visible = false;
            this.ITEM.Width = 135;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 250;
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
            this.DESCONTO.Visible = false;
            this.DESCONTO.Width = 70;
            // 
            // TOTALL
            // 
            this.TOTALL.HeaderText = "TOTAL";
            this.TOTALL.Name = "TOTALL";
            // 
            // Historico_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Varejo_Venda.Properties.Resources.historico_venda;
            this.ClientSize = new System.Drawing.Size(1200, 699);
            this.Controls.Add(this.dt_produtos);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagamento);
            this.Controls.Add(this.lbl_nome_vendedor);
            this.Controls.Add(this.lbl_troco);
            this.Controls.Add(this.lbl_pago);
            this.MaximizeBox = false;
            this.Name = "Historico_Venda";
            this.Text = "Historico_Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dt_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Label lbl_nome_vendedor;
        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView dt_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALL;
    }
}