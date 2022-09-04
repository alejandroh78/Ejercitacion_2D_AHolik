using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04_Calculadora
{
    internal class Calculadora
    {

        public static decimal Calcular(decimal numero1, decimal numero2, string operador)
        {
            decimal resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (ValidarDivision(numero2))
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }
            
            return resultado;
        }

        private static bool ValidarDivision(decimal numero)
        {
            if (numero != 0)
            {
                return true;
            }
            return false;
        }
    }
}
