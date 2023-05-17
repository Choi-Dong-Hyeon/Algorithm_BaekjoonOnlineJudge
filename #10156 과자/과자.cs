using System;
using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        string[] nums1 = Console.ReadLine().Split();

        int num1 = Convert.ToInt32(nums1[0]);
        int num2 = Convert.ToInt32(nums1[1]);
        BigInteger num3 = Convert.ToInt32(nums1[2]);
        if ((num1 * num2) < num3)
        {
            Console.WriteLine("0");
        }
        else
        {

        Console.WriteLine((num1*num2)-num3);
        }

    }
}