using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    public class ConsoleOutput
    {
        public static void OutputMatrixAndLetter(List<int> ar, char letter)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;

            int[,] work = new int[4, 4];
            int k = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    work[i, j] = ar[k++];
                }
            }
            k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    if (work[i, j].Equals(-1)) work[i, j] = 0;
                    Console.Write(work[i,j].ToString() + "\t");
                    
                }
                k++;
                if (k == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"<=>     ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{letter.ToString()}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static void Result(bool result)
        {
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("TRUE");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("FALSE");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
