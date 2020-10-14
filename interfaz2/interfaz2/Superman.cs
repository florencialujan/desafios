using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz2
{
    class Superman : Volador
    { 
        int experiencia = 0;
        public void cuenta()
        {
            experiencia = experiencia + 3;
        } 
        public void volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
        }
       
    }
}
