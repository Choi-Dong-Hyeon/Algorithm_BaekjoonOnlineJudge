using System.Collections;    
internal class Program
    {
        static void Main(string[] args)
        {
            string testCase = Console.ReadLine();
            int test = Convert.ToInt32(testCase);

            ArrayList list = new ArrayList();

            for (int i = 1; i <= test; i++)
            {
                string[] nums = Console.ReadLine().Split();
                list.Add(Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]));

                if (i == test)
                {
                    for (int j = 0; j < test; j++)
                    {

                        Console.WriteLine(list[j]);
                    }
                }
            }
        }
    }