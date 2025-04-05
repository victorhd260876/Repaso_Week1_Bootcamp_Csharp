namespace Repaso_Week1_Bootcamp_Csharp;

internal class Program
{
	static void Main(string[] args)
	{
		int primerNumero;
		int segundoNumero;
		int tercerNumero;
		int mayor;
		int basetriangulo;
		int alturatriangulo;
		int areatriangulo;

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
		// Escribir la logica del programa
		Console.WriteLine("");
		Console.WriteLine("============================");
		Console.WriteLine("Cálculo del área del triángulp ");
		Console.WriteLine("============================");
		Console.WriteLine("Ingrese BASE : ");
		basetriangulo = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese ALTURA : ");
		alturatriangulo = Convert.ToInt32(Console.ReadLine());

		if (basetriangulo > 0 && alturatriangulo > 0)
		{
			areatriangulo = (basetriangulo * alturatriangulo) / 2;
			Console.WriteLine("El área del triángulo es: " + areatriangulo);
		}
	}
}