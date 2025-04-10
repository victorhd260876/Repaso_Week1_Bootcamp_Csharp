namespace WhileLoop;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido a los while loops");
        /*	// Escribir un bucle infinito
			// int contador = 0;
			// while (contador <= 10)
			// {
			//     Console.WriteLine("El valor es: " + contador);
			//     contador++;
			// }
			// Console.WriteLine("Se acabo el bucle");

			// Tabla de multiplicar
			// 10 = 10x1, 10x2, 10x3.... 10x12
/*			int contadorTabla = 1;
			Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
			int valorTabla;
			int resultado;
			valorTabla = Convert.ToInt32(Console.ReadLine());
			while (contadorTabla <= 12)
			{

				resultado = valorTabla * contadorTabla;
				Console.WriteLine("La tabla del numero: " + valorTabla + " es igual a " + valorTabla + "x" + contadorTabla + " = " + resultado);
				contadorTabla++;
			}

			// Imprimir cuadrado con patrones de 1 al 5
			int inicio = 1;
			while (inicio <= 5)
			{
				int b = 1;
				while (b <= 5)
				{
					Console.Write(b + " ");
					b++;
				}
				Console.WriteLine();
				inicio++;
			}
		*/




        // Ejercicio de while loop
        // 1 * * * *
        // 1 2 * * *
        // 1 2 3 * *
        // 1 2 3 4 *
        // 1 2 3 4 5
        Console.WriteLine("Ingrese el valor para cuadrado de patrones");
        int ValorNumero;
        ValorNumero = Convert.ToInt32(Console.ReadLine());
        int inicio = 1;
        while (inicio <= ValorNumero)
        {
            int inicio2 = 1;
            while (inicio2 <= ValorNumero)
            {
                if (inicio2 <= inicio)
                { Console.Write(inicio2 + " "); }
                else
                { Console.Write("*" + " "); }
                inicio2++;
            }
            Console.WriteLine();
            inicio++;
        }

        /*	int contadorDo = 1;
			do
			{
				Console.WriteLine(contadorDo);
				contadorDo++;
			} while (contadorDo <= 6);

			Console.ReadKey();*/


        // Crear un bucle tipo for
        //for (int i = 1; i <= 10; i++)
        //{
        //	Console.WriteLine("El valor del bucle for es: " + i);
        // for (int j = 0; j < i; j++)
        // {
        //     Console.Write(j + " ");
        // }
        //}

        // 1 Challenge
        // Write a program in C# Sharp to display the multiplication table of a given integer.
        //     Test Data:
        // Input the number(Table to be calculated) : 15
        // Expected Output :
        // 15 X 1 = 15...
        // ...
        // 15 X 10 = 150

        Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
        int Numfor;
        int ResultFor;
        Numfor = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            ResultFor = Numfor * i;
            Console.WriteLine("La tabla del numero: " + Numfor + " es igual a " + Numfor + "x" + i + " = " + ResultFor);
        }


        // 2 Challenge
        Console.WriteLine("EL mismo patron que hicimos con while pero con FOR y usando el mismo número ingresado :");

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




    }
}