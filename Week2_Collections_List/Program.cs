﻿namespace Week2_Collections_List;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LIST<T> EN C#");
        Console.WriteLine("============\n");

        // 1. Creación e inicialización
        Console.WriteLine("1. Creación e inicialización:");

        // Forma 1: Constructor vacío
        List<int> numeros = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        // Forma 2: Constructor con capacidad inicial
        List<string> nombres = new List<string>(5);
        nombres.Add("Ana");
        nombres.Add("Juan");

        // Forma 3: Inicialización de colección
        List<double> precios = new List<double> { 19.99, 29.99, 9.99, 49.99 };

        // Forma 4: A partir de un array existente
        string[] arrayDeFrutas = { "Manzana", "Banana", "Naranja" };
        List<string> frutas = new List<string>(arrayDeFrutas);

        // 2. Acceso a elementos
        Console.WriteLine("\n2. Acceso a elementos:");
        Console.WriteLine($"Primer número: {numeros[0]}");
        Console.WriteLine($"Segunda fruta: {frutas[1]}");

        // 3. Modificar elementos
        Console.WriteLine("\n3. Modificar elementos:");
        precios[1] = 39.99;  // Cambiar el segundo precio
        Console.WriteLine("Lista de precios actualizada:");
        foreach (double precio in precios)
            Console.Write($"{precio} ");

        // 4. Añadir y eliminar elementos
        Console.WriteLine("\n\n4. Añadir y eliminar elementos:");

        // Añadir varios elementos
        numeros.AddRange(new int[] { 40, 50, 60 });

        // Insertar en una posición
        numeros.Insert(1, 15);  // Insertar 15 en la posición 1

        Console.WriteLine("Lista después de añadir elementos:");
        foreach (int num in numeros)
            Console.Write($"{num} ");

        // Eliminar elementos
        numeros.Remove(30);         // Eliminar el valor 30
        numeros.RemoveAt(0);        // Eliminar el primer elemento
        numeros.RemoveRange(2, 2);  // Eliminar 2 elementos desde el índice 2

        Console.WriteLine("\nLista después de eliminar elementos:");
        foreach (int num in numeros)
            Console.Write($"{num} ");

        // 5. Buscar elementos
        Console.WriteLine("\n\n5. Buscar elementos:");
        int indice = nombres.IndexOf("Juan");
        Console.WriteLine($"Índice de 'Juan': {indice}");

        bool contiene = frutas.Contains("Banana");
        Console.WriteLine($"¿La lista contiene 'Banana'?: {contiene}");

        // 6. Ordenar una lista
        Console.WriteLine("\n6. Ordenar una lista:");
        List<int> numDesorden = new List<int> { 5, 2, 8, 1, 9, 3 };

        Console.WriteLine("Lista original:");
        foreach (int num in numDesorden)
            Console.Write($"{num} ");

        numDesorden.Sort();
        Console.WriteLine("\nLista ordenada (ascendente):");
        foreach (int num in numDesorden)
            Console.Write($"{num} ");

        // Ordenar en orden descendente
        numDesorden.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("\nLista ordenada (descendente):");
        foreach (int num in numDesorden)
            Console.Write($"{num} ");

        // 7. Filtrar elementos con LINQ
        Console.WriteLine("\n\n7. Filtrar elementos con LINQ:");
        List<int> numerosFiltrados = numDesorden.Where(n => n > 3).ToList();

        Console.WriteLine("Números mayores que 3:");
        foreach (int num in numerosFiltrados)
            Console.Write($"{num} ");

        // 8. Convertir a array
        Console.WriteLine("\n\n8. Convertir a array:");
        int[] arrayDeNumeros = numeros.ToArray();
        Console.WriteLine($"Array creado con {arrayDeNumeros.Length} elementos");

        // 9. ForEach con acción
        Console.WriteLine("\n9. Uso de ForEach con una acción:");
        frutas.ForEach(fruta => Console.WriteLine($"Me gusta comer {fruta}"));

        // 10. Find, FindAll, FindIndex
        Console.WriteLine("\n10. Métodos de búsqueda avanzados:");

        // Crear una lista de personas para demostrar
        List<Persona> personas = new List<Persona>
        {
            new Persona { Nombre = "Carlos", Edad = 25, Dni  = "7163235"},
            new Persona { Nombre = "María", Edad = 32, Dni  = "7163235" },
            new Persona { Nombre = "Pedro", Edad = 17, Dni  = "7163235" },
            new Persona { Nombre = "Laura", Edad = 42, Dni  = "7163235" },
            new Persona { Nombre = "Miguel", Edad = 19, Dni  = "7163235" }
        };

  
        // Find - Encontrar la primera persona menor de 18 años
        Persona menor = personas.Find(p => p.Edad < 18);
        Console.WriteLine($"Primera persona menor de edad: {menor.Nombre}, {menor.Edad} años");

        // FindAll - Encontrar todas las personas mayores de 30 años
        List<Persona> mayores30 = personas.FindAll(p => p.Edad > 30);
        Console.WriteLine("Personas mayores de 30 años:");
        foreach (var persona in mayores30)
            Console.WriteLine($"  {persona.Nombre}, {persona.Edad} años");

        // FindIndex - Encontrar el índice de la primera persona que empieza con 'M'
        int indiceMLetra = personas.FindIndex(p => p.Nombre.StartsWith("M"));
        Console.WriteLine($"Índice de la primera persona con nombre que empieza por 'M': {indiceMLetra}");


		// Operaciones del reto
		// Crear la lista, agregar los valores y hacer las operaciones
		List<Libro> libros = new List<Libro>
		{
			new Libro { Nombre = "El principito", Precio = 25.99, Stock = 5 },
			new Libro { Nombre = "Los 4 pilares del mundo", Precio = 99.77, Stock = 3},
			new Libro { Nombre = "La Caperucita", Precio = 22.00, Stock = 10 },
			new Libro { Nombre = "La Odisea", Precio = 15.44, Stock = 100 },
			new Libro { Nombre = "Don Quijote", Precio = 35.99, Stock = 8 }

		};
        // Filtrar los libros con stock de mas de 10 unidades
        List<Libro> libros10 = libros.FindAll(m >= m.Libros);
        Console.WriteLine("Libros con stock mayor a 10:");
        foreach (var libro in libros10)
            Console.WriteLine($"  libro.Stock);

		// Filtrar el stock por precio mas grande de 10.99 soles
		// Encontrar el indice del libro que empiece con "El"
	}

	// Clase auxiliar para demostraciones
	class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Dni { get; set; }
    }

    class Libro
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}