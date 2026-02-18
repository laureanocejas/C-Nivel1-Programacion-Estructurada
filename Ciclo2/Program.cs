using System;
using System.ComponentModel.DataAnnotations;

namespace Ciclo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guía de Ejercicios (Ciclo WHILE-inexactos)

          /*  1- Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
ningún pedido de datos. USANDO WHILE. */

            int num=1;

            while(num<=10)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();

          /* 2-  Hacer un programa para mostrar los números del 10 al 1. No se debe realizar
ningún pedido de datos. USANDO WHILE. */

            int numero=10;

            while(numero>=1)
            {
                Console.WriteLine(numero);
                numero--;
            }
            Console.ReadKey();


            /*3- Hacer un programa que solicite la edad de un grupo de personas. El programa
deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
mostrar por pantalla cuántas personas mayores se registraron. */

            int edad, cont = 0;
            Console.Write("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());

            while (edad >= 18)
            {
                cont++;
                Console.Write("Ingrese la edad:");
                edad = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"La cantidad de personas mayores de edad es: {cont}");
            Console.ReadKey();


            /* 4-Hacer un programa que solicite dos números y luego muestre los números
entre el menor y el mayor de ellos. Acordate, usando While. */

            int num1,num2;
            int menor=0,mayor=0;
            Console.Write("Ingrese el primer numero:");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:");
            num2=int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                mayor=num1;
                menor=num2;
            }
            else
            {
                mayor=num2;
                menor=num1;             
            }

            while(menor<=mayor)
            {
                Console.WriteLine(menor);
                menor++;
            }
            Console.ReadKey();

           /* 5- Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
0, 5, 10, 15, 20…. 100. Usando While.
 */
         int number=0;

            while(number<=100)
            {
                Console.WriteLine(number);
                number+=5;
            }
            Console.ReadKey();


           /*6-  Hacer un programa que solicite UN número y luego calcule y emita un cartel
aclaratorio si el mismo es primo o no es primo.
Nota: usando While. Ya lo hicimos con FOR, ahora con While */

            int numeroA,i=1,contador=0;
            Console.Write("Ingrese un numero: ");
            numeroA=int.Parse(Console.ReadLine());

            while(i<=numeroA)
            {
                if(numeroA%i==0)
                {
                    contador++;         
                }
                i++; 
               
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
 
        /* 7-        Hacer un programa que solicite una lista de números que corta cuando se
ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
en la que fue ingresado. */

            int n,j=0,pos=0,max=0;

            Console.WriteLine("Ingrese un numero para la lista: ");
            Console.WriteLine("Si desea salir del registro de numeros marque (0):");
            n=int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (j == 0)
                {
                    max = n;
                    pos += 1;
                }  
                else if (n > max)
                {
                    max = n;
                    pos += 1;
                }
                j++;
                Console.WriteLine("Ingrese un numero para la lista: ");
                n=int.Parse(Console.ReadLine());
                Console.WriteLine("Si desea salir del registro de numeros marque (0):");

            }
            Console.WriteLine($"El maximo de los numeros ingresados es: {max} cuya posicion es: {pos}");
            Console.ReadKey(); 

           /*8-  Hacer un programa que solicite una lista de números que corta cuando se
ingresa un cero y luego mostrar por pantalla el menor y el segundo menor */

            int numeros,x=0,primerMenor=0,segundoMenor=0;
            bool asignadomenor2=false;

            Console.WriteLine("Ingrese un numero para la lista: ");
            Console.WriteLine("Marque cero(0) si desea salir del sistema:");
            numeros=int.Parse(Console.ReadLine());

            while (numeros != 0)
            {
                if (x == 0)
                {
                    primerMenor = numeros;
                }
                else 
                {
                    if (numeros < primerMenor)
                    {
                        segundoMenor = primerMenor;
                        primerMenor = numeros;
                        asignadomenor2=true;

                    }
                    else if (asignadomenor2==false)
                    {
                        segundoMenor = numeros;
                        asignadomenor2=true;
                    }
                    else if (numeros < segundoMenor)
                    {
                        segundoMenor = numeros;
                    }
                }
                x++;

                Console.WriteLine("Ingrese un numero para la lista: ");
                Console.WriteLine("Marque cero(0) si desea salir del sistema:");
                numeros = int.Parse(Console.ReadLine());
            }
            if (x >= 2)
                Console.WriteLine($"Menor: {primerMenor}, Segundo Menor: {segundoMenor}");
            else
                Console.WriteLine("No ingresaste suficientes números.");

            Console.ReadKey();

          /*  9-  Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
posición en la que fue encontrado cada uno de los mínimos.
 */
            int numeros,x=0,primerMenor=0,segundoMenor=0,posPrimer=0,posSegundo=0;
            bool asignadomenor2=false;

            Console.WriteLine("Ingrese un numero para la lista: ");
            Console.WriteLine("Marque cero(0) si desea salir del sistema:");
            numeros=int.Parse(Console.ReadLine());

            while (numeros != 0)
            {
                if (x == 0)
                {
                    primerMenor = numeros;
                    posPrimer = x + 1;

                }
                else
                {
                    if (numeros < primerMenor)
                    {
                        // El segundo menor hereda el VALOR y la POSICIÓN del que era primero
                        segundoMenor = primerMenor;
                        posSegundo = posPrimer;
                        primerMenor = numeros;
                        posPrimer = x + 1;
                        asignadomenor2 = true;

                    }
                    else if (asignadomenor2 == false)
                    {
                        segundoMenor = numeros;
                        posSegundo = x + 1;
                        asignadomenor2 = true;

                    }
                    else if (numeros < segundoMenor)
                    {
                        segundoMenor = numeros;
                        posSegundo = x + 1;
                    }
                }
                x++;

                Console.WriteLine("Ingrese un numero para la lista: ");
                Console.WriteLine("Marque cero(0) si desea salir del sistema:");
                numeros = int.Parse(Console.ReadLine());
            }
            if (x >= 2)
                Console.WriteLine($"Menor: {primerMenor} y su posicion es {posPrimer}, Segundo Menor: {segundoMenor} y su posciones es {posSegundo}");
            else
                Console.WriteLine("No ingresaste suficientes números.");

            Console.ReadKey();


           /*10-  Hacer un programa que solicite una lista de números que corta cuando se
ingresa un cero y luego emitir por pantalla el máximo de los números
negativos y el mínimo de los números positivos. */

            int number,posminimo=0,negmaximo=0;
            int i=0;
            bool asignadoMaximoNegativo=false,asignadoMinimoPositivo=false;

            Console.WriteLine("Ingrese un numero a la lista: ");
            number=int.Parse(Console.ReadLine());

            while (number != 0)
            {

                if (number > 0)
                {
                    if (asignadoMinimoPositivo==false)
                    {
                        posminimo = number;
                        asignadoMinimoPositivo=true;
                    }
                    else if (number < posminimo)
                    {
                        posminimo = number;
                    }
                }
                else if (number < 0) // GRUPO NEGATIVOS (Aseguramos que sea menor a 0)
                {
                     if (asignadoMaximoNegativo == false)
                        {
                            negmaximo = number;
                            asignadoMaximoNegativo = true;
                        }
                    else if (number > negmaximo)
                        {
                        negmaximo = number;
                        }
                
                }
                i++;
                Console.WriteLine("Ingrese un numero a la lista: ");
                Console.WriteLine("Marque cero(0) si desea salir del sistema:");
                number = int.Parse(Console.ReadLine());

            }
            if (asignadoMinimoPositivo) 
                Console.WriteLine($"El mínimo de los positivos es: {posminimo}");
            else
                Console.WriteLine("No se ingresaron números positivos.");

            if (asignadoMaximoNegativo)
                Console.WriteLine($"El máximo de los negativos es: {negmaximo}");
            else
                Console.WriteLine("No se ingresaron números negativos.");
            Console.ReadKey();

           /*11-  Hacer un programa para ingresar una lista de números que corta cuando se
ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
números pares, la cantidad de positivos y la cantidad de negativos. */

            int num,cantPrimo=0,cantPar=0,cantPost=0,cantNeg=0;
            
            Console.WriteLine("Ingrese un numero a la lista: ");
            num=int.Parse(Console.ReadLine());

            while (num != 0)
            {
                if (num > 0)
                {
                    cantPost++;
                }
                else
                {
                    cantNeg++;
                }

                if (num % 2 == 0)
                {
                    cantPar++;
                }
                // REINICIO DE VARIABLES PARA EL NUEVO NÚMERO
                int cont = 0;
                int i = 1;

                while (i <= num)
                {
                    if (num % i == 0)
                    {
                        cont++;
                        
                    }
                    i++;
                }

                if (cont == 2)
                {
                    cantPrimo++;
                }
                Console.WriteLine("Ingrese un numero a la lista: ");
                Console.WriteLine("Marque cero(0) si desea salir del sistema:");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La cantidad de numero positivo: {cantPost}");
            Console.WriteLine($"La cantidad de numero negativo: {cantNeg}");
            Console.WriteLine($"La cantidad de numero par: {cantPar}");
            Console.WriteLine($"La cantidad de numero primo: {cantPrimo}");
            Console.ReadKey();


        }
    }
}
