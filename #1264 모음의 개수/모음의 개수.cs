using System;

class Program
{

    static void Main(string[] args)
    {
        BackJon g = new BackJon();

        g.go();
    }
}


class BackJon
{
    public void go()
    {
        int num = 0;
        bool start = true;
        string S = null; ;
        while (start)
        {
            S = Console.ReadLine();

            if (S[0] == '#') { start = false; return; }

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'a' || S[i] == 'A')
                {
                    num++;
                }
                if (S[i] == 'e' || S[i] == 'E')
                {
                    num++;
                }
                if (S[i] == 'i' || S[i] == 'I')
                {
                    num++;
                }
                if (S[i] == 'o' || S[i] == 'O')
                {
                    num++;
                }
                if (S[i] == 'u' || S[i] == 'U')
                {
                    num++;
                }
            }
            Console.WriteLine(num);
            num = 0;
        }

    }
}