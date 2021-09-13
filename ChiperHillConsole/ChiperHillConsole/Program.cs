using System;

namespace ChiperHillConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // https://www.c-sharpcorner.com/article/hill-cipher-in-c-sharp/
            int i, j, sum = 0, end = 0;
            int[,] mtrx = new int[25, 25];
            int[,] ans = new int[25, 1];
            string text = "";

            Console.WriteLine("Enter your Plaintext");
            Console.Write("\n");
            text = Console.ReadLine();
            Console.Write("\n");
            char[] txt = text.ToCharArray();
            end = txt.Length;


            for (i = 0; i < end; i++)
            {
                txt[i] = Convert.ToChar(txt[i] - 'a');
            }

            Random rnd = new Random();
            for (i = 0; i < end; i++)
            {
                for (j = 0; j < end; j++)
                {

                    mtrx[i, j] = rnd.Next();
                }

            }

            for (i = 0; i < end; i++)
            {

                sum = 0;
                for (j = 0; j < end; j++)
                {
                    sum += mtrx[i, j] * (int)txt[j];
                }
                ans[i, 0] = sum;
            }

            Console.Write("Your CipherText is:");
            for (i = 0; i < end; i++)
            {
                char cipher = (char)(((ans[i, 0]) % 26) + 97);
                Console.Write("\t" + cipher);

            }

            Console.ReadKey();
        }
    }
}
