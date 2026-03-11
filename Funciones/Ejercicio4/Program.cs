using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4-Hacer una función llamada “primo” que reciba un número entero y devuelva 1
            si el número es primo o cero si no lo es. Hacer un programa para ingresar
            números. El lote corta cuando se ingresa un número cero. Informar el
            promedio teniendo en cuenta sólo los números primos. */

            //Programa principal

            int num, suma = 0;
            int resultado, contPrimo = 0;
            decimal promedio = 0;

            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                resultado = primo(num);

                if (resultado == 1)
                {
                    suma += num;
                    contPrimo++;
                }

                Console.WriteLine("Ingrese un numero o Cero para salir:");
                num = int.Parse(Console.ReadLine());
            }
            if (contPrimo > 0)
            {
                promedio = (decimal)suma / contPar;
                Console.WriteLine($"El promedio de los numeros primos ingresado es {promedio:N2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros primos");
            }

        }
        static int primo(int num)
        {
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
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

