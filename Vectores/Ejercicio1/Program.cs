using System; // Importa librerías básicas de C#

namespace Vectores // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {

            //Guía de Ejercicios 8 (Vectores)
          /*  1-Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            Luego recorrer el vector y determinar e informar cuál es la suma de los valores
            del mismo.
            Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
            recorrerlo y leerlo.*/

            int suma;
            int[] vector=new int[50];
            

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese el numero ",i," :");
                vector[i]=int.Parse(Console.ReadLine());
    
            }
            suma=0;
            for(int i=0;i<5;i++)
            {
                suma+=vector[i];
            }

            Console.WriteLine($"La suma de los valores ingresados es: {suma}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
            

        }
    }
}

