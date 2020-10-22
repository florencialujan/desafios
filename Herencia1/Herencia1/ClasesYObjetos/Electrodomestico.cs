using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1.ClasesYObjetos
{
    abstract class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected float peso;

        public Electrodomestico()
        {
            this.precioBase = 100.0;
            this.color = "BLANCO";
            this.consumoEnergetico = 'F';
            this.peso = 5.0f;
        }

        public Electrodomestico(int precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.color = "BLANCO";
            this.consumoEnergetico = 'F';
            this.peso = peso;
        }

        public Electrodomestico(int precioBase, float peso, string color, char consumoEnergetico)
        {
            this.precioBase = precioBase;
            this.color = color.ToUpper();
            comprobarColor(this.color);
            this.consumoEnergetico = Char.ToUpper(consumoEnergetico); 
            comprobarConsumoEnergetico(this.consumoEnergetico);
            this.peso = peso;
        }

        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Color { get => color; set => color = value; }
        public char ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }
        public float Peso { get => peso; set => peso = value; }

        private void comprobarConsumoEnergetico(char letra)
        {
            if(letra<65 || letra>70)  // 65 a 70 EN ASCII.
            {
                this.consumoEnergetico = 'F';
            }
            
        }
        private void comprobarColor(string Color)
        {
            if(color!="NEGRO" && color!="BLANCO" && color!="ROJO" && color!="AZUL" && color!="AZUL" && color != "GRIS")
            {
                this.color = "BLANCO";
            }
          
        }

        public virtual void precioFinal()
        {
            //double precioFinal = this.precioBase;
            switch (this.consumoEnergetico)
            {
                case 'A': this.precioBase = this.precioBase + 100; break;
                case 'B': this.precioBase = this.precioBase + 80; break;
                case 'C': this.precioBase = this.precioBase + 60; break;
                case 'D': this.precioBase = this.precioBase + 50; break;
                case 'E': this.precioBase = this.precioBase + 30; break;
                case 'F': this.precioBase = this.precioBase + 10; break;
            }
            
            if(this.peso>0 && this.peso <= 19)
            {
                this.precioBase = this.precioBase + 10;
            }
            if (this.peso >=20  && this.peso <= 49)
            {
                this.precioBase = this.precioBase + 50;
            }
            if (this.peso >= 50 && this.peso <= 79)
            {
                this.precioBase = this.precioBase + 80;
            }
            if (this.peso >= 80)
            {
                this.precioBase = this.precioBase + 100;
            }
            /*Console.WriteLine("COLOR" + this.color);
            Console.WriteLine("consumo energetico " + this.consumoEnergetico);
            Console.WriteLine("PESO: " + this.peso);
            Console.WriteLine("PRECIO FINAL: $" + precioFinal);
            Console.WriteLine("----------------------------------------------------------------------------");*/
        }
    }
}
