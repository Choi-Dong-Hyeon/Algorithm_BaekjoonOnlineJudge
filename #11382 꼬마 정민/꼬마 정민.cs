    public class Program
    {
       
        static void Main(string[] args)
        {
          string[] num  = Console.ReadLine().Split();
          long a1= Convert.ToInt64(num[0]);
          long a2= Convert.ToInt64(num[1]);
          long a3= Convert.ToInt64(num[2]);

            Console.WriteLine(a1 + a2 + a3);
        }
    }