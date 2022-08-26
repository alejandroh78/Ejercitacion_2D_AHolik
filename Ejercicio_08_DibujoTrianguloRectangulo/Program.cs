using System;

/*
Ejercicio I08 - Dibujando un triángulo rectángulo
Consigna
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.
 */

namespace Ejercicio_08_DibujoTrianguloRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint alturaTringuloIngresado;
            int movimientosHorizontales = 1;

            Console.Write("Ingrese la altura del triangulo: ");
            uint.TryParse(Console.ReadLine(), out alturaTringuloIngresado);

            while (alturaTringuloIngresado == 0)
            {
                Console.Write("ERROR! Ingrese la altura del triangulo: ");
                uint.TryParse(Console.ReadLine(), out alturaTringuloIngresado);
            }

            for (int i = 1; i <= alturaTringuloIngresado; i++)
            {
                for (int j = 0; j < movimientosHorizontales; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                movimientosHorizontales += 2;

            }
        }
    }
}
