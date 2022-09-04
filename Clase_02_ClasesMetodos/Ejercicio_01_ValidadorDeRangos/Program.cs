using System;


/*
Ejercicio I01 - Validador de rangos

Consigna

Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.

Pedir al usuario que ingrese 10 números enteros. 
Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

IMPORTANTE
Utilizar variables escalares, NO utilizar vectores/arrays.
*/
namespace Ejercicio_01_ValidadorDeRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            int acumuladorNumeros;
            int numeroMaximo;
            int numeroMinimo;
            float calculoPromedioNumeroIngresado;

            int numeroMinimoValidador;
            int numeroMaximoValidador;

            int i;
            int cantidadMaximaIngresos;

            cantidadMaximaIngresos = 10;
            acumuladorNumeros = 0;
            numeroMaximo = -2147483648;
            numeroMinimo = 2147483647;

            numeroMinimoValidador = -100;
            numeroMaximoValidador = 100;

            for (i = 0; i < cantidadMaximaIngresos; i++)
            {
                Console.Write($"{i+1}) Ingrese un numero: " );

                int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (numeroIngresado == 0 || !Validador.Validar(numeroIngresado, numeroMinimoValidador, numeroMaximoValidador))
                {
                    Console.WriteLine("ERROR, numero invalido o fuera de rango!");
                    Console.Write($"{i + 1}) Ingrese un numero: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                acumuladorNumeros = acumuladorNumeros + numeroIngresado;

                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }

            }

            calculoPromedioNumeroIngresado = (float)acumuladorNumeros / i;

            Console.WriteLine();
            Console.WriteLine("************* RESULTADO *************");
            Console.WriteLine($"El menor numero ingresado fue {numeroMinimo}");
            Console.WriteLine($"El mayor numero ingresado fue {numeroMaximo}");
            Console.WriteLine($"El promedio fue {calculoPromedioNumeroIngresado}");

        }
    }
}
