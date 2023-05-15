    internal class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;


            for (int i = num; i > 0; i--)
            {
                if (num % 4 == 0)
                {
                    count++;
                }
                num--;
            }

            for(int i=0; i<count; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");

        }

    }