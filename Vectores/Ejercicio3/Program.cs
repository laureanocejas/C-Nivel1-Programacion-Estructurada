using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
           /*3- Hacer un programa que solicite 100 números enteros y los guarde en un
            vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
            pantalla los valores del vector que son mayores al promedio calculado. */

            int[]vector=new int[100];
            decimal promedio;
            int suma;
            suma=0;

            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Ingrese el numero "+(i+1)+":");
                vector[i]=int.Parse(Console.ReadLine());
            }


            for(int i=0;i<100;i++)
            {
                suma+=vector[i];
            }

            promedio=(decimal)suma/100;
            Console.WriteLine($"El promedio es: {promedio:N2}");
            Console.WriteLine("Los valores mayores al promedio son: ");
            
            for(int i=0;i<100;i++)
            {
                if(vector[i]>promedio)
                {
                    Console.WriteLine($"{vector[i]}");
                }
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}

