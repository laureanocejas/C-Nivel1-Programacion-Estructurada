using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  3- Hacer un programa para ingresar los valores de los pesos de distintas encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total.
            Por ejemplo: 10, 20, 140,    70, 100,    40, 10, 50, 80,    90, 30, 40, 50,   -10.
                            Camión 1.    Camión 2          Camión 3       Camión 4       Camión 5
            Se pide determinar e informar:
            a. El número de camión y peso total de encomiendas (Camión 1: 170kg, Camión 2: 170kg, etc.).
            b. El número de camión que transporta mayor cantidad de encomiendas
            (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            c. La cantidad de camiones que se terminaron cargando. */

            float peso, acumPeso;
            int numCliente, camiones = 0;
            int maxEncomienda = 0, maxCamion = 0;

            Console.WriteLine("Ingrese el peso de la encomienda: ");
            peso = float.Parse(Console.ReadLine());

            while (peso >= 0)
            {
                acumPeso = 0;
                camiones++;
                int cantEncomiendas=0;

                while (peso>0 && (peso + acumPeso <= 200))
                {
                    cantEncomiendas++;
                    acumPeso += peso;
                    Console.WriteLine("Ingrese el peso de la siguiente encomienda: o (Marque un N negativo para salir:)");
                    peso = float.Parse(Console.ReadLine());

                }
                // A. Informar por cada camión que se termina de cargar
                Console.WriteLine("------------Resumen de Camion-----------------");
                Console.WriteLine($"Camion {camiones}: {acumPeso} Kg");
                Console.WriteLine("------------------------------------");

                // Lógica para el punto B (Máximo)
                if (cantEncomiendas > maxEncomienda)
                {
                    maxEncomienda = cantEncomiendas;
                    maxCamion = camiones;
                }

            }
            // Estos informes van FUERA del while principal, una vez que se corta con el negativo
            Console.WriteLine("======= RESULTADOS FINALES =======");
            if (camiones > 0)
            {
                Console.WriteLine($"El camion {maxCamion} que transporta la maxima carga, con un total de {maxEncomienda} encomiendas");
                Console.WriteLine($"La cantidad de camiones utilizados es de: {camiones}");
            }
            else
            {
                Console.WriteLine("No se ingresaron encomiendas");
            }

        }
    }
}

