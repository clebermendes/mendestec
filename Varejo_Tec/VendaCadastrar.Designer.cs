namespace Varejo_Tec
{
    partial class VendaCadastrar
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
            this.lbl_consult_prod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dtgrid_venda = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_less = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_venda)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_consult_prod
            // 
            this.lbl_consult_prod.AutoSize = true;
            this.lbl_consult_prod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_consult_prod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consult_prod.Location = new System.Drawing.Point(14, 13);
            this.lbl_consult_prod.Name = "lbl_consult_prod";
            this.lbl_consult_prod.Size = new System.Drawing.Size(356, 65);
            this.lbl_consult_prod.TabIndex = 1;
            this.lbl_consult_prod.Text = "Nova Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl_consult_prod);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 92);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.dtgrid_venda);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_less);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.txt_quant);
            this.panel2.Controls.Add(this.txt_codigo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_pedido);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 427);
            this.panel2.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(826, 374);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 40);
            this.lbl_total.TabIndex = 17;
            // 
            // dtgrid_venda
            // 
            this.dtgrid_venda.AllowUserToAddRows = false;
            this.dtgrid_venda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.descri,
            this.precoo,
            this.totall});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_venda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_venda.Location = new System.Drawing.Point(21, 163);
            this.dtgrid_venda.Name = "dtgrid_venda";
            this.dtgrid_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrid_venda.Size = new System.Drawing.Size(1088, 202);
            this.dtgrid_venda.TabIndex = 15;
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
            // descri
            // 
            this.descri.HeaderText = "DESCRIÇÃO";
            this.descri.Name = "descri";
            this.descri.Width = 350;
            // 
            // precoo
            // 
            this.precoo.HeaderText = "PREÇO";
            this.precoo.Name = "precoo";
            // 
            // totall
            // 
            this.totall.HeaderText = "TOTAL";
            this.totall.Name = "totall";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 40);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total:";
            // 
            // btn_less
            // 
            this.btn_less.Image = global::Varejo_Tec.Properties.Resources.minus;
            this.btn_less.Location = new System.Drawing.Point(1125, 163);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(54, 48);
            this.btn_less.TabIndex = 12;
            this.btn_less.UseVisualStyleBackColor = true;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Varejo_Tec.Properties.Resources.plus;
            this.btn_add.Location = new System.Drawing.Point(1125, 107);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 48);
            this.btn_add.TabIndex = 11;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F);
            this.txt_quant.Location = new System.Drawing.Point(714, 107);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(395, 48);
            this.txt_quant.TabIndex = 8;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F);
            this.txt_codigo.Location = new System.Drawing.Point(21, 107);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(687, 48);
            this.txt_codigo.TabIndex = 7;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código do Produto:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1028, 13);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(205, 40);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "08/10/2015";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(914, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.Location = new System.Drawing.Point(198, 13);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(206, 40);
            this.lbl_pedido.TabIndex = 2;
            this.lbl_pedido.Text = "178546987";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido Nº:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btn_ok);
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.chklist);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 151);
            this.panel3.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Varejo_Tec.Properties.Resources.ok_small;
            this.btn_ok.Location = new System.Drawing.Point(1145, 69);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 70);
            this.btn_ok.TabIndex = 15;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Varejo_Tec.Properties.Resources.cancel_small;
            this.btn_cancel.Location = new System.Drawing.Point(1051, 69);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 70);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // chklist
            // 
            this.chklist.CheckOnClick = true;
            this.chklist.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.chklist.FormattingEnabled = true;
            this.chklist.Items.AddRange(new object[] {
            "Á VISTA",
            "CARTÃO DE CRÉDITO",
            "CARTÃO DE DÉBITO"});
            this.chklist.Location = new System.Drawing.Point(21, 45);
            this.chklist.Name = "chklist";
            this.chklist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklist.Size = new System.Drawing.Size(403, 94);
            this.chklist.TabIndex = 16;
            this.chklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklist_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(410, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "Formas de Pagamento:";
            // 
            // chk
            // 
            this.chk.Name = "chk";
            // 
            // CODIGO
            // 
            this.CODIGO.Name = "CODIGO";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // PRECO
            // 
            this.PRECO.Name = "PRECO";
            // 
            // VendaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VendaCadastrar";
            this.Text = "VendaCadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_venda)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_consult_prod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckedListBox chklist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridView dtgrid_venda;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatde;
        private System.Windows.Forms.DataGridViewTextBoxColumn descri;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totall;
    }
}