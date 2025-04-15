using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    //inicio de clase Ejecutar    
    internal class Ejecutar
    {
        static void Main(string[] args)
        {
            int longitud;
            Console.WriteLine("=====================================================");
            Console.WriteLine("          GENERADOR DE CONTRASEÑA ALEATORIA");
            Console.WriteLine("=====================================================");

            Console.Write("\nIngrese la longitud de la contraseña: ");
            longitud = int.Parse(Console.ReadLine());
            //imprime valor de la contraseña generada considerando el valor ingresado y llamando a la clase password
            Console.WriteLine("\nLa contraseña generada es: " + Password.GenerarPassword(longitud));
            //permite ver el valor en la consola
            Console.ReadKey();
        }
    }

    //inicio de clase password
    public static class Password
    {
        public static string GenerarPassword(int longitud)
        {
            //declaracion de variables
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            //instancia para generador clase aleatorio
            Random EleccionAleatoria = new Random();
            //generando cada uno de los caracteres para construir la contraseña
            for (int i = 0; i < longitud; i++)
            {
                //genera numero aleatorio entre el metodo next
                int LetraAleat = EleccionAleatoria.Next(0, 100);

                int NumeroAleat = EleccionAleatoria.Next(0, 9);
                //si LetraAleat es menor al largo del array letras
                if (LetraAleat < letras.Length)
                {
                    //se suma a la cadena de la variable contraseña
                    contraseña += letras[LetraAleat];
                }
                else
                {
                    //caso contrario el numero aleatorio se suma a la cadena de la variable contraseña
                    contraseña += NumeroAleat.ToString();
                }
            }
            //imprime cadena "contraseña"
            return contraseña;
        }
    }
}
