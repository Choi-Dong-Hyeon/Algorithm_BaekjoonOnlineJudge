using System.Text;  
internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb.ToString());
        }
    }