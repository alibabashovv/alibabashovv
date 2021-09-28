using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello world";
            Customreverse(word1);

        }


        static void Customreverse(string str)
        {
            string[] array = str.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                char[] word1 = array[i].ToCharArray();
                string word2 = string.Empty;

                for (int b = word1.Length - 1; b >= 0; b--)
                {
                    word2 += word1[b];
                }
                Console.WriteLine(word2);
            }
        }
    }
}
    
