using System;

namespace computer_hier
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer("Lenovo","Legion",5);
            
            Console.WriteLine(computer1.Putallname());
            Computer functions = new Computer("Windows-10",512,8, "Nvidia-Geforce","Ryzen");
            
            Console.WriteLine(" ");
            Console.WriteLine(functions.Putallfunctions());



        }
    }
}   
        
