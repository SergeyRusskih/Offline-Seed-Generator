using System.Text.RegularExpressions;
using SeedGenerator.UI.Models;
using Xunit;

namespace SeedGenerator.UI.Tests
{
    public class RandomSeedGeneratorTests
    {
        [Fact]
        public void Should_Generate_Seed_With_Length_Equals_81()
        {
            // Arrange
            var generator = new RandomSeedGenerator();

            // Act
            var seed = generator.CreateNewSeed();

            // Verify
            Assert.Equal(81, seed.Length);
        }

        [Fact]
        public void Should_Return_UpperCase_English_Letters_And_9()
        {
            // Arrange
            var generator = new RandomSeedGenerator();
            var regex = new Regex("[A-Z9]");

            // Act
            var seed = generator.CreateNewSeed();

            // Verify
            Assert.Matches(regex, seed);
        }
    }
}
