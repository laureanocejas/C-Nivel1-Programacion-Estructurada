using System;

namespace Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guía	de	Ejercicios	1

        /*1-Solicite dos numeros por consola para realizar la suma de ambos numeros y mostrar por pantalla
        el resultado de la suma*/
        
        int num1,num2;

        Console.WriteLine("Ingrese un numero: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero: ");
        num2=int.Parse(Console.ReadLine());
        Console.WriteLine($"La suma es: {num1+num2}");      
       

/*       2- Hacer	un	programa para	solicitar	por	teclado	un	número	y	luego devolver	su	
         valor	elevado	al	cubo.
         Nota:	no	olvides	que	sólo	contamos	con	las	cuatro	operaciones	básicas.	 */

         int num;

         Console.WriteLine("Ingrese un numero: ");
         num=int.Parse(Console.ReadLine());
         Console.WriteLine($"El resultado de {num} elevado al cubo es: {num*num*num}");

  /*      3- Hacer	un	programa	que	permita	ingresar	el	año	actual	y	el	año	de	la	fecha	de	
nacimiento	de	una	persona	y	luego	calcule	y	emita	por	pantalla	su	edad.
Nota:	no	hay	que	tener	en	cuenta	si	la	persona	cumplió	años	o	no,	
simplemente	calcular. */

        int anoActual,anoNacimiento,edad;

        Console.WriteLine("Ingrese el año actual: ");
        anoActual=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el año de nacimiento: ");
        anoNacimiento=int.Parse(Console.ReadLine());
        edad=anoActual-anoNacimiento;
        Console.WriteLine($"La edad es: {edad} años");

/*      4- Hacer	un	programa	que	permita	ingresar	los	kilómetros	existentes	entre	dos	
ciudades	y	la	velocidad	promedio	de	un	vehículo.	Calcular	y	emitir	por	pantalla	
el	tiempo	aproximado	que	demandará	llegar	de	un	punto	a	otro	teniendo	en	
cuenta	los	datos	ingresados. */

        double km,velocidad,tiempo;

        Console.WriteLine("Ingrese los km de distancia que existe entre la ciudad origen y la ciudad de destino");
        km=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad promedio del auto:");
        velocidad=double.Parse(Console.ReadLine());
        tiempo=km/velocidad;
        Console.WriteLine($"El tiempo de demora para llegar a destino es: {tiempo:N2} hs");

     /*     5-   Una	casa	de	computación	paga	a	sus	empleados	un	sueldo	fijo	de	ARS15000	
más	una	comisión	del	5%	sobre	el	total	facturado	por	cada	empleado.	Hacer	un	
programa	para	ingresar	el	total	facturado	por	un	empleado	y	que	luego	calcule	
y	emita	por	pantalla	el	sueldo	total	a	cobrar	por	el	mismo. */

        const float sueldoFijo=15000f;
        const float comision=0.05f;
        float totalFacturado,sueldo;

        Console.WriteLine("Ingrese el total facturado: ");
        totalFacturado=float.Parse(Console.ReadLine());
        sueldo=(sueldoFijo+(totalFacturado*comision));
        Console.WriteLine($"El sueldo total a cobrar es: ${sueldo:N2}");

    /*  6-    Hacer	un	programa	para	ingresar	por	teclado	las	tres	notas	de	exámenes	de	un	
alumno	y	luego	calcule	y	emita	por	pantalla	el	promedio	final.
 */
        float nota1,nota2,nota3,promedio;

        Console.WriteLine("Ingrese la nota1: ");
        nota1=float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota2: ");
        nota2=float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota3: ");
        nota3=float.Parse(Console.ReadLine());
        promedio=((nota1+nota2+nota3)/3);
        Console.WriteLine($"El promedio final del alumno es: {promedio:N1} ");

       /* 7-  Hacer	un	programa	para	ingresar	por	teclado	los	metros	cuadrados	totales	de	
un	predio	y	los	metros	cuadrados	cubiertos;	luego	calcular	y	mostrar	por	
pantalla	el	porcentaje	de	metros	cuadrados	cubiertos	y	el	porcentaje	de	
metros	cuadrados	descubiertos. */

        double metroTotales,metroCubiertos,metroDescubiertos,porcentCubiertos,porcentDescubiertos;

        Console.WriteLine("Ingrese los metros cuadrados totales del predio: ");
        metroTotales=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los metros cuadrados cubiertos:");
        metroCubiertos=double.Parse(Console.ReadLine());
        porcentCubiertos=(metroCubiertos*100)/metroTotales;
        metroDescubiertos=metroTotales-metroCubiertos;
        porcentDescubiertos=(metroDescubiertos*100)/metroTotales;
        Console.WriteLine($"El porcentaje de metros cuadrados cubiertos es: {porcentCubiertos}%");
        Console.WriteLine($"El porcentaje de metros cuadrados cubiertos es: {porcentDescubiertos}%");

       /* 8-  Una	importante	cadena	de	delivery	cuenta	con	una	promoción	por	tiempo	
limitado	en	la	que	otorga	un	15%	de	descuento	sobre	el	total	del	valor	de	la	
compra	realizada.	Hacer	un	programa	para	solicitar	el	monto	total	y	el	mismo	
calcule	y	emita	por	pantalla	el	total	a	cobrar	con	el	descuento	aplicado. */

        decimal montoTotal,totalCobrar;
        const decimal descuento=0.15m;

        Console.WriteLine("Ingrese el monto total: ");
        montoTotal=decimal.Parse(Console.ReadLine());
        totalCobrar=montoTotal-(montoTotal*descuento);
        Console.WriteLine($"El monto total a cobrar con el 15% de descuento es ${totalCobrar:N2}"); 

