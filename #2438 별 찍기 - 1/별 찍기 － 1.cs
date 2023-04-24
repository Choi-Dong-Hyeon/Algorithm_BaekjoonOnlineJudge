    internal class Program
    {
        static void Main(string[] args)
        {

            string star = "*";
            int count =Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<=count-1; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

        }

    }