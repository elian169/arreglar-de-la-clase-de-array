using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string[] linea = new string[1];          
            int n;
           
            Console.Write("Ingrese multiplicador: ");
            linea[0] = Convert.ToString(Console.ReadLine());
                        
            n = int.Parse(linea[0]);
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();
        }
    }
}
