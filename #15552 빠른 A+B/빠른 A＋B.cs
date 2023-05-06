using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arrayNum = Console.ReadLine().Split();
            int arrayLength = Convert.ToInt32(arrayNum[0]);

            int[] array = new int[arrayLength];

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = Convert.ToInt32(nums[0]);
                int b = Convert.ToInt32(nums[1]);
                
                sb.AppendLine($"{a+b}");
            }
                Console.WriteLine(sb);
        }
    }