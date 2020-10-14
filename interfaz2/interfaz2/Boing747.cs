using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz2
{
    class Boing747 : Volador
    {
        int horasDeVuelo = 0;
        public void volador()
        {
            Console.WriteLine("Estoy volando como un avión...");
        }
        public void cuenta()
        {
            horasDeVuelo = horasDeVuelo + 13;
        }
    }
}
