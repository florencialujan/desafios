using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES
{ 
    class Calculadora
    {

        /*private int n1;  //COMO VAMOS A USAR METODOS ESTÁTICOS, NO NECESITAMOS CREAR ATRIBUTOS NI CONSTRUCTORES A ESTOS.
        private int n2;

        public Calculadora(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;

        }
        */
        public static void suma(int n1, int n2)
        {
            int s;
            s = n1 + n2;
            Console.WriteLine("El resultado de la suma (n1+n2) es: " + s);
        }

        public static void resta(int n1, int n2)
        {
            int r;
            r = n1 - n2;
            Console.WriteLine("El resultado de la resta (n1-n2) es: " + r);
        }


    }
}
