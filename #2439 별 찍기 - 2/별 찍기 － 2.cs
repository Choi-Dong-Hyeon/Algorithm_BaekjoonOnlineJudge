   internal class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {

                    Console.Write($"*");
                }
                Console.WriteLine();

            }

        }
    }