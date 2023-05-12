    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fectoryal(n));


            int Fectoryal(int a)
            {
                if (a > 0)
                {
                    sum = sum + a;
                    Fectoryal(a - 1);
                }
                return sum;
            }


        }
    }