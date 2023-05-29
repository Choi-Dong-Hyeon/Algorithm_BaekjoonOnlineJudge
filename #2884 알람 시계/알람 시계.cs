using System;


internal class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();

        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);

        int num3 = num2 - 45;

        if (num3 < 0) { num1 -= 1; num3 =(-num3 - 60)*-1; }
        if (num1 < 0) { num1 = 23; }
        if (num1 == 23 && num2 == 59) { num1 = 0; num2 = 0; }


        Console.WriteLine($"{num1} {num3}");

    }

}


