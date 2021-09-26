using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("massivin sayi");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("ededi daxil et");
                int z = int.Parse(Console.ReadLine());

                Console.WriteLine("massivin ededlerini daxil et");
                int[] array1 = new int[x];
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine($"eded[{i}]:");
                    array1[i] = int.Parse(Console.ReadLine());

                    if (array1[i] == z)
                    {
                        Console.WriteLine("beraber eded var");
                    }
                    else
                    {
                        Console.WriteLine("beraber eded yoxdu");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("teyin olunmayib");
            }
        }
    }
}
    
