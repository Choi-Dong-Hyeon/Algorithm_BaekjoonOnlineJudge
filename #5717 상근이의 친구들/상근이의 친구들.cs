using System;


internal class Program
{
    static void Main(string[] args)
    {
        bool state = true;
        while (state)
        {
            string[] nums = Console.ReadLine().Split();
            int num1 = Convert.ToInt32(nums[0]);
            int num2 = Convert.ToInt32(nums[1]);
            if (num1 == 0 && num2 == 0)
            {
                return;
            }
            Console.WriteLine(num1 + num2);
        }
    }

}


