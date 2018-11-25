using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP2
{
    class Produto
    {
        public int codigoProduto = 0;
        public string descricao = " ";
        public string tipo = " ";
        public double valor = 0.0;

        public static List<Produto> listarProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            XElement xml = XElement.Load("Produtos.xml");
            foreach (XElement x in xml.Elements())
            {
                Produto p = new Produto()
                {
                    codigoProduto = int.Parse(x.Attribute("codigo").Value),
                    descricao = x.Attribute("nome").Value,
                    valor = double.Parse(x.Attribute("valor").Value),
                };
                produtos.Add(p);
            }
            return produtos;
        }

        public static void adicionarProduto(Produto p)
        {
            XElement x = new XElement("produto");
            x.Add(new XAttribute("codigo", p.codigoProduto.ToString()));
            x.Add(new XAttribute("descricao", p.descricao));
            x.Add(new XAttribute("valor", p.valor));
            XElement xml = XElement.Load("Produtos.xml");
            xml.Add(x);
            xml.Save("Produtos.xml");
        }

        public static void excluirProduto(int codigo)
        {
            XElement xml = XElement.Load("Produtos.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(codigo.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Produtos.xml");
        }

        public static void editarProduto(Produto produto)
        {
            XElement xml = XElement.Load("Produtos.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(produto.codigoProduto.ToString())).First();
            if (x != null)
            {
                x.Attribute("nome").SetValue(produto.descricao);
                x.Attribute("valor").SetValue(produto.valor);
            }
            xml.Save("Produtos.xml");
        }
    }
}