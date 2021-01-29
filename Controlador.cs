using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
