   internal class Program
    {
        static void Main(string[] args)
        {

            string A = Console.ReadLine();
            string B = Console.ReadLine();

            int a = Convert.ToInt32(A);
            int b = Convert.ToInt32(B);
           
            Console.WriteLine(Convert.ToInt32(B.Substring(2,1)) * a);
            Console.WriteLine(Convert.ToInt32(B.Substring(1,1)) * a);
            Console.WriteLine(Convert.ToInt32(B.Substring(0,1)) * a);
            Console.WriteLine(Convert.ToInt32(a * b));

        }

    }