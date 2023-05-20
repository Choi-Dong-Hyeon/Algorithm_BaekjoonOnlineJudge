using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int n = Convert.ToInt32(nums[0]);

        
        for(int i=0; i<n; i++)
        {
            string num = Console.ReadLine();
            if(num.Length>=6 && num.Length <= 9)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }

}