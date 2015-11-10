namespace Varejo_Tec
{
    partial class TipoCadastrar
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
            this.lbl_txt_produto = new System.Windows.Forms.Label();
            this.btn_sair_cadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_txt_produto
            // 
            this.lbl_txt_produto.AutoSize = true;
            this.lbl_txt_produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_txt_produto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_produto.Location = new System.Drawing.Point(12, 9);
            this.lbl_txt_produto.Name = "lbl_txt_produto";
            this.lbl_txt_produto.Size = new System.Drawing.Size(601, 75);
            this.lbl_txt_produto.TabIndex = 7;
            this.lbl_txt_produto.Text = "Cadastro de Tipos";
            // 
            // btn_sair_cadastro
            // 
            this.btn_sair_cadastro.Image = global::Varejo_Tec.Properties.Resources.sair;
            this.btn_sair_cadastro.Location = new System.Drawing.Point(1133, 7);
            this.btn_sair_cadastro.Name = "btn_sair_cadastro";
            this.btn_sair_cadastro.Size = new System.Drawing.Size(134, 116);
            this.btn_sair_cadastro.TabIndex = 8;
            this.btn_sair_cadastro.UseVisualStyleBackColor = true;
            this.btn_sair_cadastro.Click += new System.EventHandler(this.btn_sair_cadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_descricao);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 259);
            this.panel1.TabIndex = 28;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok.Image = global::Varejo_Tec.Properties.Resources.ok;
            this.btn_ok.Location = new System.Drawing.Point(1116, 118);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(128, 123);
            this.btn_ok.TabIndex = 29;
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpar.Image = global::Varejo_Tec.Properties.Resources.trash;
            this.btn_limpar.Location = new System.Drawing.Point(965, 118);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(128, 123);
            this.btn_limpar.TabIndex = 30;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.txt_codigo.Location = new System.Drawing.Point(24, 55);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(351, 41);
            this.txt_codigo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.txt_descricao.Location = new System.Drawing.Point(406, 55);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(838, 41);
            this.txt_descricao.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 33);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descrição:";
            // 
            // TipoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sair_cadastro);
            this.Controls.Add(this.lbl_txt_produto);
            this.Name = "TipoCadastrar";
            this.Text = "TipoCadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair_cadastro;
        private System.Windows.Forms.Label lbl_txt_produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label8;
    }
}