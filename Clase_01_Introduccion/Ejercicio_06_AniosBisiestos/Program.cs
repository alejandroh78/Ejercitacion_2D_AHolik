using System;

/*
Ejercicio I06 - Años bisiestos

Consigna
Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
salvo si ellos también son múltiplos de 400. 
Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos 
en ese rango.

IMPORTANTE
Utilizar sentencias de iteración, selectivas y el operador módulo (%).
*/

namespace Ejercicio_06_AniosBisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anioInicioIngresado;
            int anioFinIngresado;

            Console.Write("Ingrese año Inicio: ");
            int.TryParse(Console.ReadLine(), out anioInicioIngresado);

            while (anioInicioIngresado == 0)
            {
                Console.Write("ERROR! Reingrese, año Inicio!: ");
                int.TryParse(Console.ReadLine(), out anioInicioIngresado);
            }

            Console.Write("Ingrese año Fin: ");
            int.TryParse(Console.ReadLine(), out anioFinIngresado);

            while (anioFinIngresado == 0)
            {
                Console.Write("ERROR! Reingrese, año Fin!: ");
                int.TryParse(Console.ReadLine(), out anioFinIngresado);
            }

            for (int i = anioInicioIngresado; i <= anioFinIngresado; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine($"{i} es año Bisiesto");
                }
                else if (i % 4 == 0 & i % 100 == 0 & i % 400 == 0)
                {
                    Console.WriteLine($"{i} es año Bisiesto");
                }
            }


        }
    }
}
