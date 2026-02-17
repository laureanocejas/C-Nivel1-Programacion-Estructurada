using System;

namespace HoloMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guía de Ejercicios 3 (IF nivel 2)

           /* 1-  Hacer un programa que solicite el ingreso de un número y que luego emita un
cartel por pantalla aclarando si el mismo es múltiplo de 5.*/

            int num;

            Console.WriteLine("Ingrese un numero: ");
            num=int.Parse(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine("Es multiplo de 5");
            }
            else
            {
                Console.WriteLine("No es multiplo de 5");
            }

            /*2-Hacer un programa que solicite el ingreso de dos números y luego calcular:
a. La resta si el primero es mayor que el segundo.
b. La suma si son iguales.
c. El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.  */

            int num1,num2,resultado;

            Console.WriteLine("Ingrese un primer numero: ");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            num2=int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                resultado=num1-num2;
            }
            else if(num1==num2)
            {
                resultado=num1+num2;
            }
            else
            {
                resultado=num1*num2;
            }

            Console.WriteLine($"El resultado es: {resultado}");

           /* 3-  Hacer un programa para ingresar dos números. Si el segundo es distinto de
cero, calcular la división del primero por el segundo y mostrar el resultado por
pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
cero. */

            float numero1,numero2,resul;

            Console.WriteLine("Ingrese un primer numero: ");
            numero1=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            numero2=float.Parse(Console.ReadLine());

            if(numero2!=0)
            {
                resul=numero1/numero2;
                Console.WriteLine($"El resultado de la division es: {resul:N2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }


        /*  4- Un importante negocio de desinfectante líquido realiza descuentos
dependiendo de la cantidad de litros vendidos según la siguiente escala:
a. Si vende menos de 100 litros, no hay descuento.
b. Si vende entre 101 y 300 litros, el descuento es del 10%.
c. Si vende entre 301 y 500 litros, el descuento es del 15%.
d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y la
cantidad de litros vendidos y calcule y emita el importe con el descuento
aplicado. */

            double litros,importe,importeFinal=0;

            Console.WriteLine("Ingrese el importe total: ");
            importe=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros: ");
            litros=double.Parse(Console.ReadLine());

            if(litros>=101 && litros<=300)
            {
                importeFinal=importe*0.90;
            }
            else if(litros>300 && litros<=500)
            {
                importeFinal=importe*0.85;
            }
            else if(litros>500)
            {
                importeFinal=importe*0.75;
            }
            else
            {
                importeFinal=importe;
            }
            Console.WriteLine($"El importe final a cobrar es: ${importeFinal:N2}");


            /* 5- Hacer un programa que solicite el ingreso de las notas del primer parcial y del
segundo parcial de una alumna de programación. El programa deberá analizar
las notas y emitir la situación de la alumna según la siguiente escala:
a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
aprueba con 6 o más), emitir “rinde examen final”.
c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
recuperar”.
El programa debe emitir solo un cartel, el que corresponda. */

            double nota1,nota2;
            string situacion="";

            Console.WriteLine("Ingrese la nota1: ");
            nota1=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota2: ");
            nota2=double.Parse(Console.ReadLine());

            if(nota1>=8 && nota2>=8)
            {
                situacion="Aprobacion directa";
            }
            else if(nota1>=6 && nota2>=6)
            {
                situacion="Rinde examen final";
            }
            else
            {
                situacion="Debe recuperar";
            }

            Console.WriteLine($"El estado del alumno: {situacion}");

        /* 6-Hacer un programa para ingresar por teclado la longitud de los tres lados de un
triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
de triángulo corresponde:
a. Equilátero: cuando los tres lados sean iguales.
b. Isósceles: cuando dos de los tres lados sean iguales.
c. Escaleno: cuando todos los lados sean distintos. */

            double lado1,lado2,lado3;

            Console.WriteLine("Ingrese el lado1 del triangulo: ");
            lado1=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado2 del triangulo: ");
            lado2=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado3 del triangulo: ");
            lado3=double.Parse(Console.ReadLine());

            if(lado1==lado2 && lado2==lado3)
            {
                Console.WriteLine("Es un triangulo Equilatero");
            }
            else if(lado1!=lado2 && lado2!=lado3 && lado3!=lado1)
            {
                Console.WriteLine("Es un triangulo Escaleno");
            }
            else
            {
                Console.WriteLine("Es un triangulo Isosceles");
                
            }

            /* 7-  Hacer un programa para ingresar 4 números. Luego analizar e informar por
  pantalla si los mismos se encuentran ordenados de forma decreciente.
   */

            int n1,n2,n3,n4;

            Console.WriteLine("Ingresar 4 numeros: ");
            n1=int.Parse(Console.ReadLine());
            n2=int.Parse(Console.ReadLine());
            n3=int.Parse(Console.ReadLine());
            n4=int.Parse(Console.ReadLine());

            if(n1>=n2&&n2>=n3&&n3>=n4)
            {
                Console.WriteLine($"Los numeros ingresados estan ordenados de forma decreciente: {n1},{n2},{n3},{n4}");
            }
            else
            {
                Console.WriteLine("Los numeros ingresados no estan ordenados de forma decreciente");
            }


            /* 8-  El negocio de desinfectante antes mencionado vende además detergente
 suelto, y los precios se aplican según la siguiente escala:
 a. 25 ARS por litro los primeros 50 litros.
 b. 20 ARS por litro si la venta es de 51 a 200 litros.
 c. 15 ARS por litro si la venta es de 201 a 500 litros.
 d. 10 ARS por litro si la venta es de más de 500 litros.
 Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
 Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
 (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
 y emita por pantalla el monto final a abonar por el cliente. */

            decimal imp,montoFinal=0;
            int cantLitros,tipoPago;

            Console.WriteLine("Ingrese la cantidad de litro a comprar: ");
            cantLitros=int.Parse(Console.ReadLine());
            Console.WriteLine("Elegir tipo de pago: 1-(Efectivo) 0-(Otro)");
            tipoPago=int.Parse(Console.ReadLine());

            if(cantLitros>500)
            {
                imp=cantLitros*10m;
            }
            else if(cantLitros>200)
            {
                imp=cantLitros*15m;
            }
            else if(cantLitros>50)
            {
                imp=cantLitros*20m;
            }
            else
            {
                imp=cantLitros*25m;
            }

            if(tipoPago==1)
            {
                montoFinal=imp*1.10m;
            }
            else
            {
                montoFinal=imp;
            }

            Console.WriteLine($"El importe final es de: ${montoFinal:N2}");

           /*   9-  Una importante marca de computadoras permite elegir cierta configuración del
equipo a comprar. Para ello existe la siguiente escala de precios:
i5 (1) i7 (2) i9 (3)
8 RAM (1) USD 800 USD 900 USD 1200
16 RAM (2) USD 900 USD 1000 USD 1400
32 RAM (3) USD 1000 USD 1400 USD 2000
Además, el equipo viene con un disco que permite almacenar 500 GB de
información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
adicional de USD 300.
Hacer un programa que solicite la opción de procesador, la opción de memoria
RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender)
y calcule y emita por pantalla el monto de la máquina seleccionada. */

            int procesador,ram;
            decimal monto=0;
            string disco="";

            Console.WriteLine("MENU:");
            Console.WriteLine("Eliga el procesador: -1(i5) \n-2(i7)\n-3(i9)");
            procesador=int.Parse(Console.ReadLine());
            Console.WriteLine("Eliga la memoria RAM: -1(8RAM)\n -2(16RAM)\n 3-(32RAM)");
            ram=int.Parse(Console.ReadLine());

            switch (procesador)
            {
                case 1:
                    switch (ram)
                    {
                        case 1:
                            monto = 800m;
                            break;

                        case 2:
                            monto = 900m;
                            break;

                        case 3:
                            monto = 1200m;
                            break;
                    }
                    break;
                case 2:
                    switch (ram)
                    {
                        case 1:
                            monto = 900m;
                            break;

                        case 2:
                            monto = 1000m;
                            break;

                        case 3:
                            monto = 1400m;
                            break;

                    }
                    break;
                case 3:
                    switch (ram)
                    {
                        case 1:
                            monto = 1000m;
                            break;

                        case 2:
                            monto = 1400m;
                            break;

                        case 3:
                            monto = 2000m;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error de ingreso de datos intente de nuevo:");
                    break;
            }
            Console.WriteLine("Desea extender la el Disco a 1TB: s/n");
            disco=Console.ReadLine();

            if(disco=="s" || disco=="S")
            {
                monto+=300;
            }
            else if(disco!="n" || disco!="N")
            {
                Console.WriteLine("Error de ingreso la opcion no valida");
            
            }

            Console.WriteLine($"El monto total a pagar es: ${monto:N2}");

/*      10- Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
son todos iguales entre sí, caso contrario, no emitir nada. */

            int a,b,c,d;

            Console.WriteLine("Ingrese 4 numeros: ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            d=int.Parse(Console.ReadLine());

            if(a==b&&b==c&&c==d)
            {
                Console.WriteLine("Todos los numeros ingresados son iguales");
            }

        /*  11-Hacer un programa para ingresar tres números y luego mostrarlos ordenados
de menor a mayor. */

            int number1,number2,number3;

            Console.WriteLine("Ingresa el primer numero: ");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            number2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer numero: ");
            number3=int.Parse(Console.ReadLine());

            //Solucion1
            if(number1<=number2 && number2<=number3)
            {
                Console.WriteLine($"{number1},{number2},{number3}");
            } else if(number2<=number1&&number1<=number3)
            {
                Console.WriteLine($"{number2},{number1},{number3}");
                
            }else if(number1<=number2&&number3<=number2)
            {
                Console.WriteLine($"{number1},{number3},{number2}");
                
            }else if(number3<=number1&&number1<=number2)
            {
                Console.WriteLine($"{number3},{number1},{number2}");
                
            }else if(number2<=number3&&number3<=number1)
            {
                Console.WriteLine($"{number2},{number3},{number1}");
                
            }else
            {
                Console.WriteLine($"{number3},{number2},{number1}");
                
            }
            //Solucion2(recomendada)

            int aux;

            // 1. Comparo el primero con el segundo
            if (number1 > number2)
            {
                aux = number1;
                number1 = number2;
                number2 = aux;
            }

            // 2. Comparo el segundo con el tercero
            if (number2 > number3)
            {
                aux = number2;
                number2 = number3;
                number3 = aux;
            }

            // 3. Vuelvo a comparar el primero con el segundo (por si el nuevo 2 es más chico)
            if (number1 > number2)
            {
                aux = number1;
                number1 = number2;
                number2 = aux;
            }

            Console.WriteLine($"Ordenados: {number1}, {number2}, {number3}");

            //Solucion3
          
        
        Console.WriteLine("Introduce tres números (A, B, C):");

        
        Console.Write("A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEl orden de menor a mayor es:");

        
        if (A < B && A < C) // ¿Es A el menor?
        {
            Console.WriteLine(A); // Imprime A
            if (B < C)
            {
                Console.WriteLine(B);
                Console.WriteLine(C);
            }
            else
            {
                Console.WriteLine(C);
                Console.WriteLine(B);
            }
        }
        else if (B < C && B < A) // ¿Es B el menor?
        {
            Console.WriteLine(B); // Imprime B
            if (C < A)
            {
                Console.WriteLine(C);
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(A);
                Console.WriteLine(C);
            }
        }
        else // Entonces C es el menor
        {
            Console.WriteLine(C); // Imprime C
            if (B < A)
            {
                Console.WriteLine(B);
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(A);
                Console.WriteLine(B);
            }
        }


           /*12- Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
la suma de los dos primeros es mayor al producto del segundo con el tercero. */

            int n1,n2,n3,suma=0,producto=0;

            Console.Write("Ingrese un primer numero: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            n2=int.Parse(Console.ReadLine());
            Console.Write("Ingrese un tercer numero: ");
            n3=int.Parse(Console.ReadLine());
            
            suma=n1+n2;
            producto=n2*n3;

            if(suma>producto)
            {
                Console.WriteLine($"La suma del primer y segundo numero es mayor cuyo valor es: {suma} que el producto del segundo y tercer numero {producto}");
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
         






        }
    }
}