    internal class Program
    {
        static void Main(string[] args)
        {

            string y = Console.ReadLine();
            int Y = Convert.ToInt32(y);
            if (Y % 4 == 0 && Y % 100 != 0 || Y % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }

    }