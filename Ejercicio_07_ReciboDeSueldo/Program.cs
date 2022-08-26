using System;
using System.Drawing;
using System.Xml.Schema;

/*
Ejercicio I07 - Recibo de sueldo

Se debe pedir el ingreso por teclado del 
valor hora, 
el nombre, 
la antigüedad (en años) 
la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total 
(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
hay que sumarle la cantidad de años trabajados multiplicados por $150, 
y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con 
el nombre, 
la antigüedad, 
el valor hora, 
el total a cobrar en bruto 
-el total a cobrar neto de todos los empleados ingresados.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.

No es necesario ni se deben utilizar vectores/arrays.
*/

namespace Ejercicio_07_ReciboDeSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float valorHoraIngresado;
            string nombreEmpleadoIngresado;
            int antiguedadAniosIngresado;
            int horasTrabajadasMesIngresado;
            string checkContinuarCarga;

            float importeBrutoTotalCobrar;
            float importeNetoTotalCobrar;
            float valorPorcentajeDescuento;
            float valorAdicionalIncrementoAnios;

            valorPorcentajeDescuento = 0.13f;
            valorAdicionalIncrementoAnios = 150;

            do
            {
                Console.Write("Ingrese el nombre empleado: ");
                nombreEmpleadoIngresado = Console.ReadLine();

                Console.Write("Ingrese valor hora del empleado $: ");
                float.TryParse(Console.ReadLine(), out valorHoraIngresado);

                while (valorHoraIngresado == 0)
                {
                    Console.Write("ERROR! Ingrese valor hora del empleado $: ");
                    float.TryParse(Console.ReadLine(), out valorHoraIngresado);
                }

                Console.Write("Ingrese la antiguedad de años: ");
                int.TryParse(Console.ReadLine(), out antiguedadAniosIngresado);

                while (antiguedadAniosIngresado == 0)
                {
                    Console.Write("ERROR! Ingrese la antiguedad de años: ");
                    int.TryParse(Console.ReadLine(), out antiguedadAniosIngresado);
                }

                Console.Write("Ingrese cantidad de horas trabajadas en el mes: ");
                int.TryParse(Console.ReadLine(), out horasTrabajadasMesIngresado);

                while (horasTrabajadasMesIngresado == 0)
                {
                    Console.Write("ERROR! Ingrese cantidad de horas trabajadas en el mes: ");
                    int.TryParse(Console.ReadLine(), out horasTrabajadasMesIngresado);
                }

                importeBrutoTotalCobrar = (valorHoraIngresado * horasTrabajadasMesIngresado) + (antiguedadAniosIngresado * valorAdicionalIncrementoAnios);
                importeNetoTotalCobrar = (importeBrutoTotalCobrar - (importeBrutoTotalCobrar * valorPorcentajeDescuento));

                Console.WriteLine();
                Console.WriteLine("****************** RECIBO DE SUELDO ******************");
                Console.WriteLine($"Empleado: {nombreEmpleadoIngresado}");
                Console.WriteLine($"Antiguedad: {antiguedadAniosIngresado} años" );
                Console.WriteLine($"Valor hora $: {valorHoraIngresado}");
                Console.WriteLine($"Liquidacion total Bruto $: {importeNetoTotalCobrar:N2}");
                Console.WriteLine($"Liquidacion total Neto $: {importeBrutoTotalCobrar:N2}");
                Console.WriteLine("*****************************************************");

                Console.Write("Desea ingresar otro empleado ? (si / no): ");
                checkContinuarCarga = Console.ReadLine().ToLower();
                Console.WriteLine($"{Environment.NewLine}");

            } while(checkContinuarCarga == "si");

        }
    }
}
