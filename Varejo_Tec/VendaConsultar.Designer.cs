namespace Varejo_Tec
{
    partial class VendaConsultar
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
            this.check_grid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.dtgrid_vendas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pnl_consulta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtime_dois = new System.Windows.Forms.DateTimePicker();
            this.dtime_um = new System.Windows.Forms.DateTimePicker();
            this.lbl_consult_prod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_vendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_consulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_grid
            // 
            this.check_grid.HeaderText = "#";
            this.check_grid.Name = "check_grid";
            this.check_grid.Width = 28;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(16, 38);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(574, 39);
            this.txt_codigo.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(16, 2);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(125, 33);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "Código:";
            // 
            // dtgrid_vendas
            // 
            this.dtgrid_vendas.AllowUserToAddRows = false;
            this.dtgrid_vendas.AllowUserToDeleteRows = false;
            this.dtgrid_vendas.AllowUserToOrderColumns = true;
            this.dtgrid_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrid_vendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_vendas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_grid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_vendas.Location = new System.Drawing.Point(12, 375);
            this.dtgrid_vendas.MultiSelect = false;
            this.dtgrid_vendas.Name = "dtgrid_vendas";
            this.dtgrid_vendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrid_vendas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrid_vendas.Size = new System.Drawing.Size(1255, 262);
            this.dtgrid_vendas.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 131);
            this.panel1.TabIndex = 11;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_editar.Image = global::Varejo_Tec.Properties.Resources.buscar;
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
            // pnl_consulta
            // 
            this.pnl_consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_consulta.Controls.Add(this.label2);
            this.pnl_consulta.Controls.Add(this.label1);
            this.pnl_consulta.Controls.Add(this.dtime_dois);
            this.pnl_consulta.Controls.Add(this.dtime_um);
            this.pnl_consulta.Controls.Add(this.txt_codigo);
            this.pnl_consulta.Controls.Add(this.lbl_codigo);
            this.pnl_consulta.Location = new System.Drawing.Point(12, 202);
            this.pnl_consulta.Name = "pnl_consulta";
            this.pnl_consulta.Size = new System.Drawing.Size(1255, 171);
            this.pnl_consulta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "De:";
            // 
            // dtime_dois
            // 
            this.dtime_dois.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_dois.Checked = false;
            this.dtime_dois.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_dois.Location = new System.Drawing.Point(648, 122);
            this.dtime_dois.Name = "dtime_dois";
            this.dtime_dois.ShowCheckBox = true;
            this.dtime_dois.ShowUpDown = true;
            this.dtime_dois.Size = new System.Drawing.Size(592, 39);
            this.dtime_dois.TabIndex = 7;
            this.dtime_dois.ValueChanged += new System.EventHandler(this.dtime_dois_ValueChanged);
            // 
            // dtime_um
            // 
            this.dtime_um.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_um.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_um.Location = new System.Drawing.Point(16, 122);
            this.dtime_um.Name = "dtime_um";
            this.dtime_um.ShowUpDown = true;
            this.dtime_um.Size = new System.Drawing.Size(574, 39);
            this.dtime_um.TabIndex = 6;
            this.dtime_um.ValueChanged += new System.EventHandler(this.dtime_um_ValueChanged);
            // 
            // lbl_consult_prod
            // 
            this.lbl_consult_prod.AutoSize = true;
            this.lbl_consult_prod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_consult_prod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consult_prod.Location = new System.Drawing.Point(12, 3);
            this.lbl_consult_prod.Name = "lbl_consult_prod";
            this.lbl_consult_prod.Size = new System.Drawing.Size(471, 65);
            this.lbl_consult_prod.TabIndex = 9;
            this.lbl_consult_prod.Text = "Filtro de Vendas";
            // 
            // VendaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.dtgrid_vendas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_consulta);
            this.Controls.Add(this.lbl_consult_prod);
            this.Name = "VendaConsultar";
            this.Text = "VendaConsultar";
            this.Load += new System.EventHandler(this.VendaConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_vendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_consulta.ResumeLayout(false);
            this.pnl_consulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn check_grid;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dtgrid_vendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_consulta;
        private System.Windows.Forms.Label lbl_consult_prod;
        private System.Windows.Forms.DateTimePicker dtime_um;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtime_dois;
    }
}