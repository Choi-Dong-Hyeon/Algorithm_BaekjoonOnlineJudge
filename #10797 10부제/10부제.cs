using System;


internal class Program
{
    static void Main(string[] args)
    {

        int targetnum = Convert.ToInt32(Console.ReadLine());
        string[] num = Console.ReadLine().Split();
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            if (targetnum == Convert.ToInt32(num[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);

    }
}

