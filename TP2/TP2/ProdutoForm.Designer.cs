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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.incluirProduto = new System.Windows.Forms.Button();
            this.gridViewProdutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoProdutoLabel = new System.Windows.Forms.Label();
            this.excluirCliente = new System.Windows.Forms.Button();
            this.filtrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
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
            this.incluirProduto.Click += new System.EventHandler(this.incluirProduto_Click);
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.valor});
            this.gridViewProdutos.Location = new System.Drawing.Point(-2, 118);
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.Size = new System.Drawing.Size(938, 443);
            this.gridViewProdutos.TabIndex = 26;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.descricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.descricao.Frozen = true;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.valor.Frozen = true;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(129, 40);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(377, 27);
            this.descricaoTextBox.TabIndex = 18;
            // 
            // descricaoProdutoLabel
            // 
            this.descricaoProdutoLabel.AutoSize = true;
            this.descricaoProdutoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoProdutoLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoLabel.Location = new System.Drawing.Point(30, 44);
            this.descricaoProdutoLabel.Name = "descricaoProdutoLabel";
            this.descricaoProdutoLabel.Size = new System.Drawing.Size(93, 23);
            this.descricaoProdutoLabel.TabIndex = 19;
            this.descricaoProdutoLabel.Text = "Descrição:";
            // 
            // excluirCliente
            // 
            this.excluirCliente.Location = new System.Drawing.Point(12, 576);
            this.excluirCliente.Name = "excluirCliente";
            this.excluirCliente.Size = new System.Drawing.Size(75, 23);
            this.excluirCliente.TabIndex = 17;
            this.excluirCliente.Text = "Excluir";
            this.excluirCliente.UseVisualStyleBackColor = true;
            // 
            // filtrarCliente
            // 
            this.filtrarCliente.Location = new System.Drawing.Point(834, 79);
            this.filtrarCliente.Name = "filtrarCliente";
            this.filtrarCliente.Size = new System.Drawing.Size(75, 23);
            this.filtrarCliente.TabIndex = 16;
            this.filtrarCliente.Text = "Filtrar";
            this.filtrarCliente.UseVisualStyleBackColor = true;
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.gridViewProdutos);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoProdutoLabel);
            this.Controls.Add(this.excluirCliente);
            this.Controls.Add(this.filtrarCliente);
            this.Controls.Add(this.incluirProduto);
            this.Name = "ProdutoForm";
            this.Text = "ProdServForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incluirProduto;
        private System.Windows.Forms.DataGridView gridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoProdutoLabel;
        private System.Windows.Forms.Button excluirCliente;
        private System.Windows.Forms.Button filtrarCliente;
    }
}