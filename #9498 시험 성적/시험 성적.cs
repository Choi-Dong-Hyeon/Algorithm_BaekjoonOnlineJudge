    public class Program
    {

        static void Main(string[] args)
        {

            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);

            if (num >= 90 && num<=100)
            {
                Console.WriteLine("A");
            }
           else if (num >= 80 && num<=89)
            {
                Console.WriteLine("B");
            }
           else if (num >= 70 && num<=79)
            {
                Console.WriteLine("C");
            }
            else if (num >= 60 && num <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }