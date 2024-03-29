/*
Approach:
for each element in the row, we know that the maximum path will be the sum of his current value + Math.Max(parents).

Use dynamic programming to solve this problem, storing the maximum path in each node.

Notice that both first and last spot from each line has only one parent, thats why we use those else-if statements.
Could avoid them by iterating through 1 <= col < numColumns - 1...

*/

using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe018 : IGet
    {
        public static List<List<int>> triangle;
        public void Get()
        {
            triangle = GetTriangle();
            //Print(triangle);
            MaximumPath();
            //Print(triangle);

            int answer = triangle.Last().Max();
            Console.WriteLine("Answer is : " + answer);
        }

        public static void MaximumPath()
        {
            int numLines = triangle.Count;

            for(int row = 1; row < numLines; row++)
            {
                int numColumns = triangle[row].Count;
                //first and last has only one parent
                triangle[row][0] += triangle[row - 1][0];
                triangle[row][numColumns - 1] += triangle[row - 1][numColumns - 1 - 1];
                for(int col = 1; col < numColumns - 1; col++)
                    triangle[row][col] += Math.Max(triangle[row - 1][col], triangle[row - 1][col - 1]);
            }
        } 

        private static void Print(List<List<int>> triangle)
        {
            foreach (var line in triangle)
            {
                foreach (var num in line)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<int>> GetTriangle()
        {
            List<List<int>> triangle = new List<List<int>>();
            string basePath = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);
            string path = Path.Combine(basePath, "..", "..", "..", "src", "pe018", "pe018.txt");

            List<string> lines = new List<string>();

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Trim().Length > 0) 
                        lines.Add(s);
                }
            }

            foreach(string line in lines)
            {
                var nums = line.Split(" ");
                var triangleLine = new List<int>();
                foreach(string num in nums)
                {
                    triangleLine.Add(int.Parse(num));
                }
                triangle.Add(triangleLine);
            }

            return triangle;
            
        }

    }
}