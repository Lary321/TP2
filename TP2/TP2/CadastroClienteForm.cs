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
using System.Xml.Serialization;

namespace TP2
{
    public partial class CadastroClienteForm : Form
    {
        private ArrayList cadastroCliente;

        public CadastroClienteForm()
        {
            InitializeComponent();
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

        public void cadastraCliente(Cliente c)
        {
            c = new Cliente();
            c.codigoCliente = int.Parse(codigoClienteLabel.Text);
            c.nomeCliente = nomeTextBox.Text;
            c.telefone = telefoneTextBox.Text;
            if (pessoaFisicaRadio.Checked == true)
            {
                c.CPF_CNPJ = CPFTextBox.Text;
            }
            else
            {
                c.CPF_CNPJ = CNPJTextBox.Text;
            }
            c.logradouro = logradouroTextBox.Text;
            c.numero = int.Parse(numeroTextBox.Text);
            c.municipio = municipioTextBox.Text;
            c.cep = cepTextBox.Text;

            cadastroCliente.Add(c);
        }

        public void salvarClienteXML()
        {
            TextWriter meuWriter = new StreamWriter(@"TP2\bin\Debug\Clientes.XML");
            Cliente[] listaClientes = (Cliente[])cadastroCliente.ToArray(typeof(Cliente));
            XmlSerializer serializador = new XmlSerializer(listaClientes.GetType());

            serializador.Serialize(meuWriter, listaClientes);

            meuWriter.Close();
        }

    }
}
