    internal class Program
    {
        static void Main(string[] args)
        {

            string nums = Console.ReadLine();




            string[] output = new string[nums.Length];

            for (int k = 0; k < nums.Length; k++)
            {
                char a = nums[k];
                string b =Convert.ToString(a);
                
                if (b.ToUpper() == b)
                {

                    output[k] = b.ToLower();

                }

                if (b.ToLower() == b)
                {
                    output[k] = b.ToUpper();
                }

            }


            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(output[i]);
            }

        }
    }