using System;

internal class Program
{
    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split();
        short num1 = Convert.ToInt16(nums[0]);
        short num2 = Convert.ToInt16(nums[1]);
        int num3 = num1 * num2;

        string[] target = Console.ReadLine().Split();
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            array[i]= Convert.ToInt32(target[i]) - num3;
        }
        Console.WriteLine($"{array[0]} {array[1]} {array[2]} {array[3]} {array[4]}");
    }
}

