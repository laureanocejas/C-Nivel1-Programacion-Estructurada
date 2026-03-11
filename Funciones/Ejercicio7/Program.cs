using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7- Hacer una función de tipo void (porque no va a devolver nada) llamada
            “positivoNegativoCero” que reciba un número por valor y una variable por
            referencia. Que analice el número y escriba variable recibida por referencia
            con:
            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.
            Hacer un programa main que permita ingresar 100 números y emitir por
            pantalla cuántos son positivos, cuántos negativos y cuántos cero. */

            //Programa principal

            int num;
            int contPos=0,contNeg=0,contCero=0;
            int resultado=0;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Ingresar un numero " + (i + 1) + ":");
                num = int.Parse(Console.ReadLine());

                // Llamamos a la función. 'resultado' se modificará dentro de ella.
                positivoNegativoCero(num, ref resultado);

                if(resultado==0)
                    contCero++;
                else if(resultado==1)
                    contPos++;
                else
                    contNeg++;
            }

            Console.WriteLine($"La cantidad de numeros positivos:{contPos}");
            Console.WriteLine($"La cantidad de nuemros negativos: {contNeg}");
            Console.WriteLine($"La cantidad de numeros igual cero:{contCero}");

            Console.WriteLine("Pulse cualquier tecla para salir!!!");
            Console.ReadKey();

        }
        //Definicion de la funcion
        static void positivoNegativoCero(int n1,ref int j)//por valor y referencia
        {
            if(n1==0)
                j=0;
            else if(n1>0)
                j=1;
            else
                j=-1;
        }
    }
}
