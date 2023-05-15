    using System.IO;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            StringReader sr1 = new StringReader(nums[0]);
            int target = Convert.ToInt32(sr1.ReadLine());
  


            Console.WriteLine($"{target*0.78} {((target*0.80)*0.22) + target*0.78 }");


        }
    }