using System;


internal class Program
{
    static void Main(string[] args)
    {

        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for(int j=0; j<a; j++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }


    }
}

