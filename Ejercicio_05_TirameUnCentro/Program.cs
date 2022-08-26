using System;

/*
Ejercicio I05 - Tirame un centro

Consigna
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) 
en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) 
en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 

El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y 
el número que el usuario ingrese por consola.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.
*/

namespace Ejercicio_05_TirameUnCentro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese un número: ");

            int numeroIngresado;
            int numeroAcumuladorCentro;
            int contador;

            if (int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                for (int numeroCentro = 1; numeroCentro <= numeroIngresado; numeroCentro++)
                {
                    numeroAcumuladorCentro = 0;

                    for (int i = 1; i < numeroCentro; i++)
                    {
                        numeroAcumuladorCentro += i;
                    }

                    contador = numeroCentro + 1;

                    do
                    {
                        numeroAcumuladorCentro -= contador;
                        contador++;

                    } while (numeroAcumuladorCentro > 0);

                    if (numeroAcumuladorCentro == 0)
                    {
                        Console.WriteLine($"El numero {numeroCentro} es centro numerico");
                    }
                }
            }
            else
            {
                Console.Write("Error, datos invalidos");
            }
        }
    }
}

