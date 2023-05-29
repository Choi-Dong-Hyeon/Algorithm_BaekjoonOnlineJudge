using System;


internal class Program
{
    static void Main(string[] args)
    {
        bool state = true;
        string num = null;
        
        while (state)
        {
            num = Console.ReadLine();
            if (num == "END")
            {
                state = false;
                return;
            }
        for (int i = num.Length; i > 0; i--)
        {
            Console.Write(num[i - 1]);
        }
        Console.WriteLine();

        }




    }




}
