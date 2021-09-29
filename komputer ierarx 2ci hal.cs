using System;

namespace computer_2ci_hal
{
    class Program
    {
        static void Main(string[] args)
        { 
            
           Computer computer1 = new Computer("Lenovo", "Legion", 5);

            Console.WriteLine(computer1.Putallname());
            Computer functions = new Computer("Windows-10", 512, 8, "Nvidia-Geforce", "Ryzen");

            Console.WriteLine(" ");
            Console.WriteLine(functions.Putallfunctions());
            }
        
            
        class Computer
        {
            public string Brand;
            public string Name;
            public int Version;
            public string Processor;
            public string OS;
            public int Storage;
            public int RAM;
            public string Graphics;

            public Computer()
            {
                System.Console.WriteLine("create first");
            }
            public Computer(string brand, string name, int version)
            {
                Brand = brand;
                Name = name;
                Version = version;
            }
            public Computer(string os, int storage, int ram, string graphics, string processor)
            {
                OS = os;
                Storage = storage;
                RAM = ram;
                Graphics = graphics;
                Processor = processor;
            }
            public string Putallname()
            {
                return $"{Brand},{Name},{Version}";
            }
            public string Putallfunctions()
            {
                return $"{OS},{Storage},{RAM},{Graphics},{Processor}";
            }
        }
    }
}
    

