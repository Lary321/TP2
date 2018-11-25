namespace TP2
{
    partial class CadastroProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutoForm));
            this.labelCodigoProduto = new System.Windows.Forms.Label();
            this.descProdutoTextBox = new System.Windows.Forms.TextBox();
            this.dadosLabel = new System.Windows.Forms.Label();
            this.descricaoProdutoLabel = new System.Windows.Forms.Label();
            this.codigoProdutoLabel = new System.Windows.Forms.Label();
            this.valorProdutoTextBox = new System.Windows.Forms.TextBox();
            this.valorProduto = new System.Windows.Forms.Label();
            this.fecharProdutoButton = new System.Windows.Forms.Button();
            this.gravarProdutoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigoProduto
            // 
            this.labelCodigoProduto.AutoSize = true;
            this.labelCodigoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.labelCodigoProduto.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProduto.Location = new System.Drawing.Point(153, 80);
            this.labelCodigoProduto.Name = "labelCodigoProduto";
            this.labelCodigoProduto.Size = new System.Drawing.Size(0, 23);
            this.labelCodigoProduto.TabIndex = 35;
            // 
            // descProdutoTextBox
            // 
            this.descProdutoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descProdutoTextBox.Location = new System.Drawing.Point(157, 133);
            this.descProdutoTextBox.Name = "descProdutoTextBox";
            this.descProdutoTextBox.Size = new System.Drawing.Size(377, 27);
            this.descProdutoTextBox.TabIndex = 1;
            // 
            // dadosLabel
            // 
            this.dadosLabel.AutoSize = true;
            this.dadosLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dadosLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosLabel.Location = new System.Drawing.Point(27, 32);
            this.dadosLabel.Name = "dadosLabel";
            this.dadosLabel.Size = new System.Drawing.Size(195, 29);
            this.dadosLabel.TabIndex = 34;
            this.dadosLabel.Text = "Dados do Produto";
            // 
            // descricaoProdutoLabel
            // 
            this.descricaoProdutoLabel.AutoSize = true;
            this.descricaoProdutoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoProdutoLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoLabel.Location = new System.Drawing.Point(54, 133);
            this.descricaoProdutoLabel.Name = "descricaoProdutoLabel";
            this.descricaoProdutoLabel.Size = new System.Drawing.Size(97, 23);
            this.descricaoProdutoLabel.TabIndex = 30;
            this.descricaoProdutoLabel.Text = "Descrição: ";
            // 
            // codigoProdutoLabel
            // 
            this.codigoProdutoLabel.AutoSize = true;
            this.codigoProdutoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.codigoProdutoLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoProdutoLabel.Location = new System.Drawing.Point(78, 80);
            this.codigoProdutoLabel.Name = "codigoProdutoLabel";
            this.codigoProdutoLabel.Size = new System.Drawing.Size(73, 23);
            this.codigoProdutoLabel.TabIndex = 28;
            this.codigoProdutoLabel.Text = "Código:";
            // 
            // valorProdutoTextBox
            // 
            this.valorProdutoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProdutoTextBox.Location = new System.Drawing.Point(157, 192);
            this.valorProdutoTextBox.Name = "valorProdutoTextBox";
            this.valorProdutoTextBox.Size = new System.Drawing.Size(77, 27);
            this.valorProdutoTextBox.TabIndex = 2;
            // 
            // valorProduto
            // 
            this.valorProduto.AutoSize = true;
            this.valorProduto.BackColor = System.Drawing.SystemColors.Window;
            this.valorProduto.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProduto.Location = new System.Drawing.Point(89, 192);
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.Size = new System.Drawing.Size(62, 23);
            this.valorProduto.TabIndex = 37;
            this.valorProduto.Text = "Valor: ";
            // 
            // fecharProdutoButton
            // 
            this.fecharProdutoButton.Location = new System.Drawing.Point(821, 563);
            this.fecharProdutoButton.Name = "fecharProdutoButton";
            this.fecharProdutoButton.Size = new System.Drawing.Size(95, 36);
            this.fecharProdutoButton.TabIndex = 4;
            this.fecharProdutoButton.Text = "Fechar";
            this.fecharProdutoButton.UseVisualStyleBackColor = true;
            this.fecharProdutoButton.Click += new System.EventHandler(this.fecharProdutoButton_Click);
            // 
            // gravarProdutoButton
            // 
            this.gravarProdutoButton.Location = new System.Drawing.Point(706, 563);
            this.gravarProdutoButton.Name = "gravarProdutoButton";
            this.gravarProdutoButton.Size = new System.Drawing.Size(95, 36);
            this.gravarProdutoButton.TabIndex = 3;
            this.gravarProdutoButton.Text = "Gravar";
            this.gravarProdutoButton.UseVisualStyleBackColor = true;
            this.gravarProdutoButton.Click += new System.EventHandler(this.gravarProdutoButton_Click);
            // 
            // CadastroProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.fecharProdutoButton);
            this.Controls.Add(this.gravarProdutoButton);
            this.Controls.Add(this.valorProdutoTextBox);
            this.Controls.Add(this.valorProduto);
            this.Controls.Add(this.labelCodigoProduto);
            this.Controls.Add(this.descProdutoTextBox);
            this.Controls.Add(this.dadosLabel);
            this.Controls.Add(this.descricaoProdutoLabel);
            this.Controls.Add(this.codigoProdutoLabel);
            this.Name = "CadastroProdutoForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CadastroProdutoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoProduto;
        private System.Windows.Forms.TextBox descProdutoTextBox;
        private System.Windows.Forms.Label dadosLabel;
        private System.Windows.Forms.Label descricaoProdutoLabel;
        private System.Windows.Forms.Label codigoProdutoLabel;
        private System.Windows.Forms.TextBox valorProdutoTextBox;
        private System.Windows.Forms.Label valorProduto;
        private System.Windows.Forms.Button fecharProdutoButton;
        private System.Windows.Forms.Button gravarProdutoButton;
    }
}