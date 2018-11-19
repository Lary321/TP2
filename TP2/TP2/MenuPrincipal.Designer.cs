namespace TP2
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.clienteButton = new System.Windows.Forms.Button();
            this.prodServButton = new System.Windows.Forms.Button();
            this.receitasButton = new System.Windows.Forms.Button();
            this.relatoriosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clienteButton
            // 
            this.clienteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clienteButton.BackgroundImage")));
            this.clienteButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteButton.Location = new System.Drawing.Point(127, 59);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Size = new System.Drawing.Size(215, 100);
            this.clienteButton.TabIndex = 1;
            this.clienteButton.Text = "Clientes";
            this.clienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clienteButton.UseVisualStyleBackColor = true;
            this.clienteButton.Click += new System.EventHandler(this.clienteButton_Click);
            // 
            // prodServButton
            // 
            this.prodServButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prodServButton.BackgroundImage")));
            this.prodServButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodServButton.Location = new System.Drawing.Point(127, 188);
            this.prodServButton.Name = "prodServButton";
            this.prodServButton.Size = new System.Drawing.Size(215, 100);
            this.prodServButton.TabIndex = 2;
            this.prodServButton.Text = "Produtos\r\ne Serviços";
            this.prodServButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prodServButton.UseVisualStyleBackColor = true;
            this.prodServButton.Click += new System.EventHandler(this.prodServButton_Click);
            // 
            // receitasButton
            // 
            this.receitasButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("receitasButton.BackgroundImage")));
            this.receitasButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receitasButton.Location = new System.Drawing.Point(127, 321);
            this.receitasButton.Name = "receitasButton";
            this.receitasButton.Size = new System.Drawing.Size(215, 100);
            this.receitasButton.TabIndex = 3;
            this.receitasButton.Text = "Receitas";
            this.receitasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.receitasButton.UseVisualStyleBackColor = true;
            this.receitasButton.Click += new System.EventHandler(this.receitasButton_Click);
            // 
            // relatoriosButton
            // 
            this.relatoriosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("relatoriosButton.BackgroundImage")));
            this.relatoriosButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosButton.Location = new System.Drawing.Point(127, 456);
            this.relatoriosButton.Name = "relatoriosButton";
            this.relatoriosButton.Size = new System.Drawing.Size(215, 100);
            this.relatoriosButton.TabIndex = 4;
            this.relatoriosButton.Text = "Relatórios";
            this.relatoriosButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.relatoriosButton.UseVisualStyleBackColor = true;
            this.relatoriosButton.Click += new System.EventHandler(this.relatoriosButton_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.relatoriosButton);
            this.Controls.Add(this.receitasButton);
            this.Controls.Add(this.prodServButton);
            this.Controls.Add(this.clienteButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "Sistema para controle de contas a receber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Button prodServButton;
        private System.Windows.Forms.Button receitasButton;
        private System.Windows.Forms.Button relatoriosButton;
    }
}

