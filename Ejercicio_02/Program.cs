using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
                        Se debe validar que el número sea mayor que cero, 
                        caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

                        Utilizar el método Pow de la clase Math para calcular las potencias.
                        */

            double numeroCuadrado;
            double numeroCubo;
            double numeroIngresado;

            numeroIngresado = 0;

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            while (numeroIngresado == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                double.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            numeroCuadrado = Math.Pow(numeroIngresado, 2);
            numeroCubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"Valor ingresado {numeroIngresado}");
            Console.WriteLine($"Valor calculo cuadrado {numeroCuadrado}");
            Console.WriteLine($"Valor calculo cubo {numeroCubo}");

        }
    }
}
