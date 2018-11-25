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
            this.label1 = new System.Windows.Forms.Label();
            this.incluirCliente = new System.Windows.Forms.Button();
            this.filtrarCliente = new System.Windows.Forms.Button();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.excluirCliente = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.CNPJTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CPFTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pessoaJuridicaRadio = new System.Windows.Forms.RadioButton();
            this.pessoaFisicaRadio = new System.Windows.Forms.RadioButton();
            this.tpPessoaLabel = new System.Windows.Forms.Label();
            this.CPFCNPJLabel = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.telefone,
            this.cpfcnpj});
            this.gridViewClientes.Location = new System.Drawing.Point(-1, 128);
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.ReadOnly = true;
            this.gridViewClientes.Size = new System.Drawing.Size(941, 421);
            this.gridViewClientes.TabIndex = 4;
            // 
            // excluirCliente
            // 
            this.excluirCliente.Location = new System.Drawing.Point(29, 576);
            this.excluirCliente.Name = "excluirCliente";
            this.excluirCliente.Size = new System.Drawing.Size(75, 23);
            this.excluirCliente.TabIndex = 5;
            this.excluirCliente.Text = "Excluir";
            this.excluirCliente.UseVisualStyleBackColor = true;
            this.excluirCliente.Click += new System.EventHandler(this.excluirCliente_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(134, 29);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(377, 27);
            this.nomeTextBox.TabIndex = 6;
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteLabel.Location = new System.Drawing.Point(63, 29);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(65, 23);
            this.nomeClienteLabel.TabIndex = 7;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // CNPJTextBox
            // 
            this.CNPJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNPJTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJTextBox.Location = new System.Drawing.Point(462, 88);
            this.CNPJTextBox.Mask = "00.000.000/0000-00";
            this.CNPJTextBox.Name = "CNPJTextBox";
            this.CNPJTextBox.Size = new System.Drawing.Size(144, 19);
            this.CNPJTextBox.TabIndex = 11;
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPFTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFTextBox.Location = new System.Drawing.Point(462, 87);
            this.CPFTextBox.Mask = "000.000.000-00";
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(144, 20);
            this.CPFTextBox.TabIndex = 12;
            // 
            // pessoaJuridicaRadio
            // 
            this.pessoaJuridicaRadio.AutoSize = true;
            this.pessoaJuridicaRadio.BackColor = System.Drawing.SystemColors.Window;
            this.pessoaJuridicaRadio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridicaRadio.Location = new System.Drawing.Point(210, 85);
            this.pessoaJuridicaRadio.Name = "pessoaJuridicaRadio";
            this.pessoaJuridicaRadio.Size = new System.Drawing.Size(90, 27);
            this.pessoaJuridicaRadio.TabIndex = 10;
            this.pessoaJuridicaRadio.TabStop = true;
            this.pessoaJuridicaRadio.Text = "Jurídica";
            this.pessoaJuridicaRadio.UseVisualStyleBackColor = false;
            // 
            // pessoaFisicaRadio
            // 
            this.pessoaFisicaRadio.AutoSize = true;
            this.pessoaFisicaRadio.BackColor = System.Drawing.SystemColors.Window;
            this.pessoaFisicaRadio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisicaRadio.Location = new System.Drawing.Point(134, 84);
            this.pessoaFisicaRadio.Name = "pessoaFisicaRadio";
            this.pessoaFisicaRadio.Size = new System.Drawing.Size(72, 27);
            this.pessoaFisicaRadio.TabIndex = 8;
            this.pessoaFisicaRadio.TabStop = true;
            this.pessoaFisicaRadio.Text = "Física";
            this.pessoaFisicaRadio.UseVisualStyleBackColor = false;
            // 
            // tpPessoaLabel
            // 
            this.tpPessoaLabel.AutoSize = true;
            this.tpPessoaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tpPessoaLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPessoaLabel.Location = new System.Drawing.Point(27, 86);
            this.tpPessoaLabel.Name = "tpPessoaLabel";
            this.tpPessoaLabel.Size = new System.Drawing.Size(101, 23);
            this.tpPessoaLabel.TabIndex = 13;
            this.tpPessoaLabel.Text = "Tp. Pessoa:";
            // 
            // CPFCNPJLabel
            // 
            this.CPFCNPJLabel.AutoSize = true;
            this.CPFCNPJLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CPFCNPJLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFCNPJLabel.Location = new System.Drawing.Point(363, 84);
            this.CPFCNPJLabel.Name = "CPFCNPJLabel";
            this.CPFCNPJLabel.Size = new System.Drawing.Size(93, 23);
            this.CPFCNPJLabel.TabIndex = 9;
            this.CPFCNPJLabel.Text = "CPF/CNPJ:";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome.Frozen = true;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle3;
            this.telefone.Frozen = true;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cpfcnpj
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.cpfcnpj.DefaultCellStyle = dataGridViewCellStyle4;
            this.cpfcnpj.Frozen = true;
            this.cpfcnpj.HeaderText = "CPF/CNPJ";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.ReadOnly = true;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.CNPJTextBox);
            this.Controls.Add(this.CPFTextBox);
            this.Controls.Add(this.pessoaJuridicaRadio);
            this.Controls.Add(this.pessoaFisicaRadio);
            this.Controls.Add(this.tpPessoaLabel);
            this.Controls.Add(this.CPFCNPJLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeClienteLabel);
            this.Controls.Add(this.excluirCliente);
            this.Controls.Add(this.gridViewClientes);
            this.Controls.Add(this.filtrarCliente);
            this.Controls.Add(this.incluirCliente);
            this.Controls.Add(this.label1);
            this.Name = "ClienteForm";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button incluirCliente;
        private System.Windows.Forms.Button filtrarCliente;
        private System.Windows.Forms.DataGridView gridViewClientes;
        private System.Windows.Forms.Button excluirCliente;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.MaskedTextBox CNPJTextBox;
        private System.Windows.Forms.MaskedTextBox CPFTextBox;
        private System.Windows.Forms.RadioButton pessoaJuridicaRadio;
        private System.Windows.Forms.RadioButton pessoaFisicaRadio;
        private System.Windows.Forms.Label tpPessoaLabel;
        private System.Windows.Forms.Label CPFCNPJLabel;
    }
}