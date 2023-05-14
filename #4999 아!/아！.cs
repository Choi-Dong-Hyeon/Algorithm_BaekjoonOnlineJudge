using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringReader sr1 = new StringReader(Console.ReadLine());
            StringReader sr2 = new StringReader(Console.ReadLine());

            if (sr1.ReadLine().Length <sr2.ReadLine().Length)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }
        }
    }