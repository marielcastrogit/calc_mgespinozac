using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.BouncyCastle.Math;

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

        public long getEnesimoTermino(int numero)
        {
            setSerieFibonacci(numero);
            return serie[numero - 1] + serie[numero - 2];

        }

        public void setSerieFibonacci(int numero)
        {
            int contador = 2;
            while (contador <= numero)
            {
                serie.Add(serie[contador - 1] + serie[contador - 2]);
                contador++;
            }
        }

        public String getSerieFibonacci()
        {
            String series="";

           for(int x = 2; x < serie.Count; x++)
            {
                series = series + (serie[x] + " ");
            }

            return series;
        }

        public bool esPrimo(int numero)
        {
            //Obtengo los divisores del numero 
            int divisores = 0; 
            for(int i = 1; i<=numero; i++)
            {
                if (numero % i == 0) { divisores++; }
            }

            //Si el numero solo es divisible entre 1 y el mismo entonces es primo
            if(divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getFactorial(int numero)
        {
            int factorial = 1;

            for(int i = 1; i<=numero; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }


    }
    }

