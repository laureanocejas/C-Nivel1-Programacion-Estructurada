using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 4-Una compañía de turismo aventura registró los paquetes vendidos durante la última temporada vacacional. Para cada venta se ingresó:
            • Número de paquete (4 dígitos no correlativos).
            • Cantidad de personas incluidas.
            • Precio por persona.
            • Horas totales de actividades.
            • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente).
            El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura
            no se haya vendido.
            A partir de dichos datos, se solicita informar:
            a. La cantidad de paquetes vendidos de cada tipo de aventura..
            b. La cantidad total de personas que disfrutaron de las aventuras durante la temporada.
            c. El total recaudado por cada venta.
            d. La venta con mayor importe de cada tipo de aventura.
            e. El paquete con menos horas incurridlas y en qué tipo de actividad fue. */

            int numPaquete, cantPersonas, hsTotalesActividades;
            double precioPersona, monto;
            string tipoAventura, tipoActualizado;

            // Variables para totales generales
            int cantTotalPersonas = 0;
            int  minHs = 0;
            int paqueteMinHs = 0;
            string tipoAvenMin = "";
            bool primerPaquete = true;// Bandera para el primer mínimo

            Console.WriteLine("Ingrese el numero de paquete:(0 para finalizar)");
            numPaquete = int.Parse(Console.ReadLine());

            // CICLO EXTERNO: Controla la temporada hasta que el paquete sea 0
            while (numPaquete != 0)
            {
                Console.WriteLine("Ingrese el tipo de aventura:");
                Console.WriteLine("opciones: (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,Parapente).");
                tipoAventura = Console.ReadLine();

                // Guardamos el tipo actual para el grupo(corte de control)
                tipoActualizado = tipoAventura;
                // Variables que se REINICIAN por cada nuevo tipo de aventura
                
                int cantPaquetesTipo = 0;
                double maxVentaTipo = 0;

                // CICLO INTERNO: Procesa los paquetes del MISMO tipo de aventura
                // Bucle de GRUPO (mientras sea el mismo tipo de aventura y no sea paquete 0)
                while (numPaquete != 0 && tipoAventura == tipoActualizado)
                {
                    
                    cantPaquetesTipo++;// Punto A

                    Console.WriteLine("Ingrese la cantidad de personas: ");
                    cantPersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio por personas:");
                    precioPersona = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de hs de actividades:");
                    hsTotalesActividades = int.Parse(Console.ReadLine());


                    // c. Total recaudado por esta venta
                    monto = cantPersonas * precioPersona;
                    Console.WriteLine($"-> Total recaudado por venta: ${monto}");

                    // b. Acumulador total de personas (Temporada)
                    cantTotalPersonas += cantPersonas;
                   

                    // d. Mayor importe de este tipo de aventura
                    if (monto > maxVentaTipo)
                    {
                        maxVentaTipo = monto;
                    }

                    // e. Paquete con menos horas (Temporada)
                    if (primerPaquete)
                    {
                        minHs = hsTotalesActividades;
                        paqueteMinHs = numPaquete;
                        tipoAvenMin=tipoActualizado;// <-- CAMBIO: Guardamos el nombre de la actividad
                        primerPaquete = false;
                    }
                    else
                    {
                        if (hsTotalesActividades < minHs)
                        {
                            minHs = hsTotalesActividades;
                            paqueteMinHs = numPaquete;
                            tipoAvenMin = tipoActualizado; // <-- CAMBIO: También acá
                        }
                    }

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Siguiente registro - Ingrese Número de Paquete (0 para finalizar):");
                    numPaquete = int.Parse(Console.ReadLine());

                    if (numPaquete != 0)
                    {
                        Console.WriteLine("Ingrese Tipo de Aventura:");
                        tipoAventura = Console.ReadLine();
                    }

                }
                // Informes por cada Tipo de Aventura (al cerrar el grupo)
                Console.WriteLine($"\n*** RESUMEN TIPO {tipoActualizado} ***");
                Console.WriteLine($"La venta con mayor importe es de: {maxVentaTipo}");
                Console.WriteLine($"La cantidad de paquetes vendidos es: {cantPaquetesTipo}");
                Console.WriteLine("*********************************\n");


            }
            // --- Informes finales de toda la temporada ---
            Console.WriteLine("\n======= REPORTES FINALES DE TEMPORADA =======");
            if (!primerPaquete) 
            {
                Console.WriteLine($"b. Cantidad total de personas en la temporada: {cantTotalPersonas}");
                Console.WriteLine($"e. Paquete con menos horas: {paqueteMinHs} ({minHs} hs) en la actividad {tipoAvenMin}");
            }
            else
            {
                Console.WriteLine("No se cargaron datos en el sistema.");
            }
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}


