//using Tarea1;
//using System;

namespace Tareas_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int opcion2;
           // do
            //{
                Console.WriteLine("============================");
                Console.WriteLine("     TAREAS DEL MODULO 1");
                Console.WriteLine("============================");
                Console.WriteLine("Ingrese opciòn de tareas:");
                Console.WriteLine("------------------------");
                Console.WriteLine("( 1 ) : La Calculadora");
                Console.WriteLine("( 2 ) : Reto de Bucles");
                Console.WriteLine("( 3 ) : Reto de Arrays");
                Console.WriteLine("( 4 ) : Buscar Duplicados en un Array");
                Console.WriteLine("( 5 ) : Salir");

                int opcion;

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("numero 1");
                        double numero1=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("numero 2");
                        double numero2 = Convert.ToDouble(Console.ReadLine());
                        //Console.WriteLine("+ - * /");
                    int operacion;
                    //char operacion = Console.ReadLine()[0];
                    Console.WriteLine("( 1 ) : Suma");
                    Console.WriteLine("( 2 ) : Resta");
                    Console.WriteLine("( 3 ) : Multiplicaion");
                    Console.WriteLine("( 4 ) : Division");
                    Console.WriteLine("( 5 ) : Salir");
                    operacion = Convert.ToInt32(Console.ReadLine());

                    double resultado = 0;
                    switch (operacion)
                    {
                        case 1:
                                resultado = numero1 + numero2;
                                Console.WriteLine(resultado);
                                break;
                        case 2:
                                resultado = numero1 - numero2;
                                Console.WriteLine(resultado);
                                break;
                        case 3:
                            //if (numero1 >= 0)
                            //{
                                resultado = numero1 * numero2;
                                Console.WriteLine(resultado);
                            //}
                            //else
                            //{
                                break;
                        //}
                        case 4:
                            resultado = numero1 / numero2;
                            Console.WriteLine(resultado);
                            break; 

                    }




                    break;
                    case 2:
                    Console.WriteLine("EL mismo patron que hicimos con while pero con FOR y usando el mismo número ingresado :");
                    Console.WriteLine("Ingrese el valor para cuadrado de patrones");
                    int ValorNumero;
                    ValorNumero = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= ValorNumero; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j <= i)
                            { Console.Write(j + " "); }
                            else
                            { Console.Write("*" + " "); }
                        }
                        Console.WriteLine();
                    }
                    break;
                    case 3:
                            Console.WriteLine("tarea 3 RETO DE ARRAYS");
                            Console.WriteLine("=========================\n"); 
                            Console.WriteLine("SISTEMA DE CALIFICACIONES");
                            Console.WriteLine("=========================\n");
                            double[] calificaciones = new double[10];
                        /*if (calificaciones == null || calificaciones == 0)
                        {
                            Console.WriteLine("vacio");
                        }
                        else
                        {
                            Console.WriteLine("tiene contenido");
                        }*/

                            int eleccion;
                        //--------------
                        Console.WriteLine("------------------");
                        IngresarCalificaciones(calificaciones);
                        Console.WriteLine("( 1 ) : Mostrar Calificaciones");
                        Console.WriteLine("( 2 ) : Cálculos Estadísticos");
                        Console.WriteLine("( 3 ) : Ordenar Calificaciones");
                        Console.WriteLine("( 4 ) : Mostrar Rango de Calificaciones");
                        Console.WriteLine("( 5 ) : Salir");
                        eleccion = Convert.ToInt32(Console.ReadLine());
                        switch (eleccion)
                        {
                        case 1:
                            MostrarCalificaciones(calificaciones); 
                            break;
                        case 2:
                            CalcularEstadisticas(calificaciones); 
                            break;
                        case 3:
                            OrdenarCalificaciones(calificaciones); 
                            break;
                        case 4:
                            MostrarDistribucionRangos(calificaciones); 
                            break;
                        case 5:
                            break;
                        }
                    break;
                    //---------------
                    // Método para ingresar calificaciones
                    static void IngresarCalificaciones(double[] calificaciones)
                    {
                        Console.WriteLine("Ingrese las calificaciones de los 10 estudiantes (0-100):");

                        for (int i = 0; i < calificaciones.Length; i++)
                        {
                            bool entradaValida = false;

                            while (!entradaValida)
                            {
                                Console.Write($"Estudiante {i + 1}: ");
                                string entrada = Console.ReadLine();

                                if (double.TryParse(entrada, out double calificacion) && calificacion >= 0 && calificacion <= 100)
                                {
                                    calificaciones[i] = calificacion;
                                    entradaValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error: Ingrese un valor numérico entre 0 y 100.");
                                }
                            }
                        }

                        Console.WriteLine();
                    }

                    // Método para mostrar todas las calificaciones
                    static void MostrarCalificaciones(double[] calificaciones)
                    {
                        Console.WriteLine("Calificaciones ingresadas:");

                        for (int i = 0; i < calificaciones.Length; i++)
                        {
                            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
                        }

                        Console.WriteLine();
                    }

                    // Método para calcular y mostrar estadísticas
                    static void CalcularEstadisticas(double[] calificaciones)
                    {
                        // Calcular promedio
                        double suma = 0;
                        foreach (double calificacion in calificaciones)
                        {
                            suma += calificacion;
                        }
                        double promedio = suma / calificaciones.Length;

                        // Encontrar calificación más alta y más baja
                        double maxima = calificaciones[0];
                        double minima = calificaciones[0];

                        foreach (double calificacion in calificaciones)
                        {
                            if (calificacion > maxima)
                                maxima = calificacion;

                            if (calificacion < minima)
                                minima = calificacion;
                        }

                        // Contar aprobados
                        int aprobados = 0;
                        foreach (double calificacion in calificaciones)
                        {
                            if (calificacion >= 60)
                                aprobados++;
                        }

                        // Mostrar resultados
                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine($"- Promedio: {promedio:F2}");
                        Console.WriteLine($"- Calificación más alta: {maxima}");
                        Console.WriteLine($"- Calificación más baja: {minima}");
                        Console.WriteLine($"- Estudiantes aprobados: {aprobados} de {calificaciones.Length}");
                        Console.WriteLine($"- Porcentaje de aprobación: {(double)aprobados / calificaciones.Length * 100:F2}%");
                        Console.WriteLine();
                    }

                    // Método para ordenar y mostrar calificaciones
                    static void OrdenarCalificaciones(double[] calificaciones)
                    {
                        // Crear una copia para no modificar el array original
                        double[] calificacionesOrdenadas = new double[calificaciones.Length];
                        Array.Copy(calificaciones, calificacionesOrdenadas, calificaciones.Length);

                        // Ordenar la copia
                        Array.Sort(calificacionesOrdenadas);

                        // Mostrar calificaciones ordenadas
                        Console.WriteLine("Calificaciones ordenadas (menor a mayor):");
                        for (int i = 0; i < calificacionesOrdenadas.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {calificacionesOrdenadas[i]}");
                        }

                        Console.WriteLine();
                    }

                    // Método para mostrar distribución por rangos
                    static void MostrarDistribucionRangos(double[] calificaciones)
                    {
                        int[] rangos = new int[5]; // Para almacenar conteo por rangos

                        // Contar calificaciones por rango
                        foreach (double calificacion in calificaciones)
                        {
                            if (calificacion < 60)
                                rangos[0]++; // Reprobado
                            else if (calificacion < 70)
                                rangos[1]++; // Suficiente
                            else if (calificacion < 80)
                                rangos[2]++; // Bien
                            else if (calificacion < 90)
                                rangos[3]++; // Notable
                            else
                                rangos[4]++; // Excelente
                        }

                        // Mostrar distribución
                        Console.WriteLine("Distribución por rangos:");
                        Console.WriteLine($"- Reprobado (0-59): {rangos[0]} estudiantes");
                        Console.WriteLine($"- Suficiente (60-69): {rangos[1]} estudiantes");
                        Console.WriteLine($"- Bien (70-79): {rangos[2]} estudiantes");
                        Console.WriteLine($"- Notable (80-89): {rangos[3]} estudiantes");
                        Console.WriteLine($"- Excelente (90-100): {rangos[4]} estudiantes");

                        // Visualización gráfica simplificada
                        Console.WriteLine("\nGráfica de distribución:");
                        string[] etiquetas = { "Reprobado", "Suficiente", "Bien    ", "Notable ", "Excelente" };

                        for (int i = 0; i < rangos.Length; i++)
                        {
                            Console.Write($"{etiquetas[i]}: ");
                            for (int j = 0; j < rangos[i]; j++)
                            {
                                Console.Write("■ ");
                            }
                            Console.WriteLine($" ({rangos[i]})");
                        }
                    }
                    //break;
                    case 4:
                        Console.WriteLine("INGRESE 10 NUMEROS PARA BUSCAR DUPLICADOS EN UN ARRAY");
                    int[] arr = new int[10];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        bool entradanum = false;

                        while (!entradanum)
                        {
                            Console.Write($"Número {i + 1}: ");
                            string ingreso = Console.ReadLine();

                            if (int.TryParse(ingreso, out int numero) && numero >= 0 && numero <= 100)
                            {
                                arr[i] = numero;
                                entradanum = true;
                            }
                            else
                            {
                                Console.WriteLine("Error: Ingrese un valor numérico entre 0 y 100.");
                            }
                        }
                    }

                    Console.WriteLine();

                    //---------------
                    //int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };

                    //------------
                    //int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };

                           var set = new HashSet<int>();
                           var duplicates = arr.Where(i => !set.Add(i)).Distinct();
                    Console.WriteLine("Los números duplicados son:");
                    Console.WriteLine(String.Join(", ", duplicates));

                    break;
                    case 5:
                        Console.WriteLine("Es opcion 5 SALIR");
                        break;
                    default:
                        Console.WriteLine("No es opcoin valida");
                        break;
                }
                //Console.WriteLine("Continua? S/N");
               // opcion2 = Convert.ToInt32(Console.ReadLine());
            //} while (opcion2 = 1);

            Console.WriteLine("Fin del programa");
 
            //Console.ReadKey();


        }
    }
}
