using System; // Importa librerías básicas de C#

namespace MiPrimerProyecto // Organiza tu código (como una carpeta virtual)
{
    class Program // El contenedor de tu código
    {
        static void Main(string[] args) // El "punto de entrada" (donde inicia todo)
        {
            // Aquí va tu código

            /*    1-  Hacer	un	programa	para	ingresar un	número	y	luego	se	emita	por	pantalla	un	
  cartel	aclaratorio	si	“Es	mayor	a	10” o	“No	es	mayor	a	10”. */

            int num;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10)
            {
                Console.WriteLine("Es mayor a 10");
            }
            else
            {
                Console.WriteLine("No es mayor a 10");
            }

            /* solucion con operador ternario
            string resultado=(num>10)?"Es mayor a 10":"No es mayor a 10";
            Console.WriteLine(resultado);
            Console.WriteLine((num>10)?"Es mayor a 10":"No es mayor a 10"); */

           /*   2-  Hacer	un	programa	para	ingresar dos	números	distintos	y	luego	se	muestre	por	
pantalla	el	menor	de	ellos.
Nota: no	te	olvides	del	ambiente	ideal.	Qué	es	eso?	Mirá:	 */

            int numero1,numero2;

            Console.WriteLine("Ingrese un numero: ");
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero distinto: ");
            numero2=int.Parse(Console.ReadLine());

            if(numero1<numero2)
            {
                Console.WriteLine($"{numero1}");
            }
            else
            {
                Console.WriteLine($"{numero2}");
            }
            //operador ternario
            string resul=(numero1<numero2)?$"El numero {numero1} es el menor":$"El numero {numero2} es el menor";
            Console.WriteLine(resul);

            /*   3-  Hacer	un	programa	para	ingresar dos	números y	que	luego	emita	por	pantalla
 el	mayor	de	ellos	o	un	cartel	aclaratorio	“Son	iguales” en	el	caso	de	que	así sea.
 Nota:	los	números	pueden	ser	iguales.	 */

            int num1, num2;

            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El mayor es {num1}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los numeros ingresado son iguales");
            }
            else
            {
                Console.WriteLine($"El mayor es {num2}");
            }

          /*    4-  Hacer	un	programa	para	ingresar	un	número	y	luego	se	emita	un	cartel	por	
pantalla	“Positivo” si	el	número	es	mayor	a	cero,	“Negativo” si	el	número	es	
menor	a	cero	o	“Cero” si	el	número	es	igual	a	cero.
Nota: requiere	más	de	in	IF!	Repasá cómo	se	escribirían:	 */

            int numA;

            Console.WriteLine("Ingrese un numero: ");
            numA=int.Parse(Console.ReadLine());

