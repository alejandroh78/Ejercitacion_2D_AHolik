using System;


/*
Ejercicio I04 - Un número perfecto

Consigna
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
(excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.
*/

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroPerfecto = 1;
            int numeroTotalBusqueda= 0;

            do
            {
                int sumadorNumeroPerfectoEncontrado = 0;
                
                for (int i = numeroPerfecto - 1; i > 0; i--)
                {
                    if ((numeroPerfecto % i) == 0)
                    {
                        sumadorNumeroPerfectoEncontrado += i;

                        if (sumadorNumeroPerfectoEncontrado > numeroPerfecto) 
                        {
                            break;
                        }
                    }
                }

                if (sumadorNumeroPerfectoEncontrado == numeroPerfecto)
                {
                    Console.WriteLine($"Numero Perfecto: {numeroPerfecto}");
                    numeroTotalBusqueda++;
                }

                numeroPerfecto++;

            } while (numeroTotalBusqueda < 4);

        }
    }
}
