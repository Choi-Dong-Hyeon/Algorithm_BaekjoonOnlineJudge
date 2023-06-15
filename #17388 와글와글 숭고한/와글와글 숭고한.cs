using System;


internal class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();

        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);
        int num3 = Convert.ToInt32(nums[2]);



        int sum = (num1 + num2 + num3);
        if (sum >= 100) Console.WriteLine("OK");

        if (sum < 100)
        {
            int a = Math.Min(Math.Min(num1, num2), Math.Min(num2, num3));
           
              if(Convert.ToInt32(nums[0]) == a) Console.WriteLine("Soongsil");
            if (Convert.ToInt32(nums[1]) == a) Console.WriteLine("Korea");
            if (Convert.ToInt32(nums[2]) == a) Console.WriteLine("Hanyang");
        }
    }
}

