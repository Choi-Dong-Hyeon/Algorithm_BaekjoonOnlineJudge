using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {  

            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            
            

            Show show = new Show(num1, num2);
        }
    }

    class Show
    {
        public Show(BigInteger a, BigInteger b)
        {
            Console.WriteLine(a + b);
        }
    }