            if(numA>0)
            {
                Console.WriteLine("Positivo");
            }
            else if(numA==0)
            {
                Console.WriteLine("Cero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }

           /*   5-  Hacer	un	programa	para	ingresar un	número	y	mostrar	por	pantalla	un	cartel	
aclaratorio	si	el	mismo	es	PAR	o	IMPAR.
Nota: leé	sobre	el	operador	“Resto”.	 */

            int number;

            Console.WriteLine("Ingrese un numero: ");
            number=int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                Console.WriteLine("Es un numero PAR");
            }
            else
            {
                Console.WriteLine("Es un numero IMPAR");
            }
            //Ternario
            Console.WriteLine((number%2==0)?"ES PAR":"ES IMPAR");

        /*  6- Una	casa	de	video	juegos otorga	un	descuento	dependiendo	del	importe	de	la	
compra	realizada según	los	siguientes	valores:
• Si	el	importe	es	menor	a	ARS	1000,	no	hay	descuento.
• Si	el	importe	es ARS	1000	 o	más	pero	menor	a	ARS	5000,	aplica	un	
descuento	del	10%.
• Si	el	importe	es ARS	5000	o	más,	aplica	un	descuento	del	18%.
Hacer	un	programa	para	ingresar	un	importe	de	venta	y	luego	muestre	por	
pantalla	el	importe	final	con	el	descuento	que	corresponda */

            decimal importe,importeFinal;

            Console.WriteLine("Ingrese el importe de la compra: ");
            importe=decimal.Parse(Console.ReadLine());

            if(importe<1000)
            {
                importeFinal=importe;
            }
            else if(importe<5000)
            {
                importeFinal=importe*0.90m;
            }
            else
            {
                importeFinal=importe*0.82m;
            }

            Console.WriteLine($"El importe final de la compra es de: ${importeFinal:N2}");

           /*   7-  Hacer	un programa	para	ingresar	cuatro	números distintos y	luego	mostrar	por	
pantalla	el	mayor de	ellos.
 */

            int n1,n2,n3,n4,mayor;

            Console.WriteLine("Ingrese un primer numero: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un tercernumero: ");
            n3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un cuarto numero: ");
            n4=int.Parse(Console.ReadLine());
            
            //solucion acumulativa
            if(n1>n2)
            {
                mayor=n1;
            }
            else
            {
                mayor=n2;
            }
            if(n3>mayor)
            {
                mayor=n3;
            }
            if(n4>mayor)
            {
                mayor=n4;
            }

            Console.WriteLine($"El mayor de los numeros es: {mayor}");
            
            //solucion logica
            if(n1>n2 && n1>n3 && n1>n4)
            {
                mayor=n1;             
            }
            else if(n2>n1&&n2>n3&&n2>n4)
            {
                mayor=n2;
            }
            else if(n3>n1&&n3>n2&&n3>n4)
            {
                mayor=n3;
            }
            else
            {
                mayor=n4;
            }

            Console.WriteLine($"El mayor de los numeros es: {mayor}");

            /*  8- Hacer	un	programa	para	ingresar	cuatro	números distintos	y	luego	mostrar	por	
pantalla	el	menor	de	ellos.
 */
             int a,b,c,d,minimo;

            Console.WriteLine("Ingrese un primer numero: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un tercernumero: ");
            c=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un cuarto numero: ");
            d=int.Parse(Console.ReadLine());
            
            //solucion acumulativa
            if(a<b)
            {
                minimo=a;
            }
            else
            {
                minimo=b;
            }
            if(c<minimo)
            {
                minimo=c;
            }
            if(d<minimo)
            {
                minimo=d;
            }

            Console.WriteLine($"El menor de los numeros es: {minimo}");

            /*  9- Hacer	un	programa para	ingresar	cinco	números	distintos	y	luego	mostrar	por	
pantalla	el	mayor	y	el	menor	de	ellos. */

            int numb1,numb2,numb3,numb4,numb5,min,max;

            Console.WriteLine("Ingrese 5 numeros distintos: ");
            numb1=int.Parse(Console.ReadLine());
            numb2=int.Parse(Console.ReadLine());
            numb3=int.Parse(Console.ReadLine());
            numb4=int.Parse(Console.ReadLine());
            numb5=int.Parse(Console.ReadLine());

            if(numb1>numb2)
            {
                max=numb1;
                min=numb2;
            }
            else
            {
                max=numb2;
                min=numb1;
            }
            if(numb3>max)
            {
                max=numb3;
            }
            else if(numb3<min)
            {
                min=numb3;
            }
            if(numb4>max)
            {
                max=numb4;
            }
            else if(numb4<min)
            {
                min=numb4;
            }
            if(numb5>max)
            {
                max=numb5;
            }
            else if(numb5<min)
            {
                min=numb5;
            }
            Console.WriteLine($"El mayor de los numeros es: {max} y el menor es: {min}");

/*      10-Hacer	un	programa	para	ingresar	cuatro	números y	luego	mostrar	por	pantalla	
cuáles son	mayores	a	100. */

            int number1,number2,number3,number4;

            Console.WriteLine("Ingrese cuatros numeros: ");
            number1=int.Parse(Console.ReadLine());
            number2=int.Parse(Console.ReadLine());
            number3=int.Parse(Console.ReadLine());
            number4=int.Parse(Console.ReadLine());

            if(number1>100)
            {
                Console.WriteLine($"{number1} es mayor a 100");
            }
            if(number2>100)
            {
                Console.WriteLine($"{number2} es mayor a 100");
            }
            if(number3>100)
            {
                Console.WriteLine($"{number3} es mayor a 100");         
            }
            if(number4>100)
            {
                Console.WriteLine($"{number4} es mayor a 100");                 
            }
            
           /*   11-  Hacer	un	programa	para	ingresar cuatro	números	y	luego	mostrar	por	pantalla	
cuántos son	menores	a	100. */

            int f,g,h,i;
            int cont=0;

            Console.WriteLine("Ingrese 4 numeros: ");
            f=int.Parse(Console.ReadLine());
            g=int.Parse(Console.ReadLine());
            h=int.Parse(Console.ReadLine());
            i=int.Parse(Console.ReadLine());

            if(f<100)
            {
                cont+=1;
            }
            if (g < 100)
            {
                cont+=1;
            }
            if (h < 100)
            {
                cont+=1;
            }
            if (i < 100)
            {
                cont+=1;
            }
            Console.WriteLine($"La cantidad de numeros menores a 100 es: {cont}");

/*      12-Hacer	un	programa	para	ingresar	un	valor	que	estará expresado	en	minutos.	Si	
los	minutos	superan	los 60,	pasar	el	valor	a	horas,	de	lo	contrario	dejarlo	en	
minutos.	Mostrar	el	resultado	en	pantalla	aclarando	si	se	muestran	minutos	u	
horas. */

            double minutos,hs;

            Console.WriteLine("Ingrese la cantidad de minutos: ");
            minutos=double.Parse(Console.ReadLine());

            if(minutos>60)
            {
                hs=minutos/60;
                Console.WriteLine($"La cantidad de hs es: {hs:N2}");
            }
            else
            {
                Console.WriteLine($"La cantidad de minutos es: {minutos}");
            }


        }
    }
}

