    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNums = Console.ReadLine().Split();
            int num = Convert.ToInt32(arrayNums[0]);
            int serchNum = Convert.ToInt32(arrayNums[1]);
            int[] array = new int[num];

            string[] serch = Console.ReadLine().Split();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(serch[i]);
                if (serchNum > array[i])
                {
                    Console.Write($"{array[i]} ");
                }
            }

        }
    }