namespace Varejo_Tec
{
    partial class Login
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
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.Panel_bkgr_login = new System.Windows.Forms.Panel();
            this.lbl_text = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.Panel_bkgr_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Limpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(59, 250);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(122, 39);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Entrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(220, 250);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(122, 39);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(172, 197);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(170, 32);
            this.txt_senha.TabIndex = 3;
            // 
            // Panel_bkgr_login
            // 
            this.Panel_bkgr_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_bkgr_login.Controls.Add(this.lbl_text);
            this.Panel_bkgr_login.Controls.Add(this.txt_Login);
            this.Panel_bkgr_login.Controls.Add(this.label1);
            this.Panel_bkgr_login.Controls.Add(this.lbl_senha);
            this.Panel_bkgr_login.Controls.Add(this.txt_senha);
            this.Panel_bkgr_login.Controls.Add(this.Btn_Limpar);
            this.Panel_bkgr_login.Controls.Add(this.btn_Entrar);
            this.Panel_bkgr_login.Location = new System.Drawing.Point(443, 145);
            this.Panel_bkgr_login.Name = "Panel_bkgr_login";
            this.Panel_bkgr_login.Size = new System.Drawing.Size(410, 321);
            this.Panel_bkgr_login.TabIndex = 0;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(140, 34);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(118, 43);
            this.lbl_text.TabIndex = 6;
            this.lbl_text.Text = "Login";
            // 
            // txt_Login
            // 
            this.txt_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.Location = new System.Drawing.Point(172, 142);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(170, 32);
            this.txt_Login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(72, 205);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(81, 24);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 698);
            this.Controls.Add(this.Panel_bkgr_login);
            this.Name = "Login";
            this.Text = "Mendes Varejo";
            this.Panel_bkgr_login.ResumeLayout(false);
            this.Panel_bkgr_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Panel Panel_bkgr_login;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_senha;
    }
}

