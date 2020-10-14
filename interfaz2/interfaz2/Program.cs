using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz2
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torre = new TorreDeControl();
            Boing747 avion = new Boing747();
            Pato lucas = new Pato();
            Superman clark = new Superman();

            torre.agregarVolador(avion);
            torre.agregarVolador(lucas);
            torre.agregarVolador(clark);

            torre.vuelenTodos();
            Console.ReadKey();

        }
    }
}
