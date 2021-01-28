using System;
using System.Windows.Controls;

namespace CalculadoraWPF
{
    public class OperacionesAritmeticas
    {
        public string[] getTerminos(TextBox textoBox)
        {
            string texto = textoBox.Text;
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
                }
                catch (ArgumentNullException) { }
                catch (FormatException) { }
                catch (OverflowException) { }
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