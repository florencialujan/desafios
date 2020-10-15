using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0, n2=0;
            string entrada;

            Console.WriteLine("Ingrese un primer numero");
            entrada = Console.ReadLine();
            n1 = Convert.ToInt32(entrada);
            Console.WriteLine("Ingrese un segundo numero");
            entrada = Console.ReadLine();
            n2 = Convert.ToInt32(entrada);
          
            Calculadora.suma(n1, n2);
            Calculadora.resta(n1, n2);
            Console.ReadKey();
        }
    }
}
