using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guía de Ejercicios 7 (Funciones)
            /* 1-  Hacer una función llamada “producto” que reciba dos números enteros y que
          devuelva el producto de ambos. Luego hacer un programa que pida el precio
          de un artículo y la cantidad vendida y muestre por pantalla el monto total a
          pagar. Usar la función. */


            //Programa principal

            int precio, cantVendida;

            Console.WriteLine("Ingrese el precio del producto:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantVendida = int.Parse(Console.ReadLine());
            Console.WriteLine($"El monto final a pagar es: ${producto(precio,cantVendida)}");


          
        }
          // Definicion de la funcion
           static int producto(int num1, int num2)
            {
                return num1*num2;
            }
            //funcion flecha opcion2 mejor recomendada
            
            // static int prod(int num1,int num2)=>num1*num2;
    }
}
