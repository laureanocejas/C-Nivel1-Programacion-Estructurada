using System;
using System.Timers;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO FOR (Ciclo Exacto)
            /*1- Hacer un programa que solicite el ingreso de 10 números y que muestre el
mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.  */

         int num,mayor=0;
            for(int i=0;i<10;i++)
            {
                Console.Write($"{i+1}-Ingrese un numero:");
                num=int.Parse(Console.ReadLine());
                if(i==0)
                {
                    mayor=num;
                }
                else if(num>mayor)
                {
                    mayor=num;
                }
            }
            Console.WriteLine($"El mayor de los numeros ingresados es {mayor}");
            Console.ReadKey();

          /* 2-  . Hacer un programa que solicite 20 números y calcule y emita por pantalla
cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
conteo final.
 */

            int numero;
            int cont=0;

            for(int i=0;i<20;i++)
            {
                Console.WriteLine($"{i+1}-Ingrese un numero: ");
                numero=int.Parse(Console.ReadLine());

                if(numero>0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"La cantidad de numeros positivos:{cont} ");
            Console.ReadKey();
/* 
        3-    Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
ningún pedido de datos. */

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey(); 


           /*4-  Hacer un programa para mostrar los números del 10 al 1. No se debe realizar
ningún pedido de datos. */

            for(int i=10;i>0;i--)
            {
                Console.Write($"{i}-");
            }
            Console.ReadKey();
             

           /* 5- . Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
0, 5, 10, 15, 20…. 100. */

            for(int i=0;i<=100;i+=5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


          /* 6-   Hacer un programa que solicite UN número y luego calcule y emita un cartel
aclaratorio si el mismo es primo o no es primo.
Nota: un numero es primo cuando es divisible únicamente por 1 y por sí
mismo. */
            int n;
            int contador=0;
            Console.Write("Ingrese un numero: ");
            n=int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    contador++;
                }
                                
            }
            if(contador==2)
                {
                    Console.WriteLine("Es un numero primo");   
                }
                else
                {
                    Console.WriteLine("No es un numero primo");
                    
                }
            
            Console.ReadKey();
            
           /*7-  Hacer un programa que solicite 10 números y luego mostrar por pantalla el
máximo de ellos y la posición en la que fue ingresado.
 */

            int number,max=0;
            int pos=0;

            for(int i=0;i<10;i++)
            {
                Console.Write((i+1)+"-Ingrese un numero:");
                number=int.Parse(Console.ReadLine());

                if(i==0)
                {
                    max=number;
                    pos=i+1;
                }
                else if(number>max)
                {
                    max=number;
                    pos=i+1;
                }
            }
            Console.WriteLine($"El mayor de los numeros ingresado es {max} cuya posicion es: {pos}");
            Console.ReadKey(); 


          /* 8-   Hacer un programa que solicite 20 números y luego mostrar por pantalla el
menor de ellos y la posición en la que fue encontrado.
 */

            int n,posicion=0,minimo=0;

            for(int i=0;i<20;i++)
            {
                Console.Write((i+1)+"-Ingrese un numero: ");
                n=int.Parse(Console.ReadLine());

                if(i==0)
                {
                    minimo=n;
                    posicion=i+1;
                }
                else if(n<minimo)
                {
                    minimo=n;
                    posicion=i+1;
                }
            }
            Console.WriteLine($"El minimo de los numero ingresado es: {minimo},cuya posicion es: {posicion}");
            Console.ReadKey();

           /*9-  Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
de aquellas personas mayores a 18 años. */

            double promedio=0;
            int edad,acum=0,contador=0;

            for(int i=0;i<20;i++)
            {
                Console.Write($"Ingrese la edad de la persona {i+1}:");
                edad=int.Parse(Console.ReadLine());

                if(edad>18)
                {
                    acum+=edad;
                    contador++;
                }
            }
            promedio=acum/contador;
            Console.WriteLine($"El promedio de las personas mayores de 18 años es {promedio}");
            Console.ReadKey();


          /* 10-  Hacer un programa que solicite 20 números y luego emitir por pantalla el
máximo de los números pares y el mínimo de los números impares. */

            int num,maxpar=0,minimpar=0;
            bool primerPar=true,primerImpar=true;

            for (int i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + "-Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    if (primerPar)
                    {
                        maxpar = num;
                        primerPar = false;
                    }
                    else if (num > maxpar)
                    {
                        maxpar = num;
                    }
                }
                else
                {
                    if (primerImpar)
                    {
                        minimpar = num;
                        primerImpar = false;
                    }

                    else if (num < minimpar)
                    {
                        minimpar = num;
                    }
                }

            }
            Console.WriteLine($"El mayor par ingresado es: {maxpar} y el minimo impar es: {minimpar}");
            Console.ReadKey();

            /*11-  Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
 de los primos de la lista. En caso de no haber ningún número primo, deberá
 aclararlo con un cartel. */

            int numA;
            int maximo = 0;
            bool primerPrimo = true;
            //int primerPrimo = 0; // 0 significa que todavía no encontré primos

           

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "-Ingrese un numero:");
                numA = int.Parse(Console.ReadLine());

                int contPrimo = 0;
                for (int x = 1; x <= numA; x++)
                {
                    if (numA % x == 0)
                    {
                        contPrimo++;
                    }
                }
                if (contPrimo == 2)
                {
                    if (primerPrimo)
                    {
                        maximo = numA;
                        primerPrimo = false;
                        //primerPrimo = 1; // Lo cambio a 1 para avisar que ya encontré uno
                    }
                    else if (numA > maximo)
                    {
                        maximo = numA;
                    }
                }
            }

            if (!primerPrimo)
            //if (primerPrimo == 1) // Si terminó en 1, hubo al menos un primo
            {
                Console.WriteLine($"El maximo numero primo ingresado es: {maximo}");
            }
            else
            {
                Console.WriteLine("No hay numeros primos ingresados");
            }

        }
    }
}

    

