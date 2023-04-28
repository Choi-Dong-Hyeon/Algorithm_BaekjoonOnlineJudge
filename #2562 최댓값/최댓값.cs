using System.Collections;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.MinValue;
            int count = 1;
            
            ArrayList array = new ArrayList();

            for (int i = 1; i < 10; i++)
            {
                string num = Console.ReadLine();
                array.Add(Convert.ToInt32(num));

                if (Convert.ToInt32(array[i-1]) > input)
                {
                    input = Convert.ToInt32(array[i-1]);
                    count = i;
                }
            }
            Console.WriteLine(input);
            Console.WriteLine(count);
        }
    }