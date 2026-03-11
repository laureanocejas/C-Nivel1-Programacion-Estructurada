using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8- Hacer un programa que permita ingresar una lista de números que corta
            cuando se ingresa un cero. A partir de dichos datos informar:
            a. El mayor de los números pares.
            b. La cantidad de números impares.
            c. El menor de los números primos.
            Hacer uso de las funciones anteriormente desarrolladas */

            //Programa principal

            // Variables para los resultados
            int num, contImpares = 0;
            int menorPrimo = 0;
            int mPar=0;
            bool primerPrimo=true;
            bool primerPar=true;

            Console.WriteLine("Ingrese un numero (o Cero para salir):");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                // a. Informar el mayor de los pares
                // Usamos la función solo para preguntar
                if(esPar(num))
                {
                    // Si es el primer par que vemos O es más grande que el anterior
                    if(primerPar)
                    {
                        mPar=num;
                        primerPar=false;
                    }
                    else if(num>mPar)
                    {
                        mPar=num;
                    }
                }
                // b. Cantidad de impares
                // Usamos la función booleana para decidir si sumamos
                if(esImpares(num))
                {
                    contImpares++;
                }
              // c. Menor de los primos
                if(esPrimo(num))
                {
                    if(primerPrimo)
                    {
                        menorPrimo=num;
                        primerPrimo=false;
                    }
                    else  if(num<menorPrimo)
                    {
                        menorPrimo=num;
                    }
                }
            
                Console.WriteLine("Ingrese un numero o Cero para salir:");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El mayor numero par ingresado es {mPar}");
            Console.WriteLine($"La cantidad de numeros impares es {contImpares}");
            Console.WriteLine($"El menor numero primo ingresado es: {menorPrimo}");

        }

        static bool esPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        
        }
        static bool esImpares(int numero)
        {
            if (numero % 2 != 0)
            {
                return true;
            }
            return false;
        
        }

        static bool esPrimo(int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            return false;
           
        }
    }
}

