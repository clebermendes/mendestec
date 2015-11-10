namespace Varejo_Tec
{
    partial class Principal
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
            this.lbl_txt_principal = new System.Windows.Forms.Label();
            this.lbl_nome_user1 = new System.Windows.Forms.Label();
            this.lbl_nome_user = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.Label();
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_txt_principal
            // 
            this.lbl_txt_principal.AutoSize = true;
            this.lbl_txt_principal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_txt_principal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_principal.Location = new System.Drawing.Point(12, 9);
            this.lbl_txt_principal.Name = "lbl_txt_principal";
            this.lbl_txt_principal.Size = new System.Drawing.Size(545, 75);
            this.lbl_txt_principal.TabIndex = 3;
            this.lbl_txt_principal.Text = "Tela de Controle";
            // 
            // lbl_nome_user1
            // 
            this.lbl_nome_user1.AutoSize = true;
            this.lbl_nome_user1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome_user1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_user1.Location = new System.Drawing.Point(641, 9);
            this.lbl_nome_user1.Name = "lbl_nome_user1";
            this.lbl_nome_user1.Size = new System.Drawing.Size(297, 75);
            this.lbl_nome_user1.TabIndex = 4;
            this.lbl_nome_user1.Text = "Usuário:";
            // 
            // lbl_nome_user
            // 
            this.lbl_nome_user.AutoSize = true;
            this.lbl_nome_user.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_user.Location = new System.Drawing.Point(1027, 9);
            this.lbl_nome_user.Name = "lbl_nome_user";
            this.lbl_nome_user.Size = new System.Drawing.Size(240, 75);
            this.lbl_nome_user.TabIndex = 5;
            this.lbl_nome_user.Text = "Cleber";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_fornecedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Produto);
            this.panel1.Controls.Add(this.btn_produto);
            this.panel1.Controls.Add(this.btn_historico);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 244);
            this.panel1.TabIndex = 6;
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.Image = global::Varejo_Tec.Properties.Resources.fornecedor;
            this.btn_fornecedor.Location = new System.Drawing.Point(738, 73);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(130, 129);
            this.btn_fornecedor.TabIndex = 5;
            this.btn_fornecedor.UseVisualStyleBackColor = true;
            this.btn_fornecedor.Click += new System.EventHandler(this.btn_fornecedor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vendas";
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produto.Location = new System.Drawing.Point(31, 15);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(211, 55);
            this.Produto.TabIndex = 2;
            this.Produto.Text = "Produto";
            // 
            // btn_produto
            // 
            this.btn_produto.Image = global::Varejo_Tec.Properties.Resources.produto;
            this.btn_produto.Location = new System.Drawing.Point(71, 73);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(130, 129);
            this.btn_produto.TabIndex = 0;
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.Image = global::Varejo_Tec.Properties.Resources.historico;
            this.btn_historico.Location = new System.Drawing.Point(380, 73);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(130, 129);
            this.btn_historico.TabIndex = 1;
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Image = global::Varejo_Tec.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(1137, 557);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(130, 129);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_nome_user);
            this.Controls.Add(this.lbl_nome_user1);
            this.Controls.Add(this.lbl_txt_principal);
            this.Controls.Add(this.btn_sair);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_txt_principal;
        private System.Windows.Forms.Label lbl_nome_user1;
        private System.Windows.Forms.Label lbl_nome_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Button btn_fornecedor;
    }
}