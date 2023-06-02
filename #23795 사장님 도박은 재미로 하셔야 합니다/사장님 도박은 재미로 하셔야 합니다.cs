using System;


internal class Program
{
    static void Main(string[] args)
    {
        bool state = true;
        long sum = default;
        long num = default;
        while (state)
        {
            num = Convert.ToInt64(Console.ReadLine());
            sum += num;
            if (num == -1) state = false;


        }
        Console.WriteLine(sum+1);


    }
}

