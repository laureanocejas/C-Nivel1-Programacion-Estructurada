using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3- Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
            es par o cero si no lo es. Hacer un programa para ingresar 20 números y
            mostrar por pantalla cuántos son pares. */
        
        //Programa principal

            int num, cont = 0;
            int resultado;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese numero " + (i + 1) + ":");
                num = int.Parse(Console.ReadLine());
                resultado = par(num);

                if (resultado == 1)
                {
                    cont++;
                }

            }
            Console.WriteLine($"La cantidad de numeros pares ingresados es {cont}");
        }

        //Definicion de funcion
        static int par(int num)
        {
            if (num % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
