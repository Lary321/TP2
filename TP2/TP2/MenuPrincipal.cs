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
            ControlBox = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void clienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ControlBox = true
            };
            clienteForm.ShowDialog();            
        }

        private void prodServButton_Click(object sender, EventArgs e)
        {
            ProdutoForm cadastroProdServ = new ProdutoForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ControlBox = true
            };
            cadastroProdServ.ShowDialog();
        }

        private void receitasButton_Click(object sender, EventArgs e)
        {
            NotasForm cadastroNotas = new NotasForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ControlBox = true
            };
            cadastroNotas.ShowDialog();
        }

        private void relatoriosButton_Click(object sender, EventArgs e)
        {
            RelatoriosForm relatorio = new RelatoriosForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                ControlBox = true
            };
            relatorio.ShowDialog();
        }        
    }
}
