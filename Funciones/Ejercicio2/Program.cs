using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2- Hacer una función llamada “mayor” que reciba dos números enteros y
            devuelva el mayor de ellos o cero si son iguales. */

            //Programa principal

            int num1, num2, resultado;

            Console.WriteLine("Ingrese el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            resultado = mayor(num1, num2);

            if (resultado == 0)
            {
                Console.WriteLine($"Los numeros son iguales:{resultado}");
            }
            else
            {
                Console.WriteLine($"El numero mayor es:{resultado}");

            }

        }
        //Definicion de funcion
        static int mayor(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else if (n1 == n2)
            {
                return 0;
            }
            else
            {
                return n2;
            }
        }
    }
}
