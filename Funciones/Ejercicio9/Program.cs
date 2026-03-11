using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solucion del ejercicio8 con funciones que realizan la logica es menos recomendable

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
            int mPar = 0;
            bool primerPrimo = true;
            bool primerPar = true;

            Console.WriteLine("Ingrese otro:");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                // a. La función ahora decide si actualiza el mayor par
                mPar = actualizarMayorPar(num, mPar, ref primerPar);

                // c. La función decide si actualiza el menor primo
                menorPrimo = actualizarMenorPrimo(num, menorPrimo, ref primerPrimo);

                Console.WriteLine("Ingrese otro:");
                num = int.Parse(Console.ReadLine());

            }
             Console.WriteLine($"El mayor numero par ingresado es {mPar}");
           
            Console.WriteLine($"El menor numero primo ingresado es: {menorPrimo}");
        }
        // --- FUNCIONES CON LÓGICA ---

        static int actualizarMayorPar(int n, int actualMax, ref bool esElPrimero)
        {
            if (n % 2 == 0)
            {
                if (esElPrimero || n > actualMax)
                {
                    esElPrimero = false;
                    return n; // Nuevo máximo
                }
            }
            return actualMax; // Mantiene el que ya estaba
        }
        static int actualizarMenorPrimo(int n, int actualMin, ref bool esElPrimero)
        {
            // Primero verificamos si es primo (usando otra función o lógica aquí)
            if (esPrimo(n))
            {
                if (esElPrimero || n < actualMin)
                {
                    esElPrimero = false;
                    return n; // Nuevo mínimo
                }
            }
            return actualMin;
        }

        static bool esPrimo(int n)
        {
            if (n <= 1) return false;
            int c = 0;
            for (int i = 1; i <= n; i++) if (n % i == 0) c++;
            return c == 2;
        }
    }

}

