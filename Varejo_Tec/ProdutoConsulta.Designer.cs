namespace Varejo_Tec
{
    partial class ProdutoConsulta
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
            this.pnl_consulta = new System.Windows.Forms.Panel();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dtgrid_produtos = new System.Windows.Forms.DataGridView();
            this.check_grid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_consulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_consult_prod
            // 
            this.lbl_consult_prod.AutoSize = true;
            this.lbl_consult_prod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_consult_prod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consult_prod.Location = new System.Drawing.Point(12, 1);
            this.lbl_consult_prod.Name = "lbl_consult_prod";
            this.lbl_consult_prod.Size = new System.Drawing.Size(516, 65);
            this.lbl_consult_prod.TabIndex = 0;
            this.lbl_consult_prod.Text = "Filtro de Produtos";
            // 
            // pnl_consulta
            // 
            this.pnl_consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_consulta.Controls.Add(this.txt_tamanho);
            this.pnl_consulta.Controls.Add(this.label3);
            this.pnl_consulta.Controls.Add(this.txt_descricao);
            this.pnl_consulta.Controls.Add(this.label2);
            this.pnl_consulta.Controls.Add(this.txt_codigo);
            this.pnl_consulta.Controls.Add(this.cbx_tipo);
            this.pnl_consulta.Controls.Add(this.lbl_codigo);
            this.pnl_consulta.Controls.Add(this.label1);
            this.pnl_consulta.Location = new System.Drawing.Point(12, 201);
            this.pnl_consulta.Name = "pnl_consulta";
            this.pnl_consulta.Size = new System.Drawing.Size(1255, 155);
            this.pnl_consulta.TabIndex = 1;
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.txt_tamanho.Location = new System.Drawing.Point(897, 56);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(305, 41);
            this.txt_tamanho.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tamanho:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.txt_descricao.Location = new System.Drawing.Point(195, 103);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(1007, 41);
            this.txt_descricao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.txt_codigo.Location = new System.Drawing.Point(195, 52);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(536, 41);
            this.txt_codigo.TabIndex = 4;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Location = new System.Drawing.Point(195, 5);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(536, 41);
            this.cbx_tipo.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(26, 60);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(125, 33);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 131);
            this.panel1.TabIndex = 5;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_editar.Image = global::Varejo_Tec.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(195, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(124, 123);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultar.Image = global::Varejo_Tec.Properties.Resources.ok;
            this.btn_consultar.Location = new System.Drawing.Point(1116, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 123);
            this.btn_consultar.TabIndex = 7;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Image = global::Varejo_Tec.Properties.Resources.cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(7, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 123);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpar.Image = global::Varejo_Tec.Properties.Resources.trash;
            this.btn_limpar.Location = new System.Drawing.Point(974, 5);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(124, 123);
            this.btn_limpar.TabIndex = 8;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dtgrid_produtos
            // 
            this.dtgrid_produtos.AllowUserToAddRows = false;
            this.dtgrid_produtos.AllowUserToDeleteRows = false;
            this.dtgrid_produtos.AllowUserToOrderColumns = true;
            this.dtgrid_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrid_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_produtos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_grid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_produtos.Location = new System.Drawing.Point(12, 362);
            this.dtgrid_produtos.MultiSelect = false;
            this.dtgrid_produtos.Name = "dtgrid_produtos";
            this.dtgrid_produtos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrid_produtos.Size = new System.Drawing.Size(1255, 324);
            this.dtgrid_produtos.TabIndex = 8;
            // 
            // check_grid
            // 
            this.check_grid.HeaderText = "#";
            this.check_grid.Name = "check_grid";
            this.check_grid.Width = 28;
            // 
            // ProdutoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.dtgrid_produtos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_consulta);
            this.Controls.Add(this.lbl_consult_prod);
            this.Name = "ProdutoConsulta";
            this.Text = "ProdutoConsulta";
            this.pnl_consulta.ResumeLayout(false);
            this.pnl_consulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_consult_prod;
        private System.Windows.Forms.Panel pnl_consulta;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgrid_produtos;
        private System.Windows.Forms.TextBox txt_tamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_grid;
    }
}