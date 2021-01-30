using System;
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
        String contenidoCaja = "";

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
                char[] caracter = caracteres.ToCharArray();

                /*Segun el codigo ASCII*/

                if ((caracter[0] >= 32 && caracter[0] <= 41) ||(caracter[0] ==44) || (caracter[0] >= 58 && caracter[0] <= 60) ||
                    (caracter[0] >=62 && caracter[0] <=255))
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


            //Eventos para los botones de las operaciones complejas:
            if (e.Source == window.factorial)
            {

                try
                {

                    BigInteger num = BigInteger.Parse(window.txtBox.Text);
                    window.txtBlock.Text = (oc.getFactorial(num).ToString());
                }
                catch (FormatException) { }
            }

            if (e.Source == window.enesimoTerminoFibo)
            {
                try
                {
                    BigInteger num = BigInteger.Parse(window.txtBox.Text);
                    window.txtBlock.Text = oc.getEnesimoTermino(num).ToString();
                }
                catch (FormatException) { }
            }

            if (e.Source == window.esPrimo)
            {
                try
                {
                    BigInteger num = BigInteger.Parse(window.txtBox.Text);
                    window.txtBlock.Text = oc.esPrimo(num).ToString();
                }
                catch (FormatException) { }
            }

            if (e.Source == window.desplegarSerie)
            {
                try
                {
                    BigInteger num = BigInteger.Parse(window.txtBox.Text);
                    oc.setSerieFibonacci(num);
                    MessageBox.Show(oc.getSerieFibonacci());
                }
                catch (FormatException) { }
            }

            //Eventos para los botones que tienen numero:
            Object o = e.Source; //o de origen del evento.


            if (o == window.num0)
            {
                contenidoCaja += window.num0.Content.ToString();

            }

            if (o == window.num1)
            {
                contenidoCaja += window.num1.Content.ToString();
            }

            if (o == window.num2)
            {
                contenidoCaja += window.num2.Content.ToString();
            }

            if (o == window.num3)
            {
                contenidoCaja += window.num3.Content.ToString();
            }

            if (o == window.num4)
            {
                contenidoCaja += window.num4.Content.ToString();
            }

            if (o == window.num5)
            {
                contenidoCaja += window.num5.Content.ToString();
            }


            if (o == window.num6)
            {
                contenidoCaja += window.num6.Content.ToString();
            }

            if (o == window.num7)
            {
                contenidoCaja += window.num7.Content.ToString();
            }

            if (o == window.num8)
            {
                contenidoCaja += window.num8.Content.ToString();
            }

            if (o == window.num9)
            {
                contenidoCaja += window.num9.Content.ToString();

            }


            //Eventos para los botones que tienen signos de operaciones aritmeticas:
            OperacionesAritmeticas oa = new OperacionesAritmeticas();
            if (e.Source == window.sumar)
            {
                contenidoCaja += window.sumar.Content.ToString();
                window.txtBox.Text = (oa.getSuma(oa.getTerminos(window.txtBox.Text)).ToString());
                window.txtBlock.Text = contenidoCaja;

            }else if (e.Source == window.restar)
            {
                contenidoCaja += window.sumar.Content.ToString();
                window.txtBox.Text = (oa.getResta(oa.getTerminos(window.txtBox.Text)).ToString());
                window.txtBlock.Text = contenidoCaja;

            } else if (e.Source == window.multiplicar)
            {
                contenidoCaja += window.sumar.Content.ToString();
                window.txtBox.Text = (oa.getMultiplicacion(oa.getTerminos(window.txtBox.Text)).ToString());
                window.txtBlock.Text = contenidoCaja;

            }
            else if(e.Source== window.num0 || e.Source == window.num1 || e.Source == window.num2 ||
                e.Source == window.num3 || e.Source == window.num4 || e.Source == window.num5 || e.Source == window.num6 
                || e.Source == window.num7 || e.Source == window.num8 || e.Source == window.num9)
            {

                window.txtBox.Text = (contenidoCaja);

            }
            else if(e.Source == window.borrarUltimoDigito)
            {
                if (window.txtBox.Text.Length > 0)
                {
                    window.txtBox.Text = window.txtBox.Text.Remove(window.txtBox.Text.Length - 1, 1);
                    contenidoCaja = window.txtBox.Text;
                }
            }


            if (e.Source == window.borrarTodo)
            {
                window.txtBlock.Text = "";
                window.txtBox.Text = "";
                contenidoCaja = "";
            }

            if (e.Source == window.borrarReciente)
            {
                window.txtBox.Text = "";
            }
        }
    }
}
