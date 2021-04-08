using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[1];


            Console.WriteLine("El nombre debe tener un maximo de 10 caracteres");
            Console.WriteLine("Introduzca su nombre: ");
            Nombre[0] = Convert.ToString(Console.ReadLine());

            if (Nombre[0].Length > 10)
            {
                Console.WriteLine("Longitud erronea, reinicie el programa para empezar de nuevo. ");
            }
            else if (Nombre[0].Length < 11 && Nombre[0].Length > 9)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1) + " " + Nombre[0].Substring(5, 1) + " " + Nombre[0].Substring(6, 1) + " " + Nombre[0].Substring(7, 1) + " " + Nombre[0].Substring(8, 1) + " " + Nombre[0].Substring(9, 1));
            }
            else if (Nombre[0].Length < 10 && Nombre[0].Length > 8)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1) + " " + Nombre[0].Substring(5, 1) + " " + Nombre[0].Substring(6, 1) + " " + Nombre[0].Substring(7, 1) + " " + Nombre[0].Substring(8, 1));
            }
            else if (Nombre[0].Length < 9 && Nombre[0].Length > 7)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1) + " " + Nombre[0].Substring(5, 1) + " " + Nombre[0].Substring(6, 1) + " " + Nombre[0].Substring(7, 1));
            }
            else if (Nombre[0].Length < 8 && Nombre[0].Length > 6)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1) + " " + Nombre[0].Substring(5, 1) + " " + Nombre[0].Substring(6, 1));
            }
            else if (Nombre[0].Length < 7 && Nombre[0].Length > 5)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1) + " " + Nombre[0].Substring(5, 1));
            }
            else if (Nombre[0].Length < 6 && Nombre[0].Length > 4)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1) + " " + Nombre[0].Substring(4, 1));
            }
            else if (Nombre[0].Length < 5 && Nombre[0].Length > 3)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1) + " " + Nombre[0].Substring(3, 1));
            }
            else if (Nombre[0].Length < 4 && Nombre[0].Length > 2)
            {
                Console.WriteLine(Nombre[0].Substring(0, 1) + " " + Nombre[0].Substring(1, 1) + " " + Nombre[0].Substring(2, 1));
            }
            else
            {
                Console.WriteLine("Introduzca un nombre mas largo");
            }


            Console.ReadKey();

        }
    }
}

