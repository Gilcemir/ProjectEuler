﻿namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            var menu = Menu();

            while (menu.ToLower() != "x")
            {
                var className = "Project.pe";
                try
                {
                    className += FormatString(menu);
                    var instanceOfClass = GetClass(className);
                    instanceOfClass.Get();
                }
                catch
                {
                    Console.WriteLine("Not implemented yet.");
                }

                menu = Menu();
            }
        }

        private static string FormatString(string menu)
        {
            return int.Parse(menu).ToString("D3");
        }
        
        private static IGet GetClass(string className)
        {
            var type = Type.GetType(className);
            return Activator.CreateInstance(type) as IGet; 
        }
        
        private static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine(@"Enter the ID of the problem (1, 2, 3 etc): (X to exit!)");

            Console.WriteLine();

            return Console.ReadLine().ToLower();
        }
    }
}