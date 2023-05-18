internal class Program
{
    static void Main(string[] args)
    {
        string[] nums1 = Console.ReadLine().Split();

        int num1 = Convert.ToInt32(nums1[0]);
        int rank = Convert.ToInt32(nums1[1]);

        int[] array = new int[num1];
      
        string[] target = Console.ReadLine().Split();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(target[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {

                if (array[i] < array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.WriteLine(array[rank-1]);

    }
}