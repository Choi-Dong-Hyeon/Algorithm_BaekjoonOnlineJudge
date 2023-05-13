using System.Numerics;
internal class Program
    {
        static void Main(string[] args)
        {

            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);

            
            

            Show show = new Show(num1, num2);
        }
    }

    class Show
    {
        public Show(BigInteger a, BigInteger b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);

        }
    }