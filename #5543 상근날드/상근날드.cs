using System;


internal class Program
{
    static void Main(string[] args)
    {

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int num4 = Convert.ToInt32(Console.ReadLine());
        int num5 = Convert.ToInt32(Console.ReadLine());

       int a= Math.Min(num4, num5);
       int b= Math.Min(Math.Min(num1,num2), Math.Min(num1,num3));

        int c=Math.Min(num2, num3);


        Console.WriteLine(Math.Min(c, b) + a -50);


    }
}
/*
100
100
150
50
100
 */
