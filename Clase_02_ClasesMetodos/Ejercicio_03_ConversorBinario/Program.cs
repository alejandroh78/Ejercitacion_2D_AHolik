using System;

/*
Ejercicio I03 - Conversor binario

Consigna
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) { }

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) { }

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
*/
namespace Ejercicio_03_ConversorBInario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumeroBinario;
            int numeroDecimalConvertido;

            int inputNumeroDecimal;
            string numeroBinarioConvertido;

            inputNumeroBinario = 10101010;
            numeroDecimalConvertido = Conversor.ConvertirBinarioADecimal(inputNumeroBinario);

            Console.WriteLine($"El numero binario {inputNumeroBinario} convertido a decimal es {numeroDecimalConvertido}");

            inputNumeroDecimal = 580;
            numeroBinarioConvertido = Conversor.ConvertirDecimalABinario(inputNumeroDecimal);
            Console.WriteLine($"El numero decimal {inputNumeroDecimal} convertido a binario es {numeroBinarioConvertido}");

        }

    }
}
