
using System;

internal class Program
{
    static void Main(string[] args)
    {
        float sum = 0;
      
        for (int i = 0; i < 4; i++)
        {
            sum += Convert.ToInt32(Console.ReadLine());
           
        }
        float bun =Convert.ToInt32(sum) / 60;
        float cho = sum / 60;
        Console.WriteLine(bun);
        Console.WriteLine(Convert.ToInt32((cho-Convert.ToInt32(bun))*60));

    }
}

