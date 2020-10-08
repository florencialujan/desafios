using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDesafio.ClasesYObjetos
{
    class Piso : Inmueble
    {
        private int nroPiso;
        private double precioCalculado;

        public Piso(string direccion, bool esNuevo, int m2, int pBase, int nroPiso)
        {
            this.direccion = direccion;
            this.esNuevo = esNuevo;
            this.m2 = m2;
            this.pBase = pBase;
            this.nroPiso = nroPiso;

        }

        public double PrecioCalculado { get => precioCalculado; set => precioCalculado = value; }
        public int NroPiso { get => nroPiso; set => nroPiso = value; }

        public double calcularPrecio()
        {
            
            precioCalculado = pBase;

            if (esNuevo == true)
            {
                precioCalculado = precioCalculado - pBase * 0.01;
            }
            else
            {
                precioCalculado = precioCalculado - pBase * 0.02;
            }


            if (nroPiso >= 3)
            {
                precioCalculado = precioCalculado + pBase * 0.03;
            }



            return precioCalculado;
        }
    }
}
