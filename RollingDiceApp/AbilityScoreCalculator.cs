using System;
using System.Collections.Generic;
using System.Text;

namespace RollingDiceApp
{
    class AbilityScoreCalculator
    {
        public int RollResults = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score = 0;

        public void CalculateAbilityScore()
        {
            int addAmount = AddAmount;
            double divided = (double)RollResults / DivideBy;
            int added = addAmount += (int)divided;

            if (added < Minimum)
            {
                Score = Minimum;
            } else
            {
                Score = added;
            }


        }


        // <summay>
        // Writes a promt and reads an int value from console
        // </summary>
        // <param name="lastUsedValue"> The default value.</param>
        // <param name = "prompt" > Promt to print to the console</param>
        // <retusrn>The int value read, or default valueifunable to parse</returns> 

        public static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.WriteLine(prompt + "["+ lastUsedValue+"]: ");
            string line = Console.ReadLine();

            if ( !int.TryParse(line, out int value))
            {
                Console.WriteLine("Unable to Parse using default value instead:" + lastUsedValue);
                return lastUsedValue;
            }
            else
            {
                Console.WriteLine("Using Value:" + value);
                return value;
            }
           


        }

         public static double ReadDouble(double lastUsedValue, string prompt) 
        {
            Console.WriteLine(prompt + "[" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (!double.TryParse(line, out double value))
            {
                Console.WriteLine("Unable to Parse using default value instead:" + lastUsedValue);
                return lastUsedValue;
            }
            else
            {
                Console.WriteLine("Using Value:" + value);
                return value;
            }

        }

    }
}
