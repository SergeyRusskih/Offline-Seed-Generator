using System;
using System.Text;

namespace SeedGenerator
{
    public class RandomSeedGenerator
    {
        private const int SeedLength = 81;

        public string CreateNewSeed()
        {
            var seed = new StringBuilder();
            var random = new Random();

            for (var i = 0; i < SeedLength; i++)
            {
                var randomChar = Symbols[random.Next(Symbols.Length)];
                seed.Append(randomChar);
            }

            return seed.ToString();
        }

        private static readonly char[] Symbols =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '9'
        };
    }
}