internal class Program
{
    static void Main(string[] args)
    {
        string[] nums1 = Console.ReadLine().Split();
        string[] nums2 = Console.ReadLine().Split();

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            sum1 += Convert.ToInt32(nums1[i]);
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            sum2 += Convert.ToInt32(nums2[i]);
        }

        if (sum1 > sum2) Console.WriteLine(sum1);
        if (sum1 < sum2) Console.WriteLine(sum2);
        if (sum1 == sum2) Console.WriteLine(sum1);

    }
}