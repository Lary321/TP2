using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();            
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm cadastroCliente = new ClienteForm();
            cadastroCliente.StartPosition = FormStartPosition.CenterScreen;
            cadastroCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroCliente.ControlBox = true;
            cadastroCliente.ShowDialog();        
        }

        private void prodServButton_Click(object sender, EventArgs e)
        {
            ProdutoForm cadastroProdServ = new ProdutoForm();
            cadastroProdServ.StartPosition = FormStartPosition.CenterScreen;
            cadastroProdServ.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroProdServ.ControlBox = true;
            cadastroProdServ.ShowDialog();
        }

        private void receitasButton_Click(object sender, EventArgs e)
        {
            NotasForm cadastroNotas = new NotasForm();
            cadastroNotas.StartPosition = FormStartPosition.CenterScreen;
            cadastroNotas.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroNotas.ControlBox = true;
            cadastroNotas.ShowDialog();
        }

        private void relatoriosButton_Click(object sender, EventArgs e)
        {
            RelatoriosForm relatorio = new RelatoriosForm();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.FormBorderStyle = FormBorderStyle.FixedSingle;
            relatorio.ControlBox = true;
            relatorio.ShowDialog();
        }
    }
}
