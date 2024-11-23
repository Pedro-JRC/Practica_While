using System;
using System.ComponentModel.Design;

namespace Nomina_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            string cantEmpleadoDigita = string.Empty;
            int cantEmpleados = 0;
            string sueldoDigita = string.Empty;
            int sueldo = 0;
            int menor300 = 0;
            int mayor300 = 0;
            int gastNomina = 0;
            int valorEmp = 0;

            try
            {
                // SOLICITA LA CANTIDAD DE EMPLEADOS
                Console.WriteLine("Favor ingrese la cantidad de empleados.");
                cantEmpleadoDigita = Console.ReadLine();

                // ESPACIO
                Console.WriteLine();

                // VALIDACIONES 
                if (int.TryParse(cantEmpleadoDigita, out cantEmpleados) && cantEmpleados > 0)
                {
                    // BUCLE PARA SOLICITAR SALARIO
                    while (valorEmp++ < cantEmpleados)
                    {
                        // SOLICITA EL SALARIO DEL EMPLEADO
                        Console.Write($"Favor ingrese el salario del empleado {valorEmp}: ");
                        sueldoDigita = Console.ReadLine();

                        // ESPACIO
                        Console.WriteLine();

                        // VALIDACIONES
                        if (int.TryParse(sueldoDigita, out sueldo) && sueldo >= 100 && sueldo <= 500)
                        {   
                            // SUMA EL SUELDO DE CADA EMPLEADO
                            gastNomina += sueldo;
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO SE INTRODUZCA UN VALOR NO VALIDO
                            Console.WriteLine("Favor ingrese un sueldo mayor a 100$ y menor a 500$.");
                        }

                        // CALCULA LOS EMPLEADOS QUE GANAN ENTRE 100$ Y 300$
                        if (sueldo <= 300)
                        {
                            // SI EL SUELDO ES MENOR A 300 INCREMENTA 1
                            menor300++;
                        }
                        else
                        {
                            // SI EL SUELDO ES MAYOR A 300 INCREMENTA 1
                            mayor300++;
                        }

                    }


                }
                else
                {
                    // MENSAJE DE ERROR EN CASO SE INTRODUZCA UN VALOR NO VALIDO
                    Console.WriteLine("Favor ingrese valores validos.");
                }

                // MUESTRA LOS EMPLEADOS QUE GANAN ENTRE 100$ Y 300$ Y LOS QUE GANAN MAS DE 300$
                Console.WriteLine($"Empleados que ganan entre 100$ y 300$: ({menor300})");
                Console.WriteLine($"Empleados que ganan mas de 300$: ({mayor300})");
                Console.WriteLine($"Gasto total en nomina: ({gastNomina}$)");


            }
            catch
            {
                // MENSAJE DE ERROR EN CASO SE INTRODUZCA UN VALOR NO VALIDO
                Console.WriteLine("Favor ingrese valores validos.");
            }

        }
    }
}
