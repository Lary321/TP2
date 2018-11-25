using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP2
{
    public class Cliente : Endereco
    {

        #region Atributos
        public int codigoCliente = 0;
        public string nomeCliente = " ";
        public string CPF_CNPJ = " ";
        public string telefone = " ";
        #endregion

        public static List<Cliente> listarClientes()
        {
            List<Cliente> pessoas = new List<Cliente>();
            XElement xml = XElement.Load("Pessoas.xml");
            foreach (XElement x in xml.Elements())
            {
                Cliente c = new Cliente()
                {
                    codigoCliente = int.Parse(x.Attribute("codigo").Value),
                    nomeCliente = x.Attribute("nome").Value,
                    telefone = x.Attribute("telefone").Value
                };
                pessoas.Add(c);
            }
            return pessoas;
        }

        public static void adicionarCliente(Cliente c)
        {
            XElement x = new XElement("cliente");
            x.Add(new XAttribute("codigo", c.codigoCliente.ToString()));
            x.Add(new XAttribute("nome", c.nomeCliente));
            x.Add(new XAttribute("telefone", c.telefone));
            XElement xml = XElement.Load("Clientes.xml");
            xml.Add(x);
            xml.Save("Clientes.xml");
        }

        public static void excluirCliente(int codigo)
        {
            XElement xml = XElement.Load("Clientes.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(codigo.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Clientes.xml");
        }

        public static void editarCliente(Cliente cliente)
        {
            XElement xml = XElement.Load("Clientes.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(cliente.codigoCliente.ToString())).First();
            if (x != null)
            {
                x.Attribute("nome").SetValue(cliente.nomeCliente);
                x.Attribute("telefone").SetValue(cliente.telefone);
            }
            xml.Save("Clientes.xml");
        }
       
    }
}
