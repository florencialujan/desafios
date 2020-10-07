using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDesafio.ClasesYObjetos
{
    class Local : Inmueble

    {
        protected int cantVentanas;
        protected double precioCalculado;

        public Local(string direccion,bool esNuevo, int m2, int pBase, int cantVentanas)
        {
            this.direccion= direccion;
            this.esNuevo = esNuevo;
            this.m2 = m2;
            this.pBase = pBase;
            this.cantVentanas = cantVentanas;

        }

        public override double calcularPrecio()
        {
            //base.calcularPrecio();
            precioCalculado = pBase;

            if(esNuevo == true)
            {
                precioCalculado = precioCalculado + pBase*0.01;
            }
            else
            {
                precioCalculado = precioCalculado + pBase*0.02;
            }

            if (m2 > 50)
            {
                precioCalculado = precioCalculado + pBase * 0.01;
            }

            if(cantVentanas<=1)
            {
                precioCalculado = precioCalculado - pBase * 0.02;
            }

            if (cantVentanas >= 4)
            {
                precioCalculado = precioCalculado + pBase * 0.02;
            }



            return precioCalculado;
        }

    }
}
