using System;
using System.Collections;
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
    public partial class CadastroProdutoForm : Form
    {
        int codProduto = 0;

        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        private void gravarProdutoButton_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();

            p.codigoProduto = Convert.ToInt32(labelCodigoProduto.Text);
            p.descricao = descProdutoTextBox.Text;
            p.valor = double.Parse(valorProdutoTextBox.Text);

            Produto.adicionarProduto(p);

            MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja cadastrar outro produto?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                descProdutoTextBox.Text = String.Empty;
                valorProdutoTextBox.Text = String.Empty;
            }
            else
            {
                Close();
            }
        }

        private void fecharProdutoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar suas alterações?", "", MessageBoxButtons.YesNo,
              MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                ProdutoForm produtoForm = new ProdutoForm();
                produtoForm.StartPosition = FormStartPosition.CenterScreen;
                produtoForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                produtoForm.ControlBox = true;
                produtoForm.ShowDialog();
            }
        }

        private void CadastroProdutoForm_Load(object sender, EventArgs e)
        {
            codProduto++;
            labelCodigoProduto.Text = codProduto.ToString();
        }
    }
}
