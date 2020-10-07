using HerenciaDesafio.ClasesYObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaDesafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* -----------------------------------------
         CheckedChange lo que nos comprueba es que si seleccionamos un Piso, por ejemplo, nos deje sólo ingresar
         el n° de piso de la propiedad y se bloquee la cantidad de ventanas. Si seleccionamos Local, hará lo contrario :)*/
        private void sPiso_CheckedChanged(object sender, EventArgs e)
        {
            cantVentanas.Enabled = false;
            nPiso.Enabled = true;
        }

        private void sLocal_CheckedChanged(object sender, EventArgs e)
        {
            cantVentanas.Enabled = true;
            nPiso.Enabled = false;
        }

    
        /*  -----------------------------------------------------------------------------
         La funcion ActivarCalcular lo que hace es evaluar si los TextBox estén llenos o vacios para que si 
         los TextBox esten vacios, no nos deje apretar el BotonCalcular, y si estan llenos si nos deje apretar el boton*/
        private bool ActivarCalcular()
        {
            if (direccion.Text != ("") && m2.Text != ("") && precioBase.Text != ("") && (cantVentanas.Text != ("") || nPiso.Text != ("")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*---------------------------------------------------------------------  
         En los siguientes metodos x_TextChanged lo que hacemos es evaluar que cuando se entre un valor
         se compruebe si los demas valores tambien están cargados para que se habilite BotonCalcular */

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            BotonCalcular.Enabled = ActivarCalcular();
        }

        private void m2_TextChanged(object sender, EventArgs e)
        {
            BotonCalcular.Enabled = ActivarCalcular();
        }

        private void precioBase_TextChanged(object sender, EventArgs e)
        {
            BotonCalcular.Enabled = ActivarCalcular();
        }

        private void nPiso_TextChanged(object sender, EventArgs e)
        {
            BotonCalcular.Enabled = ActivarCalcular();
        }

        private void cantVentanas_TextChanged(object sender, EventArgs e)
        {
            BotonCalcular.Enabled = ActivarCalcular();
        }


        /*-------------------------------------------------------------------------------------
        *El método compruebaSoloNumeros comprueba que en los TextBox que requieren valores numericos, no deje entrar letras*/
    
        private void compruebaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        /*-----------------------------------------------------------------------------------
          EVENTO DE BOTON CALCULAR: Una vez que se clickee el boton Calcular, lo primero que hará sera convertir la opcion seleccionada
          de nuevo o usado en una variable local booleana llamada Estado. Luego comprobara si seleccionamos Piso o Local y activará
          la clase y el método correspondiente :D  -----------------------------------------------*/
        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            bool estado = true;
            double precio;
            if (nuevo.Checked)
            {
                estado = true;
            }
            if (usado.Checked)
            {
                estado = false;
            }

            if (sPiso.Checked == true)
            {
                Piso p1 = new Piso(direccion.Text, estado, Convert.ToInt32(m2.Text), Convert.ToInt32(precioBase.Text), Convert.ToInt32(nPiso.Text));
                precio = p1.calcularPrecio();
                pCalculado.Text = ("$" + precio);
            }
            else
            {
                Local l1 = new Local(direccion.Text, estado, Convert.ToInt32(m2.Text), Convert.ToInt32(precioBase), Convert.ToInt32(cantVentanas.Text));
                precio = l1.calcularPrecio();
                pCalculado.Text = ("$" + precio);
                
            }

            
        }
    }
}
