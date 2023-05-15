    internal class Program
    {
        static void Main(string[] args)
        {
           string name= Console.ReadLine();
            Show show = new Show(name);
        }

    }

    class Show
    {
        public Show(string name)
        {
            Console.WriteLine(":fan::fan::fan:");
            Console.WriteLine($":fan::{name}::fan:");
            Console.WriteLine(":fan::fan::fan:");

        }
    }
    