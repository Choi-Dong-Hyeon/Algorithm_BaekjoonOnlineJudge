    internal class Program
    {

        static void Main(string[] args)
        {

           string[] nums= Console.ReadLine().Split();

           double A= Convert.ToDouble(nums[0]);
            double B = Convert.ToDouble(nums[1]);



            Console.WriteLine(Sum(A, B));

            double Sum(double a, double b)
            {
                return a / b;
            }

        }

    }