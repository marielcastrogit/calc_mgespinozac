using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CalculadoraWPF
{
    public class OperacionesAritmeticas
    {
        public string[] getTerminos(String textoBox, char separador1)
        {
            
            string[] terminos = textoBox.Split(separador1);

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
                    if (puntos[x].Equals('.'))
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

        public double getResta(string[] terminos)
        {

            int punto = 0;
            double suma = 0;
            for (int i = 0; i < (terminos.Length); i++)
            {

                try
                {
                    suma = suma - int.Parse(terminos[i]);
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
                    if (puntos[x].Equals('.'))
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

        public double getMultiplicacion(string[] terminos)
        {

            int punto = 0;
            double multiplicacion = 1;
            for (int i = 0; i < (terminos.Length); i++)
            {

                try
                {
                    multiplicacion = multiplicacion * int.Parse(terminos[i]);
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
                    if (puntos[x].Equals('.'))
                    {
                        punto++;
                    }
                }
            }

            if (punto > 0)
            {
                return multiplicacion;
            }
            else
            {
                return Math.Round(multiplicacion);
            }

        }

        public double getDivision(string[] terminos)
        {
            double division =0.0;
                        
            if (terminos.Length == 2)
            {
                if (int.Parse(terminos[1]) != 0)
                {
                    division = double.Parse(terminos[0]) / double.Parse(terminos[1]);
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre 0");
                }
                
            }
            
            return division;
        }
    }
}