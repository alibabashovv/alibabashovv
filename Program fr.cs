using System;
using System.Collections;

namespace Basketlist1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            PineApple pineApple = new PineApple();
            Lemon lemon = new Lemon();


            ArrayList arraylist = new ArrayList();

            arraylist.Add(apple);
            arraylist.Add(pineApple);
            arraylist.Add(lemon);

            Console.WriteLine("count:    ");
            Console.WriteLine(arraylist.Count);

            foreach (DictionaryEntry item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
