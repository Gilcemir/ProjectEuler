using System.Reflection;
using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe022 : IGet
    {
        public void Get()
        {
                List<string> names = GetNames();
                long result = names
                                .Select((item, index) => NameValue(item) *(index + 1))
                                .Sum();

                Console.WriteLine(result);
        }

        static List<string> GetNames()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);
            string path = Path.Combine(basePath, "..", "..", "..", "src", "pe022", "p022_names.txt");
            string line = "";

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Trim().Length > 0) 
                    line = s;
                }
            }
            var names = line.Split(",")
                            .Select(x => x.Replace("\"", "")
                            .Trim())
                            .OrderBy(x=> x)
                            .ToList();
            return names;
        }

        static int NameValue(string name)
        {
            int sum = 0;

            foreach(char c in name)
            {
                
                int charValue = c - 'A' + 1;
               
                sum+= charValue;
            }

            return sum;
        }
    }
}