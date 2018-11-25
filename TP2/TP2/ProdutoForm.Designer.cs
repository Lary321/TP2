namespace TP2
{
    partial class ProdutoForm
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
            this.incluirProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incluirProduto
            // 
            this.incluirProduto.Location = new System.Drawing.Point(847, 576);
            this.incluirProduto.Name = "incluirProduto";
            this.incluirProduto.Size = new System.Drawing.Size(75, 23);
            this.incluirProduto.TabIndex = 0;
            this.incluirProduto.Text = "Incluir";
            this.incluirProduto.UseVisualStyleBackColor = true;
            // 
            // ProdServForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.incluirProduto);
            this.Name = "ProdServForm";
            this.Text = "ProdServForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button incluirProduto;
    }
}