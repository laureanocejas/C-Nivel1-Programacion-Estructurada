using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
         /*  5-  Hacer un programa que solicite una serie de valores de tipo char (caracteres).
            Se entiende por carácter a cada elemento que se obtiene de presionar una
            tecla. Por ejemplo el valor “25” tiene dos caracteres (si quisiéramos guardarlo
            en variables enteras nos alcanza con una, pero si queremos guardarlo en
            variables char, necesitaremos dos); la frase “maxi programa” tiene 13 (se
            incluye el espacio como un carácter).
            La cantidad de valores será como máximo 50, pero el programa puede cortar
            antes si se ingresa el carácter “.” (punto). Una vez cargado el vector de char,
            recorrerlo y reemplazar todas las apariciones de la letra “a” por la letra “e”,
            por ejemplo:
            Vector char original: “Hola muchachada cómo están”.
            Vector char modificado: “Hole muchechede cómo esten”
            Finalmente, mostrar el resultado en pantalla.
            Nota: necesitaremos un vector char de 50, pero no lo cargaremos con un For. */

            char [] vector=new char[50];
            char letra;
            int i=0;

            Console.WriteLine("Ingrese letra por letra (termine con un punto '.' o al llegar a 50):");
            letra=char.Parse(Console.ReadLine());

            while(letra!='.'&& i<50)
            {

                vector[i] = letra;
                i++;
                letra = char.Parse(Console.ReadLine());

            }
            // Guardamos cuántas letras se ingresaron realmente
            int cantidadReal = i;

            //Proceso de reemplazo (solo hasta donde se cargó)
            for (int x = 0; x < cantidadReal; x++)
            {
                if (vector[x] == 'a')
                {
                    vector[x] = 'e';
                }
            }

            i=0;
            Console.WriteLine("\nEl resultado es:"); 
            while(i<cantidadReal)
            {
                Console.WriteLine(vector[i]);
                i++;
                
            }
            
            Console.WriteLine("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}

