    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            int num0 = Convert.ToInt32(nums[0]);
            int num1 = Convert.ToInt32(nums[1]);
            int num2 = Convert.ToInt32(nums[2]);
            int num3 = Convert.ToInt32(nums[3]);
            int num4 = Convert.ToInt32(nums[4]);
            int num5 = Convert.ToInt32(nums[5]);

            if (num0 > 1)
            {
                num0 = 1 - num0;
            }
            else if (num0 == 1)
            {
                num0 = 0;
            }
            else
            {
                num0 = 1 - num0;
            }



            if (num1 > 1)
            {
                num1 = 1-num1;
            }
            else if (num1 == 1)
            {
                num1 = 0;
            }
            else
            {
                num1 = 1 - num1;
            }



            if (num2 > 2)
            {
                num2 = 2-num2 ;
            }
            else if (num2 == 2)
            {
                num2 = 0;
            }
            else
            {
                num2 = 2 - num2;
            }


            if (num3 > 2)
            {
                num3 = 2-num3;
            }
            else if (num3 == 2)
            {
                num3 = 0;
            }
            else
            {
                num3 = 2 - num3;
            }


            if (num4 > 2)
            {
                num4 = 2-num4;
            }
            else if (num4 == 2)
            {
                num4 = 0;
            }
            else
            {
                num4 = 2 - num4;
            }

            if (num5 > 8)
            {
                num5 = 8-num5;
            }
            else if (num5 == 8)
            {
                num5 = 0;
            }
            else
            {
                num5 = 8 - num5;
            }



            Console.Write($"{num0} {num1} {num2} {num3} {num4} {num5}");

        }
    }