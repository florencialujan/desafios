using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1.ClasesYObjetos
{
    class Television : Electrodomestico
    {
        private int resolucion;
        private bool TDT;

        public Television() : base()
        {
            this.resolucion = 20;
            this.TDT = false;
        }

        public Television(int precioBase, float peso) : base (precioBase, peso)
        {
            this.resolucion = 20;
            this.TDT = false;
        }
        

        public Television(int resolucion, bool TDT) : base()
        {
            this.resolucion = resolucion;
            this.TDT = TDT;
        }

        public int Resolucion { get => resolucion; set => resolucion = value; }
        public bool TDT1 { get => TDT; set => TDT = value; }

        public override void precioFinal()
        {
            base.precioFinal();
            if (resolucion > 40)
            {
                this.precioBase = this.precioBase + this.precioBase * 0.3;
            }
            if(TDT == true)
            {
                this.precioBase = this.precioBase + this.precioBase * 0.5;
            }

            Console.WriteLine("COLOR: " + this.color);
            Console.WriteLine("Consumo eléctrico: " + this.consumoEnergetico);
            Console.WriteLine("PESO: " + this.peso);
            Console.WriteLine("RESOLUCION: " + this.resolucion);
            if (TDT == true)
                Console.WriteLine("TDT: Sí");
            if (TDT == false)
                Console.WriteLine("TDT: No");
            Console.WriteLine("PRECIO FINAL: $" + this.precioBase);
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
