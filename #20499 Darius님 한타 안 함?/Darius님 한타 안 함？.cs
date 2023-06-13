using System;


internal class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split('/');
        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);
        int num3 = Convert.ToInt32(nums[2]);


        if (num1 + num3 < num2 || num2 == 0)
        {
            Console.WriteLine("hasu");
        }
        else Console.WriteLine("gosu");
    }
}

