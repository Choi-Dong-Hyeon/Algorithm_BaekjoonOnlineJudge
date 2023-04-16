    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nums = Console.ReadLine().Split();
            int num1 = int.Parse(nums[0]);
            int num2 = int.Parse(nums[1]);



            Console.WriteLine(ex1(num1, num2));
            Console.WriteLine(ex2(num1, num2));
            Console.WriteLine(ex3(num1, num2));
            Console.WriteLine(ex4(num1, num2));
            Console.Write(ex5(num1, num2));

            int ex1(int a, int b)
            {
                int num3 = num1 + num2;
                return num3;
            }
            int ex2(int a, int b)
            {
                int num3 = num1 - num2;
                return num3;
            }
            int ex3(int a, int b)
            {
                int num3 = num1 * num2;
                return num3;
            }
            int ex4(int a, int b)
            {
                int num3 = num1 / num2;
                return num3;
            }
            int ex5(int a, int b)
            {
                int num3 = num1 % num2;
                return num3;
            }
        }
    }