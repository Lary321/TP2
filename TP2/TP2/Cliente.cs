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

        #region Métodos
        public void excluirCliente(int codigo)
        {
            XElement xml = XElement.Load("Clientes.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(codigo.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Clientes.xml");
        }

        public void cadastrarCliente(Cliente c)
        {
            XElement x = new XElement("cliente");
            x.Add(new XAttribute("codigo", c.codigoCliente));
            x.Add(new XAttribute("nome", c.nomeCliente));
            x.Add(new XAttribute("telefone", c.telefone));
            x.Add(new XAttribute("logradouro", c.logradouro));
            x.Add(new XAttribute("numero", c.numero));
            x.Add(new XAttribute("bairro", c.bairro));
            x.Add(new XAttribute("municipio", c.municipio));
            x.Add(new XAttribute("estado", c.estado));
            x.Add(new XAttribute("cpfcnpj", c.CPF_CNPJ));
            x.Add(new XAttribute("cep", c.cep));
            XElement xml = XElement.Load("Clientes.xml");
            xml.Add(x);
            xml.Save("Clientes.xml");
        }

        public List<Cliente> listarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            XElement xml = XElement.Load("Clientes.xml");

            foreach (XElement x in xml.Elements())
            {
                Cliente c = new Cliente();

                c.codigoCliente = int.Parse(x.Attribute("codigo").Value);
                c.nomeCliente = x.Attribute("nome").Value;
                c.telefone = x.Attribute("telefone").Value;
                c.CPF_CNPJ = x.Attribute("cpfcnpj").Value;
                //c.logradouro = x.Attribute("logradouro").Value;
                //c.municipio = x.Attribute("municipio").Value;
                //c.estado = x.Attribute("estado").Value;
                //c.cep = x.Attribute("cep").Value;
                clientes.Add(c);
            }
            return clientes;
        }

        public static void editarCliente(Cliente cliente)
        {
            XElement xml = XElement.Load("Clientes.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(cliente.codigoCliente.ToString())).First();
            if (x != null)
            {
                x.Attribute("codigo").SetValue(cliente.codigoCliente);
                x.Attribute("nome").SetValue(cliente.nomeCliente);
                x.Attribute("telefone").SetValue(cliente.telefone);
                x.Attribute("cpfcnpj").SetValue(cliente.CPF_CNPJ);
                x.Attribute("logradouro").SetValue(cliente.logradouro);
                x.Attribute("numero").SetValue(cliente.numero);
                x.Attribute("bairro").SetValue(cliente.bairro);
                x.Attribute("municipio").SetValue(cliente.municipio);
                x.Attribute("estado").SetValue(cliente.estado);
                x.Attribute("cep").SetValue(cliente.cep);
            }
            xml.Save("Clientes.xml");
        }
        #endregion

    }
}
