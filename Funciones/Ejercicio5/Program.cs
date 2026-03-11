using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5- Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
            de pagos (entero) y devuelva el monto de cada pago. Hacer un programa para
            ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
            El programa deberá mostrar la cantidad de pagos y el monto del pago para
            cada una de las ventas. */

            //Programa principal

            int cantPagos;
            float monto;
            decimal resultado;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el monto " + (i + 1) + ":");
                monto = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pagos:");
                cantPagos = int.Parse(Console.ReadLine());

                resultado = pagos(monto, cantPagos);

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Venta " + (i + 1) + ":");
                Console.WriteLine($"El monto total de la venta es ${monto}");
                Console.WriteLine($"La cantidad de pagos es {cantPagos}");
                Console.WriteLine($"El monto de cada pago es: ${resultado:N2}");
                Console.WriteLine("----------------------------------------");

            }

        }

        //Defincion de funcion
        static decimal pagos(float mont, int cantPagos)
        {
            if(cantPagos==0)
            {
                return (decimal)mont;
            }
            return (decimal) mont / cantPagos;
        }
    }
}

