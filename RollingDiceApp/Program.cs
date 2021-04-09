using System;

namespace RollingDiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            Console.WriteLine("Start");

            while (true)
            {
                calculator.RollResults = AbilityScoreCalculator.ReadInt(calculator.RollResults, "Starting 4d6 roll");
                calculator.DivideBy = AbilityScoreCalculator.ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = AbilityScoreCalculator.ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = AbilityScoreCalculator.ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continiue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;

            }
        }
    }
}
