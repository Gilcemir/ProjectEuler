using System.Diagnostics;
using ProjectEuler.Contracts;

namespace ProjectEuler
{
    class Program
    {
        public static void Main(string[] args)
        {
            var menu = Menu();

            while (menu.ToLower() != "x")
            {
                var className = "ProjectEuler.pe";
                try
                {
                    className += FormatString(menu);
                    var instanceOfClass = GetClass(className);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Console.WriteLine("Starting exectution...\n");
                    instanceOfClass.Get();
                    Console.WriteLine("\nEnded...");
                    Console.WriteLine($"Elapsed time is {stopwatch.ElapsedMilliseconds} ms");
                    stopwatch.Stop();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not implemented yet.");
                    Console.WriteLine("Exception message if exists: " + e.Message);
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