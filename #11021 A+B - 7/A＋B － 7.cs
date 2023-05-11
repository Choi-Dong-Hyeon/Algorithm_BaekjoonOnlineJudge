  internal class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int num = Convert.ToInt32(nums);
            int count = 1;
            for (int i = 0; i < num; i++)
            {
                string[] A = Console.ReadLine().Split();
                int a1 =Convert.ToInt32(A[0]);
                int a2 =Convert.ToInt32(A[1]);
                Console.WriteLine($"Case #{count++}: {Add(a1,a2)}");
            }

            int Add(int a, int b)
            {
                return a + b;
            }


        }
    }