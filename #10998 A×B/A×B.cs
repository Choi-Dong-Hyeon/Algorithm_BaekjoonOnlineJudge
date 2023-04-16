    internal class Program
    {

        static void Main(string[] args)
        {

           string[] nums= Console.ReadLine().Split();

           int A= int.Parse(nums[0]);
           int B= int.Parse(nums[1]);



            Console.WriteLine(Sum(A, B));

            int Sum(int a, int b)
            {
                return a * b;
            }

        }

    }