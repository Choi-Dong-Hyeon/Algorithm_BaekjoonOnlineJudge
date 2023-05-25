using System;


internal class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 1;
      


        for (int i = 0; i < num; i++)
        {
            string test = Console.ReadLine();
             Console.WriteLine($"{count++}. {test}");
        }

    }
}

