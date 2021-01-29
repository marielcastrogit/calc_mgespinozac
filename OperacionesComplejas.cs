using System;
using System.Collections.Generic;
using System.Numerics;

namespace CalculadoraWPF
{
    class OperacionesComplejas
    {
        List<BigInteger> serie;
        public OperacionesComplejas()
        {
            serie = new List<BigInteger>();
            serie.Add(0);
            serie.Add(1);

        }

        public BigInteger getEnesimoTermino(BigInteger numero)
        {
            setSerieFibonacci(numero);
            int posicion = int.Parse(numero.ToString());
            return serie[posicion-1] + serie[posicion - 2];

        }

        public void setSerieFibonacci(BigInteger numero)
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

        public bool esPrimo(BigInteger numero)
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

        public BigInteger getFactorial(BigInteger numero)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }


    }
    }

