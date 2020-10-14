using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz2
{
    class Pato : Volador
    {
        int energia = 0;
        public void volador()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
        public void cuenta()
        {
        energia = energia - 5;
        }
    }
}
