using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            float[] variable1 = new float[5];
            
            Console.WriteLine("instroduzca el primer numero: ");
            variable1[0] = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("instroduzca el segundo numero: ");
            variable1[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("instroduzca el tercer numero: ");
            variable1[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("instroduzca el cuarto numero: ");
            variable1[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("instroduzca el quinto numero: ");
            variable1[4] = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("El quinto numereo introducido fue: " + variable1[4]);
            Console.WriteLine("El cuarto numereo introducido fue: " + variable1[3]);
            Console.WriteLine("El tercer numereo introducido fue: " + variable1[2]);
            Console.WriteLine("El segundo numereo introducido fue: " + variable1[1]);
            Console.WriteLine("El primer numereo introducido fue: " + variable1[0]);








            Console.ReadKey();


        }
    }
}
