namespace TP2
{
    partial class ClienteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.incluirCliente = new System.Windows.Forms.Button();
            this.filtrarCliente = new System.Windows.Forms.Button();
            this.excluirCliente = new System.Windows.Forms.Button();
            this.nomeFiltro = new System.Windows.Forms.TextBox();
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // incluirCliente
            // 
            this.incluirCliente.Location = new System.Drawing.Point(847, 576);
            this.incluirCliente.Name = "incluirCliente";
            this.incluirCliente.Size = new System.Drawing.Size(75, 23);
            this.incluirCliente.TabIndex = 1;
            this.incluirCliente.Text = "Incluir";
            this.incluirCliente.UseVisualStyleBackColor = true;
            this.incluirCliente.Click += new System.EventHandler(this.incluirCliente_Click);
            // 
            // filtrarCliente
            // 
            this.filtrarCliente.Location = new System.Drawing.Point(834, 88);
            this.filtrarCliente.Name = "filtrarCliente";
            this.filtrarCliente.Size = new System.Drawing.Size(75, 23);
            this.filtrarCliente.TabIndex = 3;
            this.filtrarCliente.Text = "Filtrar";
            this.filtrarCliente.UseVisualStyleBackColor = true;
            this.filtrarCliente.Click += new System.EventHandler(this.filtrarCliente_Click);
            // 
            // excluirCliente
            // 
            this.excluirCliente.Location = new System.Drawing.Point(29, 576);
            this.excluirCliente.Name = "excluirCliente";
            this.excluirCliente.Size = new System.Drawing.Size(75, 23);
            this.excluirCliente.TabIndex = 5;
            this.excluirCliente.Text = "Excluir";
            this.excluirCliente.UseVisualStyleBackColor = true;
            // 
            // nomeFiltro
            // 
            this.nomeFiltro.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFiltro.Location = new System.Drawing.Point(92, 67);
            this.nomeFiltro.Name = "nomeFiltro";
            this.nomeFiltro.Size = new System.Drawing.Size(377, 27);
            this.nomeFiltro.TabIndex = 6;
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteLabel.Location = new System.Drawing.Point(21, 67);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(65, 23);
            this.nomeClienteLabel.TabIndex = 7;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // gridViewClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.telefone,
            this.cpfcnpj,
            this.Logradouro,
            this.Numero,
            this.Bairro,
            this.Municipio,
            this.Estado,
            this.Cep});
            this.gridViewClientes.Location = new System.Drawing.Point(-2, 127);
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.Size = new System.Drawing.Size(938, 443);
            this.gridViewClientes.TabIndex = 14;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.nome.Frozen = true;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle5;
            this.telefone.Frozen = true;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.DataPropertyName = "CPFCNPJ";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.cpfcnpj.DefaultCellStyle = dataGridViewCellStyle6;
            this.cpfcnpj.Frozen = true;
            this.cpfcnpj.HeaderText = "CPF/CNPJ";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.ReadOnly = true;
            this.cpfcnpj.Width = 200;
            // 
            // Logradouro
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Logradouro.DefaultCellStyle = dataGridViewCellStyle7;
            this.Logradouro.Frozen = true;
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            this.Logradouro.Width = 210;
            // 
            // Numero
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle8;
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Bairro
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Bairro.DefaultCellStyle = dataGridViewCellStyle9;
            this.Bairro.Frozen = true;
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Municipio
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Municipio.DefaultCellStyle = dataGridViewCellStyle10;
            this.Municipio.Frozen = true;
            this.Municipio.HeaderText = "Município";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            // 
            // Estado
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle11;
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cep
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Cep.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cep.Frozen = true;
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.gridViewClientes);
            this.Controls.Add(this.nomeFiltro);
            this.Controls.Add(this.nomeClienteLabel);
            this.Controls.Add(this.excluirCliente);
            this.Controls.Add(this.filtrarCliente);
            this.Controls.Add(this.incluirCliente);
            this.Controls.Add(this.label1);
            this.Name = "ClienteForm";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button incluirCliente;
        private System.Windows.Forms.Button filtrarCliente;
        private System.Windows.Forms.Button excluirCliente;
        private System.Windows.Forms.TextBox nomeFiltro;
        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.DataGridView gridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
    }
}