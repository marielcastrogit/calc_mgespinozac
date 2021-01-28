using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraWPF
{
    class OperacionesComplejas
    {
        List<long> serie;
        public OperacionesComplejas()
        {
            serie = new List<long>();
            serie.Add(0);
            serie.Add(1);

        }

        public void serieFibonacci(int numero)
        {


            if (numero >= 2 && numero <= 100)
            {
                serie.Add(serie[numero-1] + serie[numero-2]);
                serieFibonacci(numero = numero + 1);

            }

            
        }

        public void imprimeSerie()
        {

           for(int x = 0; x < serie.Count; x++)
            {
                Console.WriteLine(serie[x] + "");
            }
        }
    }
    }

