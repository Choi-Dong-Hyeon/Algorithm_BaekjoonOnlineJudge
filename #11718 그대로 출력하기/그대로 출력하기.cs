    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                string go = Console.ReadLine();
                sb.Append(go);
                Console.WriteLine(sb);
                sb.Clear();
            }
        }
    }