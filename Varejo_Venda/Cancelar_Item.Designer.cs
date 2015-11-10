namespace Varejo_Venda
{
    partial class Cancelar_Item
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Image = global::Varejo_Venda.Properties.Resources.cancel_small;
            this.btn_cancel.Location = new System.Drawing.Point(11, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 71);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aplicar.Image = global::Varejo_Venda.Properties.Resources.ok_small;
            this.btn_aplicar.Location = new System.Drawing.Point(364, 276);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(73, 71);
            this.btn_aplicar.TabIndex = 2;
            this.btn_aplicar.UseVisualStyleBackColor = false;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // txt_produto
            // 
            this.txt_produto.Font = new System.Drawing.Font("Norwester", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(21, 179);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(403, 46);
            this.txt_produto.TabIndex = 4;
            this.txt_produto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_produto_KeyUp);
            // 
            // Cancelar_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Varejo_Venda.Properties.Resources.item_cancelar;
            this.ClientSize = new System.Drawing.Size(449, 359);
            this.ControlBox = false;
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_aplicar);
            this.Name = "Cancelar_Item";
            this.Text = "Cancelar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.TextBox txt_produto;
    }
}