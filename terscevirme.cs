using System;

namespace ters_cevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello world";
            Customreverse(word);        

        }


        static void Customreverse(string str)
        {
            string[] array = str.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                char[] word1 = array[i].ToCharArray();
                string word2 = string.Empty;

                for (int b = word1.Length - 1; b >= 0; i--)
                {
                    word2 += word1[b];
                }
                Console.WriteLine(word2);
            }
        }
    }
}
