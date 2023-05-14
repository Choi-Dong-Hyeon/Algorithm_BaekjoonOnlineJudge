    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            BigInteger num1 = BigInteger.Parse(nums[0]);
            BigInteger num2= BigInteger.Parse(nums[1]);


            Show show = new Show(num1,num2);
        }
    }

    class Show
    {
        public Show(BigInteger a, BigInteger b)
        {
            Console.WriteLine(a + b);

        }
    }