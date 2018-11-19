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

namespace TP2
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
       
              
        public static Cliente mostraClientesCadastrados()
        {
            try
            {
                FileStream stream = new FileStream(@"TP2\bin\Debug", FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(Cliente));
                Cliente cliente = (Cliente)desserializador.Deserialize(stream);
                return cliente;
            }
            catch
            {
                return null;
            }
        }

        private void incluirCliente_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroCliente = new CadastroClienteForm();
            cadastroCliente.StartPosition = FormStartPosition.CenterScreen;
            cadastroCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroCliente.ControlBox = true;
            cadastroCliente.ShowDialog();
        }
    }
}

