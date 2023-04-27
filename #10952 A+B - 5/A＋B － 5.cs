using System.Collections;
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            for (int i = 0; ; i++)
            {
                string[] nums = Console.ReadLine().Split();
                array.Add(Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]));
              
                if (Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]) == 0)
                {
                    array.Remove(0);
                    foreach(int a in array)
                    {
                        Console.WriteLine(a);

                    }
                    return;
                }

            }

        }
    }