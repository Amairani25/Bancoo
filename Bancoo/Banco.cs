using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo
{
    class Banco
    {
        public string nombre { get; set; }
        Cliente[] clientes;
        public Banco()
        {
            clientes = new Cliente[]
            {
 new Cliente(){ Nombre = "Karina", Edad = 32, Saldo = 0 },
 new Cliente(){ Nombre = "Hector", Edad = 25, Saldo = 0 },
 new Cliente(){ Nombre = "Fernanda", Edad = 18, Saldo = 0 },
 new Cliente(){ Nombre = "Angel", Edad = 21, Saldo = 0 },
 new Cliente(){ Nombre = "Juan", Edad = 56, Saldo = 0 }

            };
        }

        public void Depositar(float deposito, int nCliente)
        {
            clientes[nCliente].Saldo += deposito;
        }
        public void Imprimir(int cliente)
        {
            Console.WriteLine($"{clientes[cliente].Nombre}tiene de saldo: {clientes[cliente].Saldo}");
        }
    }
}
