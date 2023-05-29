using System;


internal class Program
{
    static void Main(string[] args)
    {

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == 60 && num2 == 60 & num3 == 60) Console.WriteLine("Equilateral");

        if ((num1 + num2 + num3) == 180 && num1 != 60 && num2 != 60 & num3 != 60)
        {
            if (num1 == num2 || num1 == num3 || num2 == num3)
            Console.WriteLine("Isosceles");
        }

        if ((num1 + num2 + num3) == 180 && num1 != num2 && num1 != num3 && num2 != num3) Console.WriteLine("Scalene");

        if ((num1 + num2 + num3) != 180) Console.WriteLine("Error");


    }




}
