    using System.IO;


    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            StringReader sr1 = new StringReader(nums[0]);
            StringReader sr2 = new StringReader(nums[1]);
        

            SumClass sum = new SumClass(Convert.ToInt32(sr1.ReadLine()), Convert.ToInt32(sr2.ReadLine()));


        }
    }

    class SumClass
    {
       public SumClass(int a, int b)
        {
          a=  a * 100;
            if (a >= b)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }