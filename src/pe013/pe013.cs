namespace Project
{

    public class pe013
    {
        public static void Get()
        {
            List<string> nums = GetNums();
            List<List<int>> numsList = new List<List<int>>();

            foreach (string str in nums)
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < str.Length; i++)
                {
                    int digit = int.Parse(str[str.Length - 1 - i].ToString());
                    temp.Add(digit);
                }
                numsList.Add(temp);
            }
            string ans = Sum(numsList);
            Console.WriteLine($"The sum is {ans}");
            Console.WriteLine("So the first ten numbers are:");
            for (int i = 0; i < 10; i++)
                Console.Write(ans[i]);
        }


        static List<string> GetNums()
        {
            string path = Directory.GetCurrentDirectory() + "\\src\\pe013\\pe013.txt";

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
                nums[i] = nums[i].Substring(0, 50);
            }
            return nums;
        }

        public static string Sum(List<List<int>> lists)
        {
            int len = lists.Last().Count;
            List<int> ans = new List<int>();

            int carry = 0;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum = carry;
                for (int j = 0; j < lists.Count; j++)
                {
                    if (i < lists[j].Count)
                        sum += lists[j][i];
                }
                carry = sum / 10;
                ans.Add(sum % 10);
            }
            if (carry != 0)
                ans.Add(carry);


            ans.Reverse();

            for (int i = 0; i < ans.Count; i++)
            {
                if (ans[i] == 0)
                {
                    ans.RemoveAt(i--);//because list will be rearranged
                }
                else
                {
                    break;
                }
            }
            if (ans.Count == 0)
                return "0";

            return ans.Select(x => x.ToString())
                        .Aggregate("", (acc, next) => acc + next);
        }
    }
}