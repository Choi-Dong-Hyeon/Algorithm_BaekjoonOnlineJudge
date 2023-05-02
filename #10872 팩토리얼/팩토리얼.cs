   internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int num = Convert.ToInt32(nums[0]);

            int input = num;
            int[] array = new int[num];
            int output = 1;

            array = Enumerable.Repeat(1, array.Length).ToArray();

            for (int i = 0; i < num ; i++)
            {
                array[i] = input--;
            }

            for (int i = 0; i < num ; i++)
            {
                   output*=  array[i];
            }
                Console.WriteLine(output);
        }
    }