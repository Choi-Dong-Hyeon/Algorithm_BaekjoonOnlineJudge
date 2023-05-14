    using System.IO;
    using System.Numerics;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            StringReader sr = new StringReader(Console.ReadLine());
            
            BigInteger num = BigInteger.Parse(sr.ReadLine());
            sb.Append(num % 20000303);
            Console.WriteLine(sb);
        }
    }