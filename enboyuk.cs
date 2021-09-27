using System;

namespace enboyukeded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("en boyuk eded"+ enboyukeded(200, 234, 500, 2100, 1300, 670)) ;

        }

        static int enboyukeded(params int[] arry)
        {
            int large = 0;
            {
                foreach (int item in arry)
                {

                    if (item > large)
                    {
                        large = item;
                    }
                }
                return large;
            }
        }
    }
}

	


            