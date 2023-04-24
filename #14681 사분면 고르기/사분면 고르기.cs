    internal class Program
    {
        static void Main(string[] args)
        {

            string A = Console.ReadLine();
            string B = Console.ReadLine();

            int a = Convert.ToInt32(A);
            int b = Convert.ToInt32(B);

            if ((a * -1) < 0 && (b*-1)<0)
            {
                Console.WriteLine("1");
            }
            if ((a * -1) > 0 && (b * -1) < 0)
            {
                Console.WriteLine("2");
            }
            if ((a * -1) > 0 && (b * -1) > 0)
            {
                Console.WriteLine("3");
            }
            if ((a * -1) < 0 && (b * -1) > 0)
            {
                Console.WriteLine("4");
            }


        }

    }