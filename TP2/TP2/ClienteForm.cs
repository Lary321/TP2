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
        List<Cliente> dadosCliente;

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            dadosCliente = Cliente.listarClientes();
            gridViewClientes.DataSource = dadosCliente;
        }

        private void incluirCliente_Click(object sender, EventArgs e)
        {
            Close();
            CadastroClienteForm cadastroCliente = new CadastroClienteForm();
            cadastroCliente.StartPosition = FormStartPosition.CenterScreen;
            cadastroCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroCliente.ControlBox = true;
            cadastroCliente.ShowDialog();
        }

        private void excluirCliente_Click(object sender, EventArgs e)
        {
            dadosCliente = Cliente.listarClientes();

            if (gridViewClientes.SelectedRows.Count > 0)
            {
                int indice = gridViewClientes.SelectedRows[0].Index;
                Cliente.excluirCliente(dadosCliente[indice].codigoCliente);
                dadosCliente = Cliente.listarClientes();
                gridViewClientes.DataSource = dadosCliente;
            }
        }

        /*private void gridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewClientes.SelectedRows.Count > 0)
            {
                int indice = gridViewClientes.SelectedRows[0].Index;
                if (indice >= 0)
                {
                    codigoClienteG.Text = Convert.ToString(dadosCliente[indice].codigoCliente);
                    nomeClienteG.Text = dadosCliente[indice].nomeCliente;
                    telefoneClienteG.Text = dadosCliente[indice].telefone;
                }
            }
        }*/

    }
}

