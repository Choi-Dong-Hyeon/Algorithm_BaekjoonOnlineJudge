using System;
class Program
{
    static void Main(string[] args)
    {
        int target = Convert.ToInt32(Console.ReadLine());
        string[] nums = Console.ReadLine().Split();
        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);

     
 

        if (target < num1 / 2 + num2) Console.WriteLine(target);
        if (target >= num1 / 2 + num2) Console.WriteLine(num1 / 2 + num2);

    }

}
