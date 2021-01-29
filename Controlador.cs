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
            if(e.Source == window.txtBox)
            {
                MessageBox.Show("Objeto enviado: " + sender.ToString() + "Evento" + e.ToString());
            }
        }
    }
}
