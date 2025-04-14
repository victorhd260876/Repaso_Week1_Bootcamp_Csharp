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
                        Console.WriteLine("+ - * /");
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
                        Console.WriteLine("Es opcion 3");
                        break;
                    case 4:
                        Console.WriteLine("Es opcion 4");
                        break;
                    case 5:
                        Console.WriteLine("Es opcion 5");
                        break;
                    default:
                        Console.WriteLine("No es opcoin valida");
                        break;
                }
                //Console.WriteLine("Continua? S/N");
               // opcion2 = Convert.ToInt32(Console.ReadLine());
            //} while (opcion2 = 1);

            Console.WriteLine("Saliendo de la aplicacion");
 
            //Console.ReadKey();


        }
    }
}
