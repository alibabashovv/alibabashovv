using System;

namespace computer_hier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brand, Name, Version");
            Computer computer1 = new Computer();
            computer1.Brand = "Lenovo";
            computer1.Name = " Legion-5";
            computer1.Version =5;
            Console.WriteLine(computer1.Putallname());
            Computer functions = new Computer();
            functions.OS = "Windows-10";
            functions.Storage = 512;
            functions.RAM = 8;
            functions.Graphics = "Nvidia-Geforce";
            functions.Processor = "Ryzen";
            Console.WriteLine(" ");
            Console.WriteLine("OS, Storage, RAM, Graphics, Processor");
            Console.WriteLine(functions.Putallfunctions());



        }
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

        public string Putallname()
        {
            return $"{Brand},{Name},{Version}";

        }

        public string Putallfunctions()
        {
            return $"{OS},{Storage},{RAM},{Graphics},{Processor}";
        }
    }
        
