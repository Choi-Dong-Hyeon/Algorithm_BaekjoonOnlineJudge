    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            long num = Convert.ToInt64(names[0]) -Convert.ToInt64(names[1]);
            Console.WriteLine(Math.Abs(num));
        }
    }