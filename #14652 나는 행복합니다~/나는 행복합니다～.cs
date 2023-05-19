using System;


internal class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int n = Convert.ToInt32(nums[0]);
        int m = Convert.ToInt32(nums[1]);
        int x = Convert.ToInt32(nums[2]);

        Console.WriteLine($"{x/m} {x%m}");
    }

}