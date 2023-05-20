using System;

internal class Program
{

    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split();
        int a = Convert.ToInt32(nums[0]);
        float b = Convert.ToSingle(nums[1]);


        if ((a - (a * (b * 0.01f))) >= 100)
        {
            Console.WriteLine("0");
        }
        else Console.WriteLine("1");

    }

}


