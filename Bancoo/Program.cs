using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.nombre = "Amairani";
            int n;
            do
            {
                Console.WriteLine("Que operacion desea realizar");
                Console.WriteLine("[1] Depositar");
                Console.WriteLine("[2] Mostrar informacion");
                Console.WriteLine("[3] Salir");
                n = int.Parse(Console.ReadLine());
                int c;
                switch (n)
                {
                    case 1:
                        float dep;
                        Console.WriteLine("Ingrese numero de  cliente");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca la cantida a depositar");
                        dep = float.Parse(Console.ReadLine());
                        banco.Depositar(dep, c);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el numero del cliente ");
                        c = int.Parse(Console.ReadLine());
                        banco.Imprimir(c);

                        break;


                }

            } while (n != 3);
        }
    }
}
