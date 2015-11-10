namespace Varejo_Tec
{
    partial class Historico
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
            this.gd_vendas = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_vendas = new System.Windows.Forms.Button();
            this.btn_consultar_vendas = new System.Windows.Forms.Button();
            this.btn_sair_vendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_vendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_txt_produto
            // 
            this.lbl_txt_produto.AutoSize = true;
            this.lbl_txt_produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_txt_produto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_produto.Location = new System.Drawing.Point(0, 4);
            this.lbl_txt_produto.Name = "lbl_txt_produto";
            this.lbl_txt_produto.Size = new System.Drawing.Size(653, 75);
            this.lbl_txt_produto.TabIndex = 7;
            this.lbl_txt_produto.Text = "Consulta de Vendas";
            // 
            // gd_vendas
            // 
            this.gd_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gd_vendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gd_vendas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gd_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gd_vendas.Enabled = false;
            this.gd_vendas.Location = new System.Drawing.Point(13, 288);
            this.gd_vendas.Name = "gd_vendas";
            this.gd_vendas.RowHeadersWidth = 100;
            this.gd_vendas.Size = new System.Drawing.Size(1242, 352);
            this.gd_vendas.TabIndex = 10;
            // 
            // check
            // 
            this.check.HeaderText = "#";
            this.check.Name = "check";
            this.check.Width = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_add_vendas);
            this.panel1.Controls.Add(this.btn_consultar_vendas);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 151);
            this.panel1.TabIndex = 9;
            // 
            // btn_add_vendas
            // 
            this.btn_add_vendas.Image = global::Varejo_Tec.Properties.Resources.adicionar_vendas;
            this.btn_add_vendas.Location = new System.Drawing.Point(1108, 15);
            this.btn_add_vendas.Name = "btn_add_vendas";
            this.btn_add_vendas.Size = new System.Drawing.Size(132, 119);
            this.btn_add_vendas.TabIndex = 2;
            this.btn_add_vendas.UseVisualStyleBackColor = true;
            this.btn_add_vendas.Click += new System.EventHandler(this.btn_add_vendas_Click);
            // 
            // btn_consultar_vendas
            // 
            this.btn_consultar_vendas.Image = global::Varejo_Tec.Properties.Resources.vendas;
            this.btn_consultar_vendas.Location = new System.Drawing.Point(13, 15);
            this.btn_consultar_vendas.Name = "btn_consultar_vendas";
            this.btn_consultar_vendas.Size = new System.Drawing.Size(132, 119);
            this.btn_consultar_vendas.TabIndex = 1;
            this.btn_consultar_vendas.UseVisualStyleBackColor = true;
            this.btn_consultar_vendas.Click += new System.EventHandler(this.btn_consultar_vendas_Click);
            // 
            // btn_sair_vendas
            // 
            this.btn_sair_vendas.Image = global::Varejo_Tec.Properties.Resources.sair;
            this.btn_sair_vendas.Location = new System.Drawing.Point(1121, 12);
            this.btn_sair_vendas.Name = "btn_sair_vendas";
            this.btn_sair_vendas.Size = new System.Drawing.Size(134, 116);
            this.btn_sair_vendas.TabIndex = 8;
            this.btn_sair_vendas.UseVisualStyleBackColor = true;
            this.btn_sair_vendas.Click += new System.EventHandler(this.btn_sair_vendas_Click);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.lbl_txt_produto);
            this.Controls.Add(this.btn_sair_vendas);
            this.Controls.Add(this.gd_vendas);
            this.Controls.Add(this.panel1);
            this.Name = "Historico";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.gd_vendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txt_produto;
        private System.Windows.Forms.Button btn_consultar_vendas;
        private System.Windows.Forms.Button btn_sair_vendas;
        private System.Windows.Forms.DataGridView gd_vendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_vendas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}