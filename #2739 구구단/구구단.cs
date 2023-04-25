    internal class Program
    {
        static void Main(string[] args)
        {
           string num= Console.ReadLine();
           int numa= Convert.ToInt32(num);

            for (int i = numa; i <= numa; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");

                }
              
                
            }

        }
    }