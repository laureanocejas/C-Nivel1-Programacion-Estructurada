using System;
using System.Runtime.Serialization.Formatters; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {

           /* 6- Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
            vector hay algún elemento repetido. De haberlo, indicarlo con un cartel aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
            Pista: usar ciclos combinados. */

            int []vector=new int[10];
            bool repetido=false;
            int rep,cont;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero "+(i+1)+":");
                vector[i]=int.Parse(Console.ReadLine());
            }

            cont=0;
            for(int i=0;i<10;i++)
            {
               
                for(int y=i+1;y<10;y++)
                {
                  
                    if(vector[i]==vector[y])
                    {
                        cont++;
                    }
                    
                }
                
                if(cont>0)
                    {
                        repetido=true;
                    }
            }

            if(repetido==true)
            {
                Console.WriteLine("Hay valores repetidos en el vector!!!");
            }
            else
            {
                Console.WriteLine("No hay valores repetidos en el vector!!!");
            }

            Console.WriteLine("Presione cualquier tecla para salir!!!!");
            Console.ReadKey();

        }
    }
}

