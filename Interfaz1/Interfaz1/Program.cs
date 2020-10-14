using Interfaz1.ClasesYObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora p = new Impresora();
            Contrato contrato = new Contrato();
            Documento doc = new Documento();
            Foto selfie = new Foto();

            p.AgregarImprimible(contrato);
            p.AgregarImprimible(doc);
            p.AgregarImprimible(selfie);

            p.ImprimirTodo();

            Console.ReadKey();

        }
    }
}
