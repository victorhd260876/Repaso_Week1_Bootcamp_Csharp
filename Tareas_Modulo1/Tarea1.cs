using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Tarea1
    {
        static int Main(string[] args)
        {
            int a, b;
            double choice;
            float result;

            Console.WriteLine("enter 1st number= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number= ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Subtraction ");
            Console.WriteLine("3. Multiplication ");
            Console.WriteLine("4. Division ");
            Console.WriteLine("5. Average ");
            Console.WriteLine("6. Percentage ");
            Console.WriteLine("7. Exit ");
            Console.WriteLine("8. Select your choice (1-7): ");
            choice = double.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                case 5:
                    result = (a + b) / 2;
                    break;
                case 6:
                    result = (a / b) * 100;
                    break;
                case 7:
                    result = 0;
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            Console.WriteLine(a.ToString() + " " + choice + " " + b.ToString() + " = " + result.ToString());
            Console.ReadKey();
        }
    }
