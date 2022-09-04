using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04_Calculadora
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta.ToLower() == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
