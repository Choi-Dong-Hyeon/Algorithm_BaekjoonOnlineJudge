using System;

internal class Program
{

    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split();
        Byte a = Convert.ToByte(nums[0]);
        Byte b = Convert.ToByte(nums[1]);

        if (a >= 12 && a <= 16 )
        {
            if (b == 0) Console.WriteLine("320");
            if (b == 1) Console.WriteLine("280");
        }
        else
        {
            Console.WriteLine("280");
        }

    }

}


