   internal class Program
    {
        static void Main(string[] args)
        {
            int target = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            Show show = new Show();
            int s = 0;
            for (int i = 0; i < num; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = Convert.ToInt32(nums[0]);
                int b = Convert.ToInt32(nums[1]);
                s += show.Sum(a, b);
            }
            if (target == s)
            {
                Console.WriteLine("Yes");
            }
            if (target != s)
            {
                Console.WriteLine("No");
            }
        }

    }


    class Show
    {
        public int Sum(int a, int b)
        {
            return a * b;

        }
    }