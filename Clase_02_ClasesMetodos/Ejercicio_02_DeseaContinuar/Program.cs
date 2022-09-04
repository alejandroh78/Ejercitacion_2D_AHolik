using System;

/*
Ejercicio I02 - ¿Desea continuar?

Consigna
Realizar un programa que sume números enteros hasta que el usuario 
lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, 
que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, 
TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
*/

namespace Ejercicio_02_DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string checkContinuarCarga;
            int sumador;

            checkContinuarCarga = "s";
            sumador = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (numeroIngresado == 0)
                {
                    Console.WriteLine("ERROR, numero invalido !");
                    Console.Write("Ingrese un numero: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                sumador = sumador + numeroIngresado;

                Console.Write("¿Desea continuar? (S/N): ");
                checkContinuarCarga = Console.ReadLine().ToLower();
                Console.WriteLine();

            } while (Validador.ValidarRespuesta(checkContinuarCarga));

            Console.Write($"La suma de los numeros ingresados es {sumador}"); 
        }
    }
}
