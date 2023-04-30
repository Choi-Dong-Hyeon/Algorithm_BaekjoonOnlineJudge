    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //int[] scores = new int[] { 90, 87, 100, 95, 80 };
                //int[] rank = Enumerable.Repeat(1, scores.Length).ToArray();


                //for (int i = 0; i < scores.Length; i++)
                //{
                //    for (int j = 0; j < scores.Length; j++)
                //    {
                //        if (scores[i] < scores[j])
                //        {
                //            rank[i] += 1;
                //        }
                //    }
                //}

                //for(int k=0; k<scores.Length; k++)
                //{
                //    Console.WriteLine($"Scores : {scores[k],6}  Ranking :{rank[k],2}");
                //}
            }

            string num = Console.ReadLine();

            int[] array = new int[Convert.ToInt32(num)];
            for(int i=0; i<array.Length; i++)
            {
            array[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<array.Length-1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            for(int k=0; k<array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }

        }
    }