using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
            /*2- Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            Luego recorrer todos los elementos del vector y determinar cuál es el valor
            máximo y su posición dentro del vector.*/

            int max,pos;
            int[] vector = new int[50];

            for(int i=0;i<50;i++)
            {
                Console.WriteLine("Ingrese el numero "+(i+1)+":");
                vector[i]=int.Parse(Console.ReadLine());
            }
            max=0;
            pos=1;
            max=vector[0];

            for(int i=1;i<50;i++)
            {
                if(vector[i]>max)
                {
                    max=vector[i];
                    pos=i+1;
                }
            }
            
            Console.WriteLine($"El maximo de los numeros ingresado es: {max}");
            Console.WriteLine($"La posicion que tiene es: {pos}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}


