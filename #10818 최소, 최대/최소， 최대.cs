using System;
using System.Numerics;

internal class Program
{

    static void Main(string[] args)
    {

        BigInteger num = BigInteger.Parse(Console.ReadLine());
    
       
        string[] nums = Console.ReadLine().Split();
        BigInteger min = -1000001;
        BigInteger max = 1000001;

        for (int i = 0; i < num; i++)
        {
            if (BigInteger.Parse(nums[i]) > min)
            {
                min = BigInteger.Parse(nums[i]);
            }

            if (BigInteger.Parse(nums[i]) < max)
            {
                max = BigInteger.Parse(nums[i]);
            }
        }

        Console.WriteLine($"{max} {min}");
    }

}