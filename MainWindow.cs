using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    class OperacionesAritmeticas
    {
        public string[] getTerminos(TextBlock textoBlock)
        {
            string texto = textoBlock.Text;
            char separador1 = '+';
            string[] terminos = texto.Split(separador1);

            int numTerminos = terminos.Length;
            char separador2 = '=';
            string[] ultimo = terminos[numTerminos - 1].Split(separador2);
            terminos[numTerminos - 1] = ultimo[0];

            return terminos;
        }

        public double getSuma(string[] terminos)
        {

            int punto = 0;
            double suma = 0;
            for (int i = 0; i < (terminos.Length); i++)
            {

                try
                {
                    suma = suma + int.Parse(terminos[i]);
                }catch (ArgumentNullException ex) { }
            }

            for (int i = 0; i < (terminos.Length); i++)
            {
                char[] puntos = terminos[i].ToCharArray();
                
                for (int x = 0; x < puntos.Length; x++)
                {
                    if (puntos[i].Equals('.'))
                    {
                        punto++;
  
                    }
                }
            }

            if (punto > 0)
            {
                return suma;
            }
            else
            {
                return Math.Round(suma);
            }
                
        }
    }

}
