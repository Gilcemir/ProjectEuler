namespace Project
{
    public class pe017 : IGet
    {
        public void Get()
        {
            List<string> nums = GetNums();
            //foreach(string num in nums)
            //    Console.WriteLine(num);
            Console.WriteLine(Sum(nums));
        }


        static List<string> GetNums()
        {
            string path = Directory.GetCurrentDirectory() + "\\src\\pe017\\pe017.txt";

            List<string> nums = new List<string>();

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Trim().Length > 0) nums.Add(s);
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i].Replace(" ", "").Replace("-", "");
            }
            return nums;
        }

        public static int Sum(List<string> nums)
        {
            int sum = 0;
            foreach(string num in nums)
                sum += num.Length;
            return sum;
        }
    }
}