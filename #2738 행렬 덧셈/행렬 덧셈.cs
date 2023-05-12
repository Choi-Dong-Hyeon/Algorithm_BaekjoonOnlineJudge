    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int num1 = Convert.ToInt32(nums[0]);
            int num2 = Convert.ToInt32(nums[1]);


            int[,] array1 = new int[num1, num2];
            int[,] array2 = new int[num1, num2];
            int[,] array3 = new int[num1, num2];



            for (int i = 0; i < array1.GetLength(0); i++)
            {
                string[] n = Console.ReadLine().Split();
                for (int j = 0; j < array1.GetLength(1); j++)
                {

                    int a = Convert.ToInt32(n[j]);
                    array1[i, j] = a;

                }
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                string[] n = Console.ReadLine().Split();
                for (int j = 0; j < array2.GetLength(1); j++)
                {

                    int a = Convert.ToInt32(n[j]);
                    array2[i, j] = a;

                }
            }




            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    array3[i, j] = array1[i, j] + array2[i, j];

                    Console.Write($"{array3[i, j]} ");
                }
                Console.WriteLine();
            }


        }
    }