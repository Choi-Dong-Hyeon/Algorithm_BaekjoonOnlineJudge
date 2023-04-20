    public class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            int en = 10000;
            string[] nums = Console.ReadLine().Split();

            A = Convert.ToInt32(nums[0]);
            B = Convert.ToInt32(nums[1]);
            C = Convert.ToInt32(nums[2]);


            Console.WriteLine(resert1(A,B,C));
            Console.WriteLine(resert2(A,B,C));
            Console.WriteLine(resert3(A,B,C));
            Console.WriteLine(resert4(A,B,C));


            int resert1(int a, int b, int c)
            {
                if (2 <= A && 2 <= B && 2 <= C && A <= en && B <= en && C <= en)
                {
                    return (a + b) % c;
                }
                return 0;
            }
            int resert2(int a, int b, int c)
            {
                if (2 <= A && 2 <= B && 2 <= C && A <= en && B <= en && C <= en)
                {
                    return ((a % c) + (b % c)) % c;
                }
                return 0;
            }
            int resert3(int a, int b, int c)
            {
                if (2 <= A && 2 <= B && 2 <= C && A <= en && B <= en && C <= en)
                {
                    return (a * b) % c;
                }
                return 0;
            }
            int resert4(int a, int b, int c)
            {
                if (2 <= A && 2 <= B && 2 <= C && A <= en && B <= en && C <= en)
                {
                    return ((a % c) * (b % c)) % c;
                }
                return 0;
            }

        }
    }