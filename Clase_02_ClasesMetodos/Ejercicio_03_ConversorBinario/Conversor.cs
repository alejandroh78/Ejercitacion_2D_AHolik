using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03_ConversorBInario
{
    class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string resultado = "";

            if (numeroEntero > 0)
            {
                String cadena = "";
                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroEntero = (int)(numeroEntero / 2);
                }
                resultado = cadena;
            }
            return resultado;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int resultado = 0;
            int multiplicador = 1;
            string numeroStr;
            numeroStr = Convert.ToString(numeroEntero);

            for (int i = numeroStr.Length - 1; i >= 0; i--)
            {
                if (numeroStr[i] == '1')
                {
                    resultado += multiplicador;
                }
                multiplicador = multiplicador * 2;
            }
            //Console.WriteLine($"Resultado decimal {resultado}");
            return resultado;
        }
    }
}
