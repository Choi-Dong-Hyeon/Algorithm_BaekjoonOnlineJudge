    internal class Program
    {
        static void Main(string[] args)
        {
            long num = Convert.ToInt64(Console.ReadLine());
            Show show = new Show();
            show.Fectoryel(num);
        }
    }

    class Show
    {
        long sum = 1;
        public void Fectoryel(long a)
        {
            if (a == 0)
            {
                a = 1;
            }

            if (a > 1)
            {
             sum *= a;
            Fectoryel(a - 1);
            }
            if (a == 1)
            {
                Console.WriteLine(sum);
            }


        }
    }