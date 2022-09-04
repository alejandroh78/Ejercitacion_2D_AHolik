using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05_AprenderTablas
{
    internal class Tabla
    {
        public static StringBuilder Calcular(int numero)
        {
            
            
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                int cuenta = numero * i;

                resultado.AppendLine($"{numero} x {i} = {cuenta}");
            }

            return resultado;
        }
    }
}
