//using Tarea1;
//using System;

namespace Tareas_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("     TAREAS DEL MODULO 1");
            Console.WriteLine("============================");

            Console.WriteLine("Ingrese opciòn de tareas:");
            Console.WriteLine("------------------------");
            Console.WriteLine("( 1 ) : La Calculadora");
            Console.WriteLine("( 2 ) : Reto de Bucles)");
            Console.WriteLine("( 3 ) : Reto de Arrays");
            Console.WriteLine("( 4 ) : Buscar Duplicados en un Array");
            Console.WriteLine("( 5 ) : Salir");

            int opcion;
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Console.WriteLine("Es opcion 1");
                    //Primera_aplicación_Curso_C_ caso1 = new Primera_aplicación_Curso_C_();
                    //caso1.HolaMundo;
                    calculadora tareacalculadora = new calculadora();
                    tareacalculadora.calculadora();
                    break;
                case 2:
                    Console.WriteLine("Es opcion 1");
                    break;
                case 3:
                    Console.WriteLine("Es opcion 1");
                    break;
                case 4:
                    Console.WriteLine("Es opcion 1");
                    break;
                case 5:
                    Console.WriteLine("Es opcion 1");
                    break;
                default:
                    Console.WriteLine("No es opcoin valida");
                    break;
            }

            Console.WriteLine("Saliendo de la aplicacion");




            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
        }
    }
}
