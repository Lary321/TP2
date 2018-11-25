using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TP2
{
    public partial class CadastroClienteForm : Form
    {
        private ArrayList cadastroCliente;
        int codCliente = 0;

        public CadastroClienteForm()
        {
            InitializeComponent();
            cadastroCliente = new ArrayList();
            telefoneTextBox.SelectionStart = 0;
            cepTextBox.SelectionStart = 0;
            CPFTextBox.SelectionStart = 0;
            CNPJTextBox.SelectionStart = 0;
        }

        private void CadastroClienteForm_Load(object sender, EventArgs e)
        {
            codCliente++;
            labelCodigoCliente.Text = codCliente.ToString();
        }

        private void pessoaFisicaRadio_CheckedChanged(object sender, EventArgs e)
        {
            CPFTextBox.Visible = true;
            CNPJTextBox.Visible = false;
        }

        private void pessoaJuridicaRadio_CheckedChanged(object sender, EventArgs e)
        {
            CPFTextBox.Visible = false;
            CNPJTextBox.Visible = true;
        }


        private void gravarClienteButton_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.codigoCliente = int.Parse(labelCodigoCliente.Text);
            c.nomeCliente = nomeTextBox.Text;
            c.telefone = telefoneTextBox.Text;
            c.logradouro = logradouroTextBox.Text;
            c.numero = int.Parse(numeroTextBox.Text);
            c.bairro = bairroTextBox.Text;
            c.municipio = municipioTextBox.Text;
            c.estado = estadoTextBox.Text;
            c.cep = cepTextBox.Text;            
            if (pessoaFisicaRadio.Checked == true)
            {
                c.CPF_CNPJ = CPFTextBox.Text;
            }
            else
            {
                c.CPF_CNPJ = CNPJTextBox.Text;
            }

            c.cadastrarCliente(c);

            MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja cadastrar outro cliente?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                codCliente++;
                labelCodigoCliente.Text = codCliente.ToString();
                nomeTextBox.Text = string.Empty;
                telefoneTextBox.Text = string.Empty;
                CPFTextBox.Text = string.Empty;
                CNPJTextBox.Text = string.Empty;
                cepTextBox.Text = string.Empty;
                logradouroTextBox.Text = string.Empty;
                municipioTextBox.Text = string.Empty;
                numeroTextBox.Text = string.Empty;
                bairroTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                cepTextBox.Text = string.Empty;
            }
            else
            {
                Close();
            }
        }

        private void fecharClienteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar suas alterações?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                ClienteForm clienteForm = new ClienteForm();
                clienteForm.StartPosition = FormStartPosition.CenterScreen;
                clienteForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                clienteForm.ControlBox = true;
                clienteForm.ShowDialog();
            }
        }

        private void CNPJTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            CNPJTextBox.SelectionStart = 0;
        }

        private void CPFTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            CPFTextBox.SelectionStart = 0;
        }

        private void telefoneTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            telefoneTextBox.SelectionStart = 0;
        }

        private void cepTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            cepTextBox.SelectionStart = 0;
        }
    }
}
