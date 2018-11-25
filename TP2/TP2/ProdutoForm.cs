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
    public partial class ProdutoForm : Form
    {
        List<Produto> dadosProduto;

        public ProdutoForm()
        {
            InitializeComponent();
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            dadosProduto = Produto.listarProdutos();
            gridViewProdutos.DataSource = dadosProduto;
        }

        private void incluirProduto_Click(object sender, EventArgs e)
        {
            Close();
            CadastroProdutoForm cadastroProduto = new CadastroProdutoForm();
            cadastroProduto.StartPosition = FormStartPosition.CenterScreen;
            cadastroProduto.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastroProduto.ControlBox = true;
            cadastroProduto.ShowDialog();
        }
    }
}
