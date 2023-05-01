    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int arrayNum = Convert.ToInt32(nums[0]);

            string[] e = new string[arrayNum];

            int[] array = new int[arrayNum];

            e = Console.ReadLine().Split();



            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(e[i]);
            }

            string[] findNum = Console.ReadLine().Split();

            int find = Convert.ToInt32(findNum[0]);
            
            int count = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == find)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }