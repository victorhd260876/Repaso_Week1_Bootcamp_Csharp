namespace Repaso_Week1_Bootcamp_Csharp;

internal class Program
{
	static void Main(string[] args)
	{
		int primerNumero;
		int segundoNumero;
		int tercerNumero;
		int mayor;
		Console.WriteLine("");
		Console.WriteLine("============================");
		Console.WriteLine("Cual es el numero mayor de 3 numeros ");
		Console.WriteLine("============================");
		Console.WriteLine("Ingrese los 3 numeros ");
		primerNumero = Convert.ToInt32(Console.ReadLine());
		segundoNumero = Convert.ToInt32(Console.ReadLine());
		tercerNumero = Convert.ToInt32(Console.ReadLine());

		if (primerNumero > segundoNumero)
		{
			mayor = primerNumero;
		}
		else
		{
			mayor=segundoNumero;
		}
		if (mayor > tercerNumero)
		{
			Console.WriteLine("Cel número mayor es: " + mayor);
		}
		else
		{
			Console.WriteLine("El número mayor es: " + tercerNumero);
		}
		/*
			// Escribir la logica del programa
			Console.WriteLine("");
		Console.WriteLine("============================");
		Console.WriteLine("Dame la opcion de que area es para comprobar ");
		Console.WriteLine("============================");*/
	}
}