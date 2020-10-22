using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1.ClasesYObjetos
{
    /*private double precioBase;
    private string color;
    private char consumoEnergetico;
    private float peso;*/
    class Lavadora : Electrodomestico
    {
        private int carga;

        public int Carga { get => carga; set => carga = value; }

        public Lavadora() : base()
        {
            this.carga = 5;
            
        }

        public Lavadora(int precioBase, float peso) : base(precioBase,peso)
        {
            this.carga = 5;
            this.color = "BLANCO";
            this.consumoEnergetico = 'F';
            
        }
        
        public Lavadora(int carga) : base()
        {
            this.carga = carga;
            
        }

        public override void precioFinal()
        {
            base.precioFinal();
            
            if (this.carga > 30)
            {
                this.precioBase = this.precioBase + 50;
            }

            Console.WriteLine("COLOR: " + this.color);
            Console.WriteLine("Consumo eléctrico: " + this.consumoEnergetico);
            Console.WriteLine("PESO: " + this.peso);
            Console.WriteLine("CARGA: " + this.carga);
            Console.WriteLine("PRECIO FINAL: $" + this.precioBase);
            Console.WriteLine("----------------------------------------------------------------------------");
        }

    }
}
