namespace Varejo_Tec
{
    partial class Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_txt_produto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_produtos = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sair_produto = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_tipo = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_txt_produto
            // 
            this.lbl_txt_produto.AutoSize = true;
            this.lbl_txt_produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_txt_produto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_produto.Location = new System.Drawing.Point(12, 9);
            this.lbl_txt_produto.Name = "lbl_txt_produto";
            this.lbl_txt_produto.Size = new System.Drawing.Size(318, 75);
            this.lbl_txt_produto.TabIndex = 0;
            this.lbl_txt_produto.Text = "Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_pedidos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_tipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Location = new System.Drawing.Point(13, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 179);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(918, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produtos";
            // 
            // dtgrid_produtos
            // 
            this.dtgrid_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrid_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_produtos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_produtos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrid_produtos.Location = new System.Drawing.Point(13, 337);
            this.dtgrid_produtos.MultiSelect = false;
            this.dtgrid_produtos.Name = "dtgrid_produtos";
            this.dtgrid_produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrid_produtos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_produtos.Size = new System.Drawing.Size(1255, 324);
            this.dtgrid_produtos.TabIndex = 7;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "#";
            this.checkbox.Name = "checkbox";
            this.checkbox.Width = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pedidos";
            // 
            // btn_sair_produto
            // 
            this.btn_sair_produto.Image = global::Varejo_Tec.Properties.Resources.sair;
            this.btn_sair_produto.Location = new System.Drawing.Point(1133, 0);
            this.btn_sair_produto.Name = "btn_sair_produto";
            this.btn_sair_produto.Size = new System.Drawing.Size(134, 116);
            this.btn_sair_produto.TabIndex = 5;
            this.btn_sair_produto.UseVisualStyleBackColor = true;
            this.btn_sair_produto.Click += new System.EventHandler(this.btn_sair_produto_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.Image = global::Varejo_Tec.Properties.Resources.add;
            this.btn_pedidos.Location = new System.Drawing.Point(528, 47);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(132, 119);
            this.btn_pedidos.TabIndex = 11;
            this.btn_pedidos.UseVisualStyleBackColor = true;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
            // 
            // btn_tipo
            // 
            this.btn_tipo.Image = global::Varejo_Tec.Properties.Resources.tipo;
            this.btn_tipo.Location = new System.Drawing.Point(925, 47);
            this.btn_tipo.Name = "btn_tipo";
            this.btn_tipo.Size = new System.Drawing.Size(132, 119);
            this.btn_tipo.TabIndex = 8;
            this.btn_tipo.UseVisualStyleBackColor = true;
            this.btn_tipo.Click += new System.EventHandler(this.btn_tipo_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::Varejo_Tec.Properties.Resources.consultar;
            this.btn_consultar.Location = new System.Drawing.Point(24, 47);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(132, 119);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Image = global::Varejo_Tec.Properties.Resources.adicionar;
            this.btn_cadastrar.Location = new System.Drawing.Point(162, 47);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(132, 119);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.dtgrid_produtos);
            this.Controls.Add(this.btn_sair_produto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_txt_produto);
            this.Name = "Produto";
            this.Text = "Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txt_produto;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair_produto;
        private System.Windows.Forms.DataGridView dtgrid_produtos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tipo;
        private System.Windows.Forms.Button btn_pedidos;
        private System.Windows.Forms.Label label3;
    }
}