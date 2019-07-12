using System;

namespace BattleSimulator.Services
{
    public static class HelperService
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static int Randomize(int min, int max)
        {
            var random = new Random();

            return random.Next(min, max);
        }
    }
}
