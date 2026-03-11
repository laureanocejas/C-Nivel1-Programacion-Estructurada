using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6-  Hacer una función que se llame “sumaResta” que reciba dos números y que
             devuelva la suma Y la resta del primer número con el segundo.
             Nota: recordemos que una función solo puede devolver UN valor por return.
             Cómo podríamos hacer para tener ambos resultados en el main? */

            //Programa principal

            int num1, num2, suma;

            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            //suma=sumaResta(num1,ref num2);
            Console.WriteLine($"La suma de los numeros es:{sumaResta(num1, ref num2)}");//por valor
            Console.WriteLine($"La resta de los numeros es:{num2}");//por referencia

            Console.WriteLine("Pulse cualquier tecla para salir!!!");
            Console.ReadKey();

        }
        //Defincion de funcion
        static int sumaResta(int n1, ref int n2)
        {
            int suma;
            suma = n1 + n2;
            n2 = n1 - n2;
            return suma;
        }
    }
}

