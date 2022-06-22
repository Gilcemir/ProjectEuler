namespace Project
{
    public class pe019
    {
        public static void Get()
        {

            DateTime date1 = new DateTime(1901, 1, 1);
            DateTime date2 = new DateTime(2000, 12, 31);
            int count = 0;
            while (date1 <= date2)
            {
                if (date1.DayOfWeek == DayOfWeek.Sunday && date1.Day == 1) count++;
                date1 = date1.AddDays(1);
            }
            Console.WriteLine(count);
        }

    }
}