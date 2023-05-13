    internal class Program
    {
        static void Main(string[] args)
        {

            Show show = new Show(Convert.ToInt32(Console.ReadLine()));
        }
    }

    class Show
    {
        public Show(int a)
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine("YONSEI");
                    break;
                case 1:
                    Console.WriteLine("Leading the Way to the Future");
                    break;
            }

        }
    }