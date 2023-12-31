using System;

internal class Program
{
    static void Main(string[] args)
    {

        string[] nums;
        int sum;

        nums = Console.ReadLine().Split();
        int input1 = Convert.ToInt32(nums[0]);
        int input2 = Convert.ToInt32(nums[1]);
        sum=input1+ input2;

        Console.WriteLine(sum);
    }
}