/*      9-  Una	universidad	desea	conocer	los	porcentajes	de	mujeres	y	hombres	en	las	
carreras	de	ciencias	exactas.	Se	solicita	un	programa	para	cargar	la	cantidad	de	
mujeres	y	la	cantidad	de	hombres	y	que	el	mismo	calcule	y emita	por	pantalla	
los	porcentajes	correspondientes. */

        int cantMujeres,cantHombres,cantTotal;
        double porcentMujeres,porcentHombres;

        Console.WriteLine("Ingrese la cantidad de mujeres de la carrera Ciencias Exactas: ");
        cantMujeres=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de hombres de la carrera Ciencias Exactas: ");
        cantHombres=int.Parse(Console.ReadLine());
        cantTotal=cantMujeres+cantHombres;
        porcentMujeres=(cantMujeres*100)/cantTotal;
        porcentHombres=(cantHombres*100)/cantTotal;
        Console.WriteLine($"El porcentaje de mujeres de la carrera ciencia exactas es de {porcentMujeres}% de un total de {cantTotal}");
        Console.WriteLine($"El porcentaje de hombres de la carrera ciencia exactas es de {porcentHombres}% de un total de {cantTotal}");


 /*  10- Hacer	un	programa	que	permita	ingresar	por	teclado	dos	números	y	que	luego	
muestre	por	pantalla	la	suma,	la	resta,	la	multiplicación	y	la	división	de	dichos	
números.	Se	deben	mostrar	cuatro	resultados	en	pantalla.	Los	números	deben	
ser	solicitados	una	única	vez. */

        float numero1,numero2;

        Console.WriteLine("Ingrese dos numeros: ");
        numero1=float.Parse(Console.ReadLine());
        numero2=float.Parse(Console.ReadLine());
        Console.WriteLine($"La suma es: {numero1+numero2}");
        Console.WriteLine($"La resta es: {numero1-numero2}");
        Console.WriteLine($"La multipliacion es: {numero1*numero2}");
        Console.WriteLine($"La division es: {numero1/numero2}");



        }
    }
}
