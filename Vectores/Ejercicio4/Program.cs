using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
            /*4- Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
            determinar e informar si el vector está ordenado en forma creciente. Por
            ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
            y 9 no lo está. */

            int [] vector=new int[10];
            bool ordenado=true;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Ingresar el numero "+(i+1)+":");
                vector[i]=int.Parse(Console.ReadLine());
            }

            for(int i=0;i<9;i++)
            {
                if(vector[i]>vector[i+1])
                {
                    ordenado=false;
                }
            }

            if(ordenado)
            {
                Console.WriteLine("El vector se encuentra ordenado de forma creciente!!!");
            }
            else
            {
                Console.WriteLine("El vector no se encuentra ordenado");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}

