using System;
using System.ComponentModel;


/*
Ejercicio I09 - Dibujando un triángulo equilátero

Consigna
Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.
 */

namespace Ejercicio_09_DibujTrianguloEquilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {


            uint alturaTringuloIngresado;
            uint derecha;
            uint inicioDerecha;
            uint incrementoDerecha;
            uint izquierda;
            bool flag;



            Console.Write("Ingrese la altura del triangulo: ");

            uint.TryParse(Console.ReadLine(), out alturaTringuloIngresado);

            while (alturaTringuloIngresado == 0)
            {
                Console.Write("ERROR! Ingrese la altura del triangulo: ");
                uint.TryParse(Console.ReadLine(), out alturaTringuloIngresado);
            }
            
            flag = false;
            derecha = (alturaTringuloIngresado * 2) - 1;
            inicioDerecha = derecha;
            izquierda = (alturaTringuloIngresado * 2) - 2;
            incrementoDerecha = 2;

            for (int i = 1; i <= alturaTringuloIngresado; i++)
            {
                
                for (int j = 0; j <= derecha; j++)
                {
                    if(flag == false)
                    {
                        if (j == derecha)
                        {
                            Console.Write("*");
                            flag = true;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else 
                    {
                        if (j > izquierda && j < derecha)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
                derecha = inicioDerecha + incrementoDerecha;
                incrementoDerecha += 1;
                izquierda--;
            }
        }
    }
}
