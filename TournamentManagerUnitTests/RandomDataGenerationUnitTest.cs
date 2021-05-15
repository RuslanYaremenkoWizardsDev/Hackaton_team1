using NUnit.Framework;
using TournamentManager.Logic;

namespace TournamentManagerUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GenerateFullMaleNameTest()
        {
            string fullMaleName = RandomDataGeneration.GenerateFullMaleName();
            string[] fullMaleNameWords = fullMaleName.Split(' ');
            Assert.AreEqual(3, fullMaleNameWords.Length);
            Assert.AreNotEqual(' ', fullMaleNameWords[0]);
            Assert.AreNotEqual(' ', fullMaleNameWords[^1]);
        }

        [Test]
        public void GenerateFullFemaleNameTest()
        {
            string fullFemaleName = RandomDataGeneration.GenerateFullFemaleName();
            string[] fullFemaleNameWords = fullFemaleName.Split(' ');
            Assert.AreEqual(3, fullFemaleNameWords.Length);
            Assert.AreNotEqual(' ', fullFemaleNameWords[0]);
            Assert.AreNotEqual(' ', fullFemaleNameWords[^1]);
        }
    }
}