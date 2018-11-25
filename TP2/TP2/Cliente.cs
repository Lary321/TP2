using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP2
{
    class Cliente : Endereco
    {
        #region Atributos

        private int codigo;
        private string nome;
        private string telefone;
        private string cpfcnpj;
        #endregion

        #region Propriedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string CPFCNPJ
        {
            get { return cpfcnpj; }
            set { cpfcnpj = value; }
        }
        #endregion

        public static List<Cliente> listarClientesFiltro()
        {
            List<Cliente> dadosCliente = new List<Cliente>();
            XElement xml = XElement.Load("Clientes.xml");
            foreach (XElement x in xml.Elements())
            {
                Cliente c = new Cliente()
                {
                    codigo = int.Parse(x.Attribute("codigo").Value),
                    nome = x.Attribute("nome").Value,
                    telefone = x.Attribute("telefone").Value,
                    cpfcnpj = x.Attribute("cpfcnpj").Value,
                };
                dadosCliente.Add(c);
            }
            return dadosCliente;
        }

        public static void adicionarCliente(Cliente c)
        {
            XElement x = new XElement("cliente");
            x.Add(new XAttribute("codigo", c.codigo.ToString()));
            x.Add(new XAttribute("nome", c.nome));
            x.Add(new XAttribute("telefone", c.telefone));
            x.Add(new XAttribute("cpfcnpj", c.cpfcnpj));
            x.Add(new XAttribute("logradouro", c.Logradouro));
            x.Add(new XAttribute("numero", c.Numero));
            x.Add(new XAttribute("bairro", c.Bairro));
            x.Add(new XAttribute("municipio", c.Municipio));
            x.Add(new XAttribute("estado", c.Estado));
            x.Add(new XAttribute("cep", c.Cep));
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
            XElement x = xml.Elements().Where(p => p.Attribute("codigo").Value.Equals(cliente.codigo.ToString())).First();
            if (x != null)
            {
                x.Attribute("nome").SetValue(cliente.nome);
                x.Attribute("telefone").SetValue(cliente.telefone);
                x.Attribute("cpfcnpj").SetValue(cliente.cpfcnpj);
                x.Attribute("logradouro").SetValue(cliente.Logradouro);
                x.Attribute("numero").SetValue(cliente.Numero);
                x.Attribute("bairro").SetValue(cliente.Bairro);
                x.Attribute("municipio").SetValue(cliente.Municipio);
                x.Attribute("estado").SetValue(cliente.Estado);
                x.Attribute("cep").SetValue(cliente.Cep);
            }
            xml.Save("Clientes.xml");
        }

    }
}
