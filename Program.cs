using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f,x,i;
            int suma, promedio;
            suma = 0;
            
            x = 1;
            
            int[] n = new int [4];
            for ( f=0; f<4; f++)
            {
                n[f] = int.Parse(Console.ReadLine());
                suma = suma + f;

            }
            
            promedio = suma / f;
            Console.WriteLine("datos tecleados");
            

            for (i = 0; i < 4; i++)
            {
                
                Console.WriteLine(n[i]);
                
            }

            
            promedio = suma /f;

            Console.WriteLine("promedio");
            Console.Write(promedio);
        }
    }
}
