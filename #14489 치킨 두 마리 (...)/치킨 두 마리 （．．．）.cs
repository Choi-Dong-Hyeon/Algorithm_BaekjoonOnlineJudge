using System;


internal class Program
{
    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split();
        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);

        int target = Convert.ToInt32(Console.ReadLine());

        int num3 = num1 + num2;

        if (num3 >= target * 2) Console.WriteLine(num3-target*2);

        if (num3 <target*2) Console.WriteLine(num3);

        
    }




}
