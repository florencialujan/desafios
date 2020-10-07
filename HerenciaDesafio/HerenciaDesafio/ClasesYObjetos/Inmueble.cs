using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDesafio.ClasesYObjetos
{
    class Inmueble
    {
        protected string direccion;
        protected int pBase;
        protected bool esNuevo;
        protected int m2;
        protected double precioInmueble=0;

        /*
        public string Direccion { get => direccion; set => direccion = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int PBase { get => pBase; set => pBase = value; }
        public bool EsNuevo { get => esNuevo; set => esNuevo = value; }
        public int M2 { get => m2; set => m2 = value; }
        */
        
        public virtual double calcularPrecio()
        {
            //....va a ser reescrito
            return precioInmueble;
        }

      

    }
}
