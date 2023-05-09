    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string[] nums = Console.ReadLine().Split();
                long num1 = Convert.ToInt32(nums[0]);
                long num2 = Convert.ToInt32(nums[1]);

                if (num1 > num2)
                {
                    Console.WriteLine("Yes");
                }
                else if(num1<=num2)
                {
                if (num2 == 0 && num1 == 0) return;
                    Console.WriteLine("No");
                }

            }

        }
    }