using System;


internal class Program
{
    static void Main(string[] args)
    {

        int[] array = new int[6];
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            array[i] = num;
        }

        if (array[4] >= array[5])
        {
            temp += array[4];
        }
        else
        {
            temp += array[5];
        }

        for (int i = 0; i < 3; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temps = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temps;
            }
        }

        Console.WriteLine(temp + array[0] + array[1] + array[2]) ;


    }




}
