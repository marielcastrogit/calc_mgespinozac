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

            int contador = 2;
            while (contador <= numero)
            {
                serie.Add(serie[contador - 1] + serie[contador - 2]);
                contador++;
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

