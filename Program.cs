using System;

namespace apples_and_oranges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int applesThatFellOnHouse = 0;
            int orangesThatFellOnHouse = 0;

            for (var i = 0; i < m; i++)
            {
                if (a + apple[i] >= s && a + apple[i] <= t)
                    applesThatFellOnHouse++;
            }

            for (var j = 0; j < n; j++)
            {
                if (b + orange[j] >= s && b + orange[j] <= t)
                    orangesThatFellOnHouse++;
            }

            Console.WriteLine(applesThatFellOnHouse);
            Console.WriteLine(orangesThatFellOnHouse);
        }
    }
}
