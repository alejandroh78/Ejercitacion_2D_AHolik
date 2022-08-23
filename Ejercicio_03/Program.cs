using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Consigna
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.

            IMPORTANTE
            Utilizar sentencias de iteración, selectivas y el operador módulo(%).
            */

            int numeroIngresado = 0;
            string valorIngresado;
            bool controlPrimos;
           
            valorIngresado = "";
            controlPrimos = false;

            while (valorIngresado.ToLower() != "salir")
            {

                Console.Write("Ingrese un numero: ");
                valorIngresado = Console.ReadLine();

                if (valorIngresado.ToLower() == "salir") 
                {
                    Environment.Exit(0);
                }

                int.TryParse(valorIngresado, out numeroIngresado);

                while (numeroIngresado == 0)
                {
                    Console.Write("ERROR. ¡Reingresar número!: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                Console.Clear();
                Console.WriteLine($"Se van a analizar numeros primos hasta el {valorIngresado} {Environment.NewLine}");
                

                for (int j = 2; j < numeroIngresado; j++)
                {
                    bool esPrimo = true;

                    for (int i = 2; i < j; i++)
                    {
                        if (j % i == 0)
                        {
                            esPrimo = false;
                            i = j;
                        }
                    }

                    if (esPrimo)
                    {
                        Console.WriteLine($"Es Primo {j}");
                        controlPrimos = true;
                    }

                }

                if (controlPrimos == false) 
                {
                    Console.Write($"No se encontraron numeros primos {Environment.NewLine} ");
                }

                Console.Write($"{Environment.NewLine}");
                Console.Write("Quiere ingresar otro numero (si/no) ?: ");
                
                if (Console.ReadLine().ToLower() == "si")
                {
                    Console.Clear();
                    continue;
                }
                else 
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}
