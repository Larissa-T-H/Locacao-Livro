using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aula63_Exer2_Locacao.Servico
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public double CPF { get; set; }

        public Cliente(int iDCliente, string nome, double cpf)
        {
            this.IDCliente = iDCliente;
            this.Nome = nome;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return IDCliente.ToString() + " - " + Nome + " - " + "CPF " + CPF;
        }

        public class RepositoryCliente
        {
            public static List<Cliente> InicializarCliente()
            {
                List<Cliente> clientes = new List<Cliente>();

                clientes.Add(new Cliente(001, "Larissa", 01232100100));
                clientes.Add(new Cliente(002, "Jhonatta", 12345678900));
                clientes.Add(new Cliente(003, "Theo", 98765432101));
                return clientes;
            }
        }
    }
}
