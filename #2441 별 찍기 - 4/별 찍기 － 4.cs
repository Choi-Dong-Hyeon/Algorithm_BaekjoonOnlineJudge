    internal class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<num; i++)
            {
                for(int k=0; k<i; k++)
                {
                Console.Write(" ");
                }

                for(int j=num; j>i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }