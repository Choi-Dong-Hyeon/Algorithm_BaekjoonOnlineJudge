using System.Numerics;
internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(nums[0]);
            BigInteger b = BigInteger.Parse(nums[1]);
            BigInteger c = BigInteger.Parse(nums[2]);

            BigInteger min = 0;
            
            for(int i=0; i<3; i++)
            {
                for(int j=i+1; j<3; j++)
                {
                    if (BigInteger.Parse(nums[i])> BigInteger.Parse(nums[j]))
                    {
                        BigInteger temp = BigInteger.Parse(nums[i]);
                        nums[i] = nums[j];
                        nums[j] = temp.ToString();

                    }
                }
            }


            Console.Write($"{BigInteger.Parse(nums[0])} {BigInteger.Parse(nums[1])} {BigInteger.Parse(nums[2])}");


        }

    }