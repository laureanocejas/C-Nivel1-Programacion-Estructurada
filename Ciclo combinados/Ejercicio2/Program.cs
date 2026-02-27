using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       2- Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
                     Para ello tiene un lote de registros por cada uno de los usuarios con los siguientes datos:
                     • Zona (numérico entero).
                     • Número de cliente (número de cuatro dígitos no correlativos).
                     • Cantidad de kilovatios consumidos en el periodo.
                     El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro con zona igual a cero.
                     Se pide generar un listado con el siguiente formato:
                     Zona: XX
                     Cantidad de usuarios de la zona: XX
                     Total facturado en la zona: XX
                     Zona: XX
                     Cantidad de usuarios de la zona: XX
                     Total facturado en la zona: XX
                     El precio es escalonado según la siguiente escala:
                     • $ 0.10 por kv por los primeros 100 kv de consumo.
                     • $ 0.12 por kv por el consumo de 101 a 200 kvs.
                     • $ 0.15 por kv por el consumo de 201 kvs en adelante. */

            int zona, zonaAct, numeroCliente, cantidadKv;
            int cantxZona = 0;
            double totalFacturado, facturado;
            
            Console.WriteLine("Ingrese la zona a registrar:(1(Balvanera)2(San Telmo)3(Recoleta)4(Almagro)");
            zona = int.Parse(Console.ReadLine());

            while (zona != 0)

            {
                zonaAct = zona;
                // Reiniciamos acumuladores para la nueva zona
                cantxZona = 0;
                totalFacturado = 0;

                while (zona == zonaAct)
                {
                    Console.WriteLine("Ingrese el numero de cliente:");
                    numeroCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad Kv consumidos:");
                    cantidadKv = int.Parse(Console.ReadLine());


                    if (cantidadKv < 101)
                    {
                        facturado = cantidadKv * 0.10;
                    }
                    else if (cantidadKv < 201)
                    {
                        facturado = (100 * 0.10) + ((cantidadKv - 100) * 0.12);
                    }
                    else
                    {
                        facturado = (100 * 0.10) + (100 * 0.12) + ((cantidadKv - 200) * 0.15);
                    }
                    totalFacturado += facturado;
                    cantxZona++;
                    // Pedimos la zona del PRÓXIMO registro
                    Console.WriteLine("Ingrese zona (0 para finalizar o misma zona para seguir):");
                    zona = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("--------------Resultados----------------");
                Console.WriteLine($"Zona: {zonaAct}");
                Console.WriteLine($"La cantidad de usuarios es: {cantxZona}");
                Console.WriteLine($"El monto total facturado es: ${totalFacturado:N2}");
                Console.WriteLine("------------------------------------\n");

            }

        }
    }
}

