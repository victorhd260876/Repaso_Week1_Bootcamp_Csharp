namespace Week2_Arrays_Uni;

internal class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("ARRAYS UNIDIMENSIONALES EN C#");
        // Console.WriteLine("============================\n");
        //
        // // 1. Declaración e inicialización de un array
        // Console.WriteLine("1. Declaración e inicialización:");
        //
        // // Forma 1: Declarar y luego inicializar
        // int[] numeros = new int[5]; // Array de 5 enteros
        // numeros[0] = 10;
        // numeros[1] = 20;
        // numeros[2] = 30;
        // numeros[3] = 40;
        // numeros[4] = 50;
        //
        // // Forma 2: Declarar e inicializar en una línea
        // int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };
        //
        // // Forma 3: Inicialización implícita
        // string[] nombres = { "Ana", "Juan", "Pedro", "María", "Luis" };
        //
        // // 2. Acceso a los elementos
        // Console.WriteLine("\n2. Acceso a los elementos:");
        // Console.WriteLine($"El primer número es: {numeros[0]}"); // 10
        // Console.WriteLine($"El tercer nombre es: {nombres[2]}"); // Pedro
        // Console.WriteLine($"El ultimo nombre es: {nombres[4]}"); // Luis
        //
        // // 3. Obtener la longitud del array
        // Console.WriteLine("\n3. Longitud del array:");
        // Console.WriteLine($"El array de números tiene {numeros.Length} elementos");
        //
        // // 4. Recorrer un array con un bucle for
        // Console.WriteLine("\n4. Recorrer array con for:");
        // for (int i = 0; i < nombres.Length; i++)
        // {
        //     Console.WriteLine($"Índice {i}: {nombres[i]}");
        // }
        //
        // // 5. Recorrer un array con foreach
        // Console.WriteLine("\n5. Recorrer array con foreach:");
        // foreach (string nombre in nombres)
        // {
        //     Console.WriteLine(nombre);
        // }
        //
        // // 6. Operaciones comunes
        // Console.WriteLine("\n6. Operaciones comunes:");
        //
        // // Sumar todos los elementos
        // int suma = 0;
        // foreach (int numero in numeros)
        // {
        //     suma += numero;
        // }
        // Console.WriteLine($"La suma de todos los números es: {suma}");
        //
        // // Encontrar el valor máximo
        // int maximo = numeros[0];
        // for (int i = 1; i < numeros.Length; i++)
        // {
        //     if (numeros[i] > maximo)
        //         maximo = numeros[i];
        // }
        // Console.WriteLine($"El valor máximo es: {maximo}");
        //
        // // 7. Métodos de Array
        // Console.WriteLine("\n7. Métodos del Array:");
        //
        // // Ordenar un array
        // int[] desordenados = { 5, 2, 8, 1, 9 };
        // Console.Write("Array desordenado: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // Array.Sort(desordenados);
        // Console.Write("\nArray ordenado: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // // Invertir un array
        // Array.Reverse(desordenados);
        // Console.Write("\nArray invertido: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // // Buscar en un array
        // string[] frutas = { "manzana", "pera", "naranja", "plátano", "uva" };
        // int indice = Array.IndexOf(frutas, "naranja");
        // Console.WriteLine($"\nLa naranja está en el índice: {indice}");
        //
        // // Copiar un array
        // int[] copiaNumeros = new int[numeros.Length];
        // Array.Copy(numeros, copiaNumeros, numeros.Length);
        // Console.Write("\nArray copiado: ");
        // foreach (int num in copiaNumeros)
        //     Console.Write($"{num} ");
        //
        // Console.WriteLine("\n");

        /*
        RETO: SISTEMA DE CALIFICACIONES

        Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
        diferentes operaciones estadísticas.

        Requisitos:
        1. Crear un array para almacenar las calificaciones de 10 estudiantes (valores entre 0 y 100)
        2. Implementar las siguientes funcionalidades:
           - Calcular el promedio de calificaciones
           - Encontrar la calificación más alta y la más baja
           - Calcular cuántos estudiantes aprobaron (calificación >= 60)
           - Mostrar las calificaciones en orden ascendente
           - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
             * 0-59 (Reprobado)
             * 60-69 (Suficiente)
             * 70-79 (Bien)
             * 80-89 (Notable)
             * 90-100 (Excelente)

        Extra (opcional):
        - Permitir que el usuario ingrese las calificaciones
        - Implementar un menú para que el usuario elija la operación a realizar
        */
        Console.WriteLine("SISTEMA DE CALIFICACIONES");
        Console.WriteLine("=========================\n");

        // 1. Declarar el array de calificaciones
        double[] calificaciones = new double[10];
        string bienvenida;
        // 2. Ingresar las calificaciones (puede ser manual o automático)
        IngresarCalificaciones(calificaciones);

        // // 3. Mostrar todas las calificaciones
        MostrarCalificaciones(calificaciones);

        // // 4. Calcular y mostrar estadísticas
        CalcularEstadisticas(calificaciones);

        // // 5. Ordenar y mostrar calificaciones
        OrdenarCalificaciones(calificaciones);

        // // 6. Mostrar distribución por rangos
        MostrarDistribucionRangos(calificaciones);
    }

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
}