namespace Varejo_Venda
{
    partial class Adicionar_Valor
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
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Image = global::Varejo_Venda.Properties.Resources.ok_small;
            this.btn_aplicar.Location = new System.Drawing.Point(356, 271);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(73, 71);
            this.btn_aplicar.TabIndex = 1;
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Varejo_Venda.Properties.Resources.cancel_small;
            this.btn_cancel.Location = new System.Drawing.Point(12, 271);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 71);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.SeaShell;
            this.txt_valor.Font = new System.Drawing.Font("Norwester", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(200, 167);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(219, 49);
            this.txt_valor.TabIndex = 3;
            // 
            // Adicionar_Valor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Varejo_Venda.Properties.Resources.valor_receber;
            this.ClientSize = new System.Drawing.Size(451, 354);
            this.ControlBox = false;
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_aplicar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adicionar_Valor";
            this.Text = "Troco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_valor;
    }
}