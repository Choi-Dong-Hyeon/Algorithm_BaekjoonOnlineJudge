    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            string[] nums = Console.ReadLine().Split();
            long A = Convert.ToInt32(nums[0]);
            long B = Convert.ToInt32(nums[1]);
            long C = Convert.ToInt32(nums[2]);
            long D = Convert.ToInt32(nums[3]);
            long E = Convert.ToInt32(nums[4]);

            sb.Append(sum(A, B, C, D, E));
            Console.Write(sb);

            long sum(long a, long b, long c, long d, long e)
            {
                long go = (a * a + b * b + c * c + d * d + e * e)%10;

                return go;
            }
        }
    }