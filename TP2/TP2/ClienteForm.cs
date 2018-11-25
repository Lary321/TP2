using System;
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
using System.Xml.Linq;
using System.Collections;

namespace TP2
{
    public partial class ClienteForm : Form
    {
        List<Cliente> dadosCliente = new List<Cliente>();

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void incluirCliente_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroCliente = new CadastroClienteForm();
            cadastroCliente.StartPosition = FormStartPosition.CenterScreen;
            cadastroCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroCliente.ControlBox = true;
            cadastroCliente.ShowDialog();
        }

        private void excluirCliente_Click(object sender, EventArgs e)
        {
            if (gridViewClientes.SelectedRows.Count > 0)
            {
                int indice = gridViewClientes.SelectedRows[0].Index;
                Cliente.excluirCliente(dadosCliente[indice].Codigo);
                dadosCliente = Cliente.listarClientesSemFiltro();
                gridViewClientes.DataSource = dadosCliente;
            }
        }

        private void filtrarCliente_Click(object sender, EventArgs e)
        {
            string nome = "";

            nome = nomeFiltro.Text;

            if (nome == string.Empty)
            {
                dadosCliente = Cliente.listarClientesSemFiltro();
                gridViewClientes.DataSource = dadosCliente;
            }
            else
            {
                foreach (Cliente x in dadosCliente)
                {
                    if (x.Nome == nome)
                    {
                        dadosCliente = Cliente.listarClientesFiltro(x.Codigo);
                        gridViewClientes.DataSource = dadosCliente;
                    }
                }
            }
        }
    }
}

