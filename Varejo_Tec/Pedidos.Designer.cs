namespace Varejo_Tec
{
    partial class Pedidos
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
            this.lbl_txt_produto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_fornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dtgrid_venda = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_less = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_txt_produto
            // 
            this.lbl_txt_produto.AutoSize = true;
            this.lbl_txt_produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_txt_produto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_produto.Location = new System.Drawing.Point(12, 9);
            this.lbl_txt_produto.Name = "lbl_txt_produto";
            this.lbl_txt_produto.Size = new System.Drawing.Size(580, 75);
            this.lbl_txt_produto.TabIndex = 1;
            this.lbl_txt_produto.Text = "Cadastrar Pedido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_fornecedor);
            this.panel1.Controls.Add(this.lbl_pedido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 188);
            this.panel1.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(991, 2);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(205, 40);
            this.lbl_date.TabIndex = 16;
            this.lbl_date.Text = "17/10/2015";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(877, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 40);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fornecedor:";
            // 
            // cbx_fornecedor
            // 
            this.cbx_fornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fornecedor.FormattingEnabled = true;
            this.cbx_fornecedor.Location = new System.Drawing.Point(44, 129);
            this.cbx_fornecedor.Name = "cbx_fornecedor";
            this.cbx_fornecedor.Size = new System.Drawing.Size(1152, 41);
            this.cbx_fornecedor.TabIndex = 5;
            this.cbx_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cbx_fornecedor_SelectedIndexChanged);
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.Location = new System.Drawing.Point(204, 2);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(164, 40);
            this.lbl_pedido.TabIndex = 4;
            this.lbl_pedido.Text = "1785478";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedido Nº:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Controls.Add(this.dtgrid_venda);
            this.panel2.Controls.Add(this.btn_less);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.txt_quant);
            this.panel2.Controls.Add(this.txt_codigo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 405);
            this.panel2.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Varejo_Tec.Properties.Resources.ok_small;
            this.btn_ok.Location = new System.Drawing.Point(1142, 321);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 70);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dtgrid_venda
            // 
            this.dtgrid_venda.AllowUserToAddRows = false;
            this.dtgrid_venda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_venda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.code,
            this.quatde,
            this.codigo,
            this.precoInicial,
            this.precototal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_venda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_venda.Location = new System.Drawing.Point(9, 66);
            this.dtgrid_venda.Name = "dtgrid_venda";
            this.dtgrid_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrid_venda.Size = new System.Drawing.Size(1126, 287);
            this.dtgrid_venda.TabIndex = 22;
            // 
            // check
            // 
            this.check.HeaderText = "#";
            this.check.Name = "check";
            // 
            // code
            // 
            this.code.HeaderText = "CÓDIGO";
            this.code.Name = "code";
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.code.Visible = false;
            // 
            // quatde
            // 
            this.quatde.HeaderText = "QUANTIDADE";
            this.quatde.Name = "quatde";
            this.quatde.Width = 180;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓD.REF";
            this.codigo.Name = "codigo";
            this.codigo.Width = 350;
            // 
            // precoInicial
            // 
            this.precoInicial.HeaderText = "PREÇO UNIT. $";
            this.precoInicial.Name = "precoInicial";
            this.precoInicial.Width = 180;
            // 
            // precototal
            // 
            this.precototal.HeaderText = "TOTAL $";
            this.precototal.Name = "precototal";
            this.precototal.Width = 130;
            // 
            // btn_less
            // 
            this.btn_less.Image = global::Varejo_Tec.Properties.Resources.minus;
            this.btn_less.Location = new System.Drawing.Point(1142, 79);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(54, 40);
            this.btn_less.TabIndex = 21;
            this.btn_less.UseVisualStyleBackColor = true;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Varejo_Tec.Properties.Resources.plus;
            this.btn_add.Location = new System.Drawing.Point(1142, 34);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 39);
            this.btn_add.TabIndex = 20;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quant.Location = new System.Drawing.Point(896, 28);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(239, 32);
            this.txt_quant.TabIndex = 19;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(10, 28);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(235, 32);
            this.txt_codigo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(891, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Código do Produto:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Varejo_Tec.Properties.Resources.cancel_small;
            this.btn_cancel.Location = new System.Drawing.Point(1179, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 70);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(807, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(926, 356);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(209, 40);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "R$ 1000,00";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_txt_produto);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txt_produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_fornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgrid_venda;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatde;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn precototal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
    }
}