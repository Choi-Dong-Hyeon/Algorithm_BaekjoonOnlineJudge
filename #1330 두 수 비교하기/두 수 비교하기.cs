    internal class Program
    {
        static void Main(string[] args)
        {

          string[] nums= Console.ReadLine().Split();

            ac(int.Parse(nums[0]), int.Parse(nums[1]));

            void ac(int num1, int num2)
            {
                if(num1>num2)
                    Console.WriteLine(">");
                if(num1<num2)
                    Console.WriteLine("<");
                if(num1==num2)
                    Console.WriteLine("==");
                
            }

        }

    }