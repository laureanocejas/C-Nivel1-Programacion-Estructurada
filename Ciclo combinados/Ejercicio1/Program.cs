using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guía de Ejercicios (Ciclos Combinados)

            /*  1-    Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. Se pide determinar e informar:
             a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo.
             b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no hubiera números primos, informarlo con
             un cartel aclaratorio.
             c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/


            int num, maxGrupo = 0;
            double maxPorcentajeImpares = 0;
            int cantidadOrdenado = 0;

            for (int i = 0; i < 3; i++)
            {
                int contImpar = 0;
                double cantTotal = 0;
                double porcentImpares = 0;
                int contPrimo = 0, numPrimo = 0, posPrimo = 0, contadorPosicion = 0;
                int mayor = 0;
                bool ordenado = true;
                int anterior = 0;
                Console.WriteLine("Grupo " + (i + 1) + ":");
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                while (num != 0)
                {
                    contadorPosicion++;
                    cantTotal++;
                    if (num > 0)
                    {
                        if (num % 2 != 0)
                        {
                            contImpar++;
                        }
                    }

                    for (int j = 1; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            contPrimo++;
                        }
                    }
                    if (contPrimo == 2)
                    {
                        numPrimo = num;
                        posPrimo = contadorPosicion;
                    }
                    // Si no es el primer número Y el actual es mayor al anterior...
                    if (contadorPosicion > 1 && num >= anterior)
                    {
                        ordenado = false;// Se rompió el orden decreciente
                    }
                    anterior = num;// El actual pasa a ser el anterior para la próxima vuelta

                    Console.WriteLine("Ingrese un numero:/(0 para salir:)");
                    num = int.Parse(Console.ReadLine());

                }
                porcentImpares = (contImpar * 100) / cantTotal;

                if (i == 0)
                {
                    maxPorcentajeImpares = porcentImpares;
                    maxGrupo = i + 1;

                }
                else if (porcentImpares > maxPorcentajeImpares)
                {
                    maxPorcentajeImpares = porcentImpares;
                    maxGrupo = i + 1;

                }
                // Informar resultados del punto B por grupo
                if (posPrimo != 0)
                {
                    Console.WriteLine($"El numero primo del grupo {i + 1} es {numPrimo} cuya posicion es {posPrimo}");
                }
                else
                {
                    Console.WriteLine("No se encontraron numeros primos");
                }
                if (ordenado == true && cantTotal>0)
                {
                    cantidadOrdenado++; ;
                }

            }
            //Informar resultado del punto A 
            Console.WriteLine("El grupo con mayor pocentaje de numeros impares es el grupo: " + maxGrupo);

            Console.WriteLine($"La cantidad de grupos ordenados es {cantidadOrdenado} ");

        }
    }
}
