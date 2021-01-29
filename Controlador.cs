﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CalculadoraWPF
{
    public class Controlador
    {
        MainWindow window;
        public Controlador(MainWindow window)
        {
            this.window = window;
        }

        public void validarTeclado(object sender, TextCompositionEventArgs e)
        {
            /*A traves del metodo source en el objeto e obtenemos el origen del evento
             y lo comparamos con el control de textBox perteneciente al objeto window
            de la clase MainWindow*/
            if (e.Source == window.txtBox)
            {
                /*Si el texto es una letra e.Handled = true es decir
                 que no lo deje continuar
                e.Handler = true -> no continuar
                e.Handler = false -> continuar
                */
                string caracteres = e.Text;
                char []caracter = caracteres.ToCharArray();

                /*Segun el codigo ASCII para que sea una letra tiene que estar 
                 entre 32 y 64 o entre 58 y 255*/
                
                if ((caracter[0] >= 32 && caracter[0] <= 47) || (caracter[0]>=58 && caracter[0]<=255))
                { 
                    e.Handled = true; 
                }
                else
                {
                    e.Handled = false;
                }
            }

        }

        public void cancelarComando(object sender, DataObjectEventArgs e)
        {

            if (e.Source == window.txtBox) 
            {
                /*CancelComand() lo que hace es cancelar el comando de pegar para 
                 que la caja de texto no pueda admitir letras*/
                e.CancelCommand();
            }

        }


        public void controlarBotones(object sender, RoutedEventArgs e)
        {
            OperacionesComplejas oc = new OperacionesComplejas();
             BigInteger num = BigInteger.Parse(window.txtBox.Text);
            

            if (e.Source == window.factorial)
            {
                try
                {

                    window.txtBlock.Text = (oc.getFactorial(num).ToString());
                }
                catch (FormatException) { }
            }

            if(e.Source == window.enesimoTerminoFibo)
            {
                try
                {
                    window.txtBlock.Text = oc.getEnesimoTermino(num).ToString();
                }
                catch (FormatException) { }
            }

            if (e.Source == window.esPrimo)
            {
                try
                {
                    window.txtBlock.Text = oc.esPrimo(num).ToString();
                }
                catch (FormatException) { }
            }

            if (e.Source == window.desplegarSerie)
            {
                try
                {
                    oc.setSerieFibonacci(num);
                    MessageBox.Show(oc.getSerieFibonacci());
                }
                catch (FormatException) { }
            }

            if (e.Source == window)
            {

            }

            if (e.Source == window)
            {

            }

            if (e.Source == window)
            {

            }
        }
    }
}
