namespace Calificaciones_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            string cantDigita = string.Empty;
            int cantCalif = 0;
            string califDigita = string.Empty;
            int calificaciones = 0;
            int aprobados = 0;
            int reprobados = 0;
            int valor = 0; 

            try
            {

                // SOLICITA LA CANTIDAD DE CALIFICACIONES A EVALUAR
                Console.WriteLine("Favor indique la cantidad de calificaciones a evaluar.");
                cantDigita = Console.ReadLine();

                // SEPARADOR
                Console.WriteLine();

                // VALIDACIONES
                if (int.TryParse(cantDigita, out cantCalif) && cantCalif > 0)
                {

                    // BUCLE PARA SOLICITAR LAS NOTAS
                    while (valor++ < cantCalif)
                    {
                        // SOLICITA LAS NOTAS
                        Console.Write($"Favor ingrese la nota {valor}: ");
                        califDigita = Console.ReadLine();
                        
                        // SEPARADOR
                        Console.WriteLine();

                        // VALIDACIONES
                        if (int.TryParse(califDigita, out calificaciones) && calificaciones >= 7)
                        {
                            // INNCREMENTA CANTIDAD DE APROBADOS SI LA NOTA ES MAYOR O IGUAL A 7
                            aprobados++;
                        }
                        else if (int.TryParse(califDigita,out calificaciones) && calificaciones < 7)
                        {
                            // INCREMENTA CANTIDAD DE REPROBADOS SI LA NOTA ES MENOR A 7
                            reprobados++;
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO SE INTRODUZCAN DATOS INVALIDOS
                            Console.WriteLine("ERROR: Favor ingrese valores validos.");
                        }
                        
                        
                    }
                }
                else
                {
                    // MENSAJE DE ERROR EN CASO SE INTRODUZCAN DATOS INVALIDOS
                    Console.WriteLine("ERROR: Favor ingrese valores validos.");
                }

                // MUESTRA LA CANTIDAD DE ESTUDIANTES QUE ALCAZARON 7 O MAS Y LA CANTIDAD QUE SACO MENOS DE 7
                Console.WriteLine($"Estudiantes que sacaron 7 o mas: ({aprobados})");
                Console.WriteLine($"Estudiantes que sacaron menos de 7: ({reprobados})");
            }
            catch
            {
                // MENSAJE DE ERROR EN CASO SE INTRODUZCAN DATOS INVALIDOS
                Console.WriteLine("ERROR: Favor ingrese valores validos.");
            }
        }
    }
}
