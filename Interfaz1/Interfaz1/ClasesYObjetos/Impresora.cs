using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1.ClasesYObjetos
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        
        public void ImprimirTodo()
        {
            foreach(Imprimible i in ColaDeImpresion)
            {
                i.imprimir();
            }
        }

        public void AgregarImprimible(Imprimible x)
        {
            ColaDeImpresion.Add(x);
        }
    }
}

