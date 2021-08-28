using System;
using System.Runtime.InteropServices;

namespace PlayerGuideChallenges
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] field = new int[6, 6];

//int target1 = Convert.ToInt32(Console.ReadLine());
//int target2 = Convert.ToInt32(Console.ReadLine());

            int[,] targetField = new int[,] { { 1, 1}, {1,2}, {1,3}, {2,1}, {2,2}, {2,3}, {3,1}, {3,2}, {3,3}};

            for (int i = 0; i < targetField.GetLength(0); i++)
            {
                for (int j = 0; j < targetField.GetLength(1); j++)
                {
                    Console.Write(targetField[i,j] + " ");
                }

                Console.WriteLine();
            }

            int t1 = Convert.ToInt32(Console.ReadLine());
            int t2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < targetField.GetLength(0); i++)
            {
                if ((int) targetField.GetValue(i,0) == t1)
                {
                    Console.WriteLine(targetField.GetValue(t1,0)); 
		
                    for (int j = 0; j < targetField.GetLength(1); j++)
                    {
                        if (targetField[0, j] == t2)
                        {
			
                        }
                    }
                    break;
                }


            }
            //TheDominionOfKings();
        }

        private static void TheDominionOfKings()
        {
            int estate = 1, duchy = 3, province = 6, total = 0;

            void writeLine(string text)
            {
                Console.WriteLine(text);
            }

            writeLine("How many estates owned?");
            total += Convert.ToInt32(Console.ReadLine());
            writeLine("How many duchies owned?");
            total += duchy * Convert.ToInt32(Console.ReadLine());
            writeLine("How many provinces owned?");
            total += province * Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total points: " + total);
        }
    }
}