namespace TP2
{
    partial class CadastroClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClienteForm));
            this.codigoClienteLabel = new System.Windows.Forms.Label();
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.CPFCNPJLabel = new System.Windows.Forms.Label();
            this.tpPessoaLabel = new System.Windows.Forms.Label();
            this.logradouroLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.CEPLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.dadosLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.municipioLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.pessoaFisicaRadio = new System.Windows.Forms.RadioButton();
            this.pessoaJuridicaRadio = new System.Windows.Forms.RadioButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.CPFTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CNPJTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.municipioTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gravarClienteButton = new System.Windows.Forms.Button();
            this.fecharClienteButton = new System.Windows.Forms.Button();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codigoClienteLabel
            // 
            this.codigoClienteLabel.AutoSize = true;
            this.codigoClienteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.codigoClienteLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoClienteLabel.Location = new System.Drawing.Point(63, 70);
            this.codigoClienteLabel.Name = "codigoClienteLabel";
            this.codigoClienteLabel.Size = new System.Drawing.Size(73, 23);
            this.codigoClienteLabel.TabIndex = 0;
            this.codigoClienteLabel.Text = "Código:";
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteLabel.Location = new System.Drawing.Point(71, 123);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(65, 23);
            this.nomeClienteLabel.TabIndex = 1;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // CPFCNPJLabel
            // 
            this.CPFCNPJLabel.AutoSize = true;
            this.CPFCNPJLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CPFCNPJLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFCNPJLabel.Location = new System.Drawing.Point(43, 236);
            this.CPFCNPJLabel.Name = "CPFCNPJLabel";
            this.CPFCNPJLabel.Size = new System.Drawing.Size(93, 23);
            this.CPFCNPJLabel.TabIndex = 2;
            this.CPFCNPJLabel.Text = "CPF/CNPJ:";
            // 
            // tpPessoaLabel
            // 
            this.tpPessoaLabel.AutoSize = true;
            this.tpPessoaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tpPessoaLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPessoaLabel.Location = new System.Drawing.Point(35, 179);
            this.tpPessoaLabel.Name = "tpPessoaLabel";
            this.tpPessoaLabel.Size = new System.Drawing.Size(101, 23);
            this.tpPessoaLabel.TabIndex = 4;
            this.tpPessoaLabel.Text = "Tp. Pessoa:";
            // 
            // logradouroLabel
            // 
            this.logradouroLabel.AutoSize = true;
            this.logradouroLabel.BackColor = System.Drawing.SystemColors.Window;
            this.logradouroLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logradouroLabel.Location = new System.Drawing.Point(26, 397);
            this.logradouroLabel.Name = "logradouroLabel";
            this.logradouroLabel.Size = new System.Drawing.Size(110, 23);
            this.logradouroLabel.TabIndex = 5;
            this.logradouroLabel.Text = "Logradouro:";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.BackColor = System.Drawing.SystemColors.Window;
            this.numeroLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLabel.Location = new System.Drawing.Point(392, 397);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(82, 23);
            this.numeroLabel.TabIndex = 6;
            this.numeroLabel.Text = "Número:";
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.BackColor = System.Drawing.SystemColors.Window;
            this.bairroLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroLabel.Location = new System.Drawing.Point(71, 463);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(65, 23);
            this.bairroLabel.TabIndex = 7;
            this.bairroLabel.Text = "Bairro:";
            // 
            // CEPLabel
            // 
            this.CEPLabel.AutoSize = true;
            this.CEPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CEPLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPLabel.Location = new System.Drawing.Point(427, 463);
            this.CEPLabel.Name = "CEPLabel";
            this.CEPLabel.Size = new System.Drawing.Size(47, 23);
            this.CEPLabel.TabIndex = 8;
            this.CEPLabel.Text = "CEP:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enderecoLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoLabel.Location = new System.Drawing.Point(12, 339);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(109, 29);
            this.enderecoLabel.TabIndex = 9;
            this.enderecoLabel.Text = "Endereço";
            // 
            // dadosLabel
            // 
            this.dadosLabel.AutoSize = true;
            this.dadosLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dadosLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosLabel.Location = new System.Drawing.Point(12, 22);
            this.dadosLabel.Name = "dadosLabel";
            this.dadosLabel.Size = new System.Drawing.Size(167, 29);
            this.dadosLabel.TabIndex = 10;
            this.dadosLabel.Text = "Dados Pessoais";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.estadoLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLabel.Location = new System.Drawing.Point(66, 535);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(70, 23);
            this.estadoLabel.TabIndex = 11;
            this.estadoLabel.Text = "Estado:";
            // 
            // municipioLabel
            // 
            this.municipioLabel.AutoSize = true;
            this.municipioLabel.BackColor = System.Drawing.SystemColors.Window;
            this.municipioLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipioLabel.Location = new System.Drawing.Point(304, 535);
            this.municipioLabel.Name = "municipioLabel";
            this.municipioLabel.Size = new System.Drawing.Size(96, 23);
            this.municipioLabel.TabIndex = 12;
            this.municipioLabel.Text = "Município:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(142, 123);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(377, 27);
            this.nomeTextBox.TabIndex = 1;
            // 
            // pessoaFisicaRadio
            // 
            this.pessoaFisicaRadio.AutoSize = true;
            this.pessoaFisicaRadio.BackColor = System.Drawing.SystemColors.Window;
            this.pessoaFisicaRadio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisicaRadio.Location = new System.Drawing.Point(142, 177);
            this.pessoaFisicaRadio.Name = "pessoaFisicaRadio";
            this.pessoaFisicaRadio.Size = new System.Drawing.Size(72, 27);
            this.pessoaFisicaRadio.TabIndex = 2;
            this.pessoaFisicaRadio.TabStop = true;
            this.pessoaFisicaRadio.Text = "Física";
            this.pessoaFisicaRadio.UseVisualStyleBackColor = false;
            this.pessoaFisicaRadio.CheckedChanged += new System.EventHandler(this.pessoaFisicaRadio_CheckedChanged);
            // 
            // pessoaJuridicaRadio
            // 
            this.pessoaJuridicaRadio.AutoSize = true;
            this.pessoaJuridicaRadio.BackColor = System.Drawing.SystemColors.Window;
            this.pessoaJuridicaRadio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridicaRadio.Location = new System.Drawing.Point(218, 178);
            this.pessoaJuridicaRadio.Name = "pessoaJuridicaRadio";
            this.pessoaJuridicaRadio.Size = new System.Drawing.Size(90, 27);
            this.pessoaJuridicaRadio.TabIndex = 3;
            this.pessoaJuridicaRadio.TabStop = true;
            this.pessoaJuridicaRadio.Text = "Jurídica";
            this.pessoaJuridicaRadio.UseVisualStyleBackColor = false;
            this.pessoaJuridicaRadio.CheckedChanged += new System.EventHandler(this.pessoaJuridicaRadio_CheckedChanged);
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.BackColor = System.Drawing.SystemColors.Window;
            this.telefoneLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLabel.Location = new System.Drawing.Point(49, 291);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(87, 23);
            this.telefoneLabel.TabIndex = 16;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPFTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFTextBox.Location = new System.Drawing.Point(142, 236);
            this.CPFTextBox.Mask = "000,000,000-00";
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(144, 20);
            this.CPFTextBox.TabIndex = 4;
            // 
            // CNPJTextBox
            // 
            this.CNPJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNPJTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJTextBox.Location = new System.Drawing.Point(142, 236);
            this.CNPJTextBox.Mask = "00,000,000/0000-00";
            this.CNPJTextBox.Name = "CNPJTextBox";
            this.CNPJTextBox.Size = new System.Drawing.Size(144, 19);
            this.CNPJTextBox.TabIndex = 4;
            this.CNPJTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CNPJTextBox_MouseClick);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefoneTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(142, 291);
            this.telefoneTextBox.Mask = "(00) 0000-0000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(144, 19);
            this.telefoneTextBox.TabIndex = 5;
            this.telefoneTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telefoneTextBox_MouseClick);
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logradouroTextBox.Location = new System.Drawing.Point(142, 397);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(227, 27);
            this.logradouroTextBox.TabIndex = 6;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(142, 463);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(227, 26);
            this.bairroTextBox.TabIndex = 8;
            // 
            // municipioTextBox
            // 
            this.municipioTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipioTextBox.Location = new System.Drawing.Point(406, 535);
            this.municipioTextBox.Name = "municipioTextBox";
            this.municipioTextBox.Size = new System.Drawing.Size(227, 26);
            this.municipioTextBox.TabIndex = 11;
            // 
            // cepTextBox
            // 
            this.cepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cepTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.Location = new System.Drawing.Point(480, 463);
            this.cepTextBox.Mask = "00000-000";
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(144, 19);
            this.cepTextBox.TabIndex = 9;
            this.cepTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cepTextBox_MouseClick);
            // 
            // gravarClienteButton
            // 
            this.gravarClienteButton.Location = new System.Drawing.Point(708, 563);
            this.gravarClienteButton.Name = "gravarClienteButton";
            this.gravarClienteButton.Size = new System.Drawing.Size(95, 36);
            this.gravarClienteButton.TabIndex = 12;
            this.gravarClienteButton.Text = "Gravar";
            this.gravarClienteButton.UseVisualStyleBackColor = true;
            this.gravarClienteButton.Click += new System.EventHandler(this.gravarClienteButton_Click);
            // 
            // fecharClienteButton
            // 
            this.fecharClienteButton.Location = new System.Drawing.Point(823, 563);
            this.fecharClienteButton.Name = "fecharClienteButton";
            this.fecharClienteButton.Size = new System.Drawing.Size(95, 36);
            this.fecharClienteButton.TabIndex = 13;
            this.fecharClienteButton.Text = "Fechar";
            this.fecharClienteButton.UseVisualStyleBackColor = true;
            this.fecharClienteButton.Click += new System.EventHandler(this.fecharClienteButton_Click);
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.Location = new System.Drawing.Point(138, 70);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(0, 23);
            this.labelCodigoCliente.TabIndex = 27;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTextBox.Location = new System.Drawing.Point(480, 393);
            this.numeroTextBox.Mask = "00000";
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(47, 26);
            this.numeroTextBox.TabIndex = 7;
            this.numeroTextBox.ValidatingType = typeof(int);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTextBox.Location = new System.Drawing.Point(142, 535);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(46, 26);
            this.estadoTextBox.TabIndex = 10;
            // 
            // CadastroClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.fecharClienteButton);
            this.Controls.Add(this.gravarClienteButton);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(this.municipioTextBox);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.CNPJTextBox);
            this.Controls.Add(this.CPFTextBox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.pessoaJuridicaRadio);
            this.Controls.Add(this.pessoaFisicaRadio);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.municipioLabel);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.dadosLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.CEPLabel);
            this.Controls.Add(this.bairroLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.logradouroLabel);
            this.Controls.Add(this.tpPessoaLabel);
            this.Controls.Add(this.CPFCNPJLabel);
            this.Controls.Add(this.nomeClienteLabel);
            this.Controls.Add(this.codigoClienteLabel);
            this.Name = "CadastroClienteForm";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoClienteLabel;
        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.Label CPFCNPJLabel;
        private System.Windows.Forms.Label tpPessoaLabel;
        private System.Windows.Forms.Label logradouroLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.Label CEPLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label dadosLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label municipioLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.RadioButton pessoaFisicaRadio;
        private System.Windows.Forms.RadioButton pessoaJuridicaRadio;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.MaskedTextBox CPFTextBox;
        private System.Windows.Forms.MaskedTextBox CNPJTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox municipioTextBox;
        private System.Windows.Forms.MaskedTextBox cepTextBox;
        private System.Windows.Forms.Button gravarClienteButton;
        private System.Windows.Forms.Button fecharClienteButton;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.MaskedTextBox numeroTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
    }
}