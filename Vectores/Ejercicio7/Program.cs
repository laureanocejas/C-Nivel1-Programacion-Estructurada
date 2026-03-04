using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
            /*  7-  Una empresa comercializa 15 tipos de artículos y por cada venta realizada
               genera un registro con los siguientes datos:
               • Número de artículo (1 a 15).
               • Cantidad vendida.
               Puede haber varios registros para el mismo artículo y el último se indica
               número de artículo igual a cero.
               Se pide determinar e informar:
               a. El número de artículo que más se vendió en total.
               b. Los números de artículos que no registraron ventas.
               c. La cantidad de unidades vendidas para el artículo número 10.
               Nota: tener en cuenta el concepto de “registro” y el planteo de estructura
               principal separado de consignas (ver videos de ciclos combinados y ejercicios
               resueltos de ciclos combinados). */

            double[] articulos = new double[15];
            int numArt, cantV, maxArt;

            Console.WriteLine("Ingrese el numero de articulo[1-15] o 0 para finalizar:");
            numArt = int.Parse(Console.ReadLine());

            // Primero inicializamos el vector en 0 (aunque C# lo hace solo)
            for (int i = 0; i < 15; i++)
            {
                articulos[i] = 0;
            }

            while (numArt != 0)
            {
                Console.WriteLine("Ingrese la cantidad vendida:");
                cantV = int.Parse(Console.ReadLine());
                // Acumulamos: restamos 1 porque el vector empieza en 0
                articulos[numArt - 1] += cantV;

                Console.WriteLine("Ingrese el numero de articulo[1-15] o 0 para finalizar:");
                numArt = int.Parse(Console.ReadLine());

            }
            // El artículo 10 está en la posición 9 del vector
            Console.WriteLine($"La cantidad de unidades vendidas para el articulo 10 es de: {articulos[9]}");

            Console.WriteLine("\nArtículos sin ventas:");
            for (int i = 0; i < 15; i++)
            {
                if (articulos[i] == 0)
                {
                    // Mostramos i + 1 porque es el número real del artículo
                    Console.WriteLine($"El artículo {i + 1} no registró ventas.");
                }
            }

            maxArt = 0;
            for (int i = 0; i < 15; i++)
            {
                if (articulos[i] > maxArt)
                {
                    maxArt = i + 1;
                }
            }
            Console.WriteLine($"El numero de articulo que mas se vendio es:{maxArt}");
            Console.WriteLine("Presione cualquier tecla para salir!!!!");
            Console.ReadKey();


        }
    }
}


