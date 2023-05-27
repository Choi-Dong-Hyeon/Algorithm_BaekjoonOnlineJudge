using System;

namespace ConsoleApp11
{



    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            while (state)
            {
                string[] nams = Console.ReadLine().Split();

                int num2 = Convert.ToInt32(nams[1]);
                int num3 = Convert.ToInt32(nams[2]);

                if (nams[0] == "#" && num2 == 0 && num3 == 0)
                {
                    state = false;
                    return;
                }
                if (num2 > 17 || num3 >= 80)
                {
                    Console.WriteLine($"{nams[0]} Senior");
                
                }
                else
                {

                    Console.WriteLine($"{nams[0]} Junior");
                }
            }

        }
    }
}