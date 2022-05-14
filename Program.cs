using System;
using System.Linq;



namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeDepth(26));
            
        }
        public static int ComputeDepth(int n)
        {
            if (n == 1)
            {
                return 10;}
            int depth = 0;
            int counter = 0;
            string cisla = "0123456789";

            for (int i = 1; i < 100000; i++)
            {
                int number = i * n;
                string num = number.ToString();
                for (int j = 0; j < cisla.Length; j++)
                {
                    for (int k = 0; k < num.Length; k++)
                    {
                        if (cisla[j] == num[k])
                        {
                            cisla = cisla.Replace(cisla[j], '-');
                            counter++;
                        }
                    }
                }

                if (counter == 10)
                {
                    depth = i ;
                    break;
                }
            }

            return depth;
        }

    }
}