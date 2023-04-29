    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            int min = Int32.MinValue;
            int counti = 0;
            int countj = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] nums = Console.ReadLine().Split();
              
                for (int j = 0; j < 9; j++)
                {
                    array[i, j] =Convert.ToInt32(nums[j]);

                    if (array[i, j] > min)
                    {
                        min = array[i, j];
                        counti = i + 1;
                        countj = j + 1;
                    }

                }
            }
            Console.WriteLine(min);
            Console.WriteLine("{0} {1}",counti,countj);
        }
    }