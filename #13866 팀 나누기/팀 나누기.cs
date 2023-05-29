using System;


internal class Program
{
    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split();
        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);
        int num3 = Convert.ToInt32(nums[2]);
        int num4 = Convert.ToInt32(nums[3]);


        Console.WriteLine(Math.Abs((num1 - num2) - (num3 - num4)));

    }




}
