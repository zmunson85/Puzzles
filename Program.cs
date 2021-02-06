using System;
using System.Collections.Generic;
namespace ConsoleApplication1

{
    public class Program
    {
        // Place 10 random integer values between 5-25 into the array
        //     public static int[] randomArr()
        // {
        //     int Min = 5;
        //     int Max = 25;
        //     int[] randArr = new int[10];
        //     Random randNum = new Random();
        //     for (int i = 0; i < randArr.Length; i++)
        //     {
        //         randArr[i] = randNum.Next(Min, Max);
        //         Console.WriteLine(randArr[i]);
        //     }
        //     return randArr;
        // }

        // Print the min and max values of the array
        // Return the sum of all the values
        // public static int[] randomArr()
        // {
        //     int Min = 5;
        //     int Max = 25;
        //     int Lil = 5;
        //     int Biggie = 0;
        //     int Sum = 0;
        //     int[] randArr = new int[10];
        //     Random randNum = new Random();
        //     for (int i = 0; i < randArr.Length; i++)
        //     {
        //         randArr[i] = randNum.Next(Min, Max);
        //         Console.WriteLine(randArr[i]);
        //         Sum += randArr[i];
        //         if (randArr[i] < Lil)
        //         {
        //             Lil = randArr[i];
        //         }
        //         if (randArr[i] > Biggie)
        //         {
        //             Biggie = randArr[i];
        //         }
        //     }
        //     Console.WriteLine("here is the min " + Lil);
        //     Console.WriteLine("here is the max " + Biggie);
        //     int Avg = Sum / randArr.Length;
        //     Console.WriteLine("here is the average " + Avg);
        //     return randArr;
        // }

        // Coin Toss
        // public static string coinToss(int num){
        //     int headToss = 0;
        //     int tailToss = 0;
        //     Random rand = new Random();
        //     for(int i = 1; i < num; i++) {
        //         int result = rand.Next(1,3);
        //         if(result == 1) {
        //             Console.WriteLine("Tossing A Coin...");
        //             tailToss += 1;
        //             Console.WriteLine("You Flipped Tails!" + " # of Tails: " + tailToss);
        //         }
        //         if(result == 2) {
        //             Console.WriteLine("Tossing A Coin...");
        //             headToss += 1;
        //             Console.WriteLine("You Flipped Heads!" + " # of Heads: " + headToss);
        //         }
        //     }
        //     Console.WriteLine("Total # of Tails = " + tailToss);
        //     Console.WriteLine("Total # of Heads = " + headToss);
        //     int totalCount = headToss + tailToss;
        //     double totalResult = ((double)totalCount/headToss);
        //     Console.WriteLine("ratio of heads " + totalResult);
        //     return("coin toss done");
        // }


        // Build a function Names that returns an array of strings
        // Create an array with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the array and print the values in the new order
        // Return an array that only includes names longer than 5 characters

        public static void Names()
        {
            string[] names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            string[] shuffled = new string[5];
            Random random = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                bool flag = true;
                while (flag)
                {
                    int idx = random.Next(0, 5);
                    if (shuffled[idx] == null)
                    {
                        shuffled[idx] = names[i];
                        flag = false;
                    }
                }
            }
            for (int k = 0; k < shuffled.Length; k++)
            {
                if (shuffled[k].Length < 5)
                {
                    shuffled[k] = null;
                }
                Console.WriteLine(shuffled[k]);
            }
        }


        public static void Main(string[] args)
        {
            // randomArr();
            // coinToss(20);
            Names();
        }
    }
}