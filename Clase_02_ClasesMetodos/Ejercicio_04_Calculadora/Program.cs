using System;
using System.ComponentModel.DataAnnotations;

/*
Ejercicio I04 - La calculadora

Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
Calcular (público): Recibirá tres parámetros, 
el primer operando, el segundo operando y la operación matemática. 
El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. 
Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y 
la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
 */
namespace Ejercicio_04_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string checkContinuarCarga;
            decimal numeroUnoIngresado;
            decimal numeroDosIngresado;
            string operacionIngresada;
            decimal resultadoCalculo;
            string ingresoDatos;

            checkContinuarCarga = "s";
            
            do
            {
                Console.Write("Ingrese el primer numero: ");
                ingresoDatos = Console.ReadLine();

                while (!decimal.TryParse(ingresoDatos, out numeroUnoIngresado))
                    {
                    Console.Write("Error, Ingrese el primer numero: ");
                    ingresoDatos = Console.ReadLine();
                }

                Console.Write("Ingrese el segundo numero: ");
                ingresoDatos = Console.ReadLine();

                while (!decimal.TryParse(ingresoDatos, out numeroDosIngresado))
                {
                    Console.Write("Error, Ingrese el segundo numero: ");
                    ingresoDatos = Console.ReadLine();
                }

                Console.Write("Ingrese la operación [ +  -  / *]: ");
                ingresoDatos = Console.ReadLine();

                while (ingresoDatos != "+" && ingresoDatos != "-" && ingresoDatos != "*" && ingresoDatos != "/")
                {
                    Console.WriteLine("Error, Ingrese la operación [ +  -  / *]: ");
                    ingresoDatos = Console.ReadLine();
                }

                operacionIngresada = ingresoDatos;

                Console.Clear();
                resultadoCalculo = Calculadora.Calcular(numeroUnoIngresado, numeroDosIngresado, operacionIngresada);
                
                Console.WriteLine("*** Resultado del calculo ***");
                Console.WriteLine();
                Console.WriteLine($"Primer numero ingresado: {numeroUnoIngresado}");
                Console.WriteLine($"Segundo numero ingresado: {numeroDosIngresado}");
                Console.WriteLine($"Operacion ingresada: {operacionIngresada}");
                Console.WriteLine();
                Console.WriteLine($"Calculo a realizado: {numeroUnoIngresado} {operacionIngresada} {numeroDosIngresado}");
                Console.WriteLine();
                Console.WriteLine($"Resultado del calculo: {resultadoCalculo}");
                Console.WriteLine();

                Console.Write("¿Desea realizar otra operacion? (S/N): ");
                checkContinuarCarga = Console.ReadLine().ToLower();
                Console.Clear();

            } while (Validador.ValidarRespuesta(checkContinuarCarga));

            
        }
    }
}
