using System;

/*
Ejercicio I01 - Máximo, mínimo y promedio
Consigna
Ingresar 5 números por consola, guardándolos en una variable escalar. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/
namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int numeroMaximoIngresado = 0;
            int numeroMinimoIngresado = 0;
            int promedioNumeroIngreso = 0;
            int acumuladorIngresado = 0;
            int contadorPromedio = 0;
            int flag = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    numeroMaximoIngresado = numeroIngresado;
                    numeroMinimoIngresado = numeroIngresado;
                    acumuladorIngresado = acumuladorIngresado + numeroIngresado;
                    flag = 1;
                }
                else
                {
                    if (numeroIngresado >= numeroMaximoIngresado)
                    {
                        numeroMaximoIngresado = numeroIngresado;
                    }
                    else if (numeroIngresado <= numeroMinimoIngresado) 
                    {
                        numeroMinimoIngresado = numeroIngresado;
                    }

                    acumuladorIngresado = acumuladorIngresado + numeroIngresado;

                }
                contadorPromedio++;
            }

            promedioNumeroIngreso = acumuladorIngresado / contadorPromedio;
            Console.WriteLine($"El valor maximo es {numeroMaximoIngresado} el minimo {numeroMinimoIngresado} y el promedio {promedioNumeroIngreso}");


        }
    }
}
