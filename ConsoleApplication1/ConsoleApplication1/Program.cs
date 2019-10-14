using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] game = new int[] { 0, 3, 4, 6 };
            PrintGame(game);
        }

        public static void PrintGame(int[] game)
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < game[1]; i++)
            { 
                Console.Write("0 " );
            }
            Console.WriteLine();

            Console.Write("Group 2: ");
            for (int i = 0; i < game[2]; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();

            Console.Write("Group 3: ");
            for (int i = 0; i < game[3]; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
        }
        public static void PickBall(int[] game, int group, int balls)
        {
            game[group] -= balls;
        }
        public static bool has0ball(int[] game)
        {
            return game[1] == 0& 
        }
    }
}
