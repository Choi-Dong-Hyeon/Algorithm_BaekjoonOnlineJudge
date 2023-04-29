    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                string num = Console.ReadLine();
                int[] array = new int[5];
                array[i] = Convert.ToInt32(num);

                if (array[i] < 40)
                {
                    array[i] = 40;
                }
                sum += Convert.ToInt32(array[i]);
            }
            Console.WriteLine(sum/5);
        }
    }