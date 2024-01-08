using csharp_fundamentals_primitive_types.Main;
using NUnit.Framework;

namespace csharp_fundamentals_primitive_types.Test
{
    public class CoreTests
    {
        Core coreExercise = new Core();

        [Test]
        public void oneShouldBe24() {
            Assert.AreEqual(24, coreExercise.numOnePlusTwo);
        }

        [Test]
        public void twoShouldBe512() {
            Assert.AreEqual(512, this.coreExercise.numThreeTimesNumTwo);
        }

        [Test]
        public void threeShouldBe4() {
            Assert.AreEqual(4, this.coreExercise.numThreeDividedByNumOne);
        }

        [Test]
        public void fourShouldBe24() {
            Assert.AreEqual(24, this.coreExercise.numThreeMinusNumOne);
        }

        [Test]
        public void fiveShouldBe56() {
            Assert.AreEqual(56, this.coreExercise.sum);
        }

        [Test]
        public void sixShouldBe7() {
            Assert.AreEqual(7, this.coreExercise.numBytes);
        }

        [Test]
        public void sevenShouldBeZ() {
            Assert.AreEqual('Z', this.coreExercise.lastLetter);
        }

        [Test]
        public void eightShouldBe3p14() {
            Assert.AreEqual(3.14f, this.coreExercise.pi);
        }

        [Test]
        public void nineShouldBe3p14159() {
            Assert.AreEqual(3.14159d, this.coreExercise.piD);
        }

        [Test]
        public void tenShouldBeJaneSmith() {
            Assert.AreEqual("Jane Smith", this.coreExercise.fullName);
        }

        [Test]
        public void elevenShouldBeJ() {
            Assert.AreEqual('J', this.coreExercise.tenthLetter);
        }

        [Test]
        public void twelveShouldBeLowerAlphabet() {
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", this.coreExercise.lowerAlphabet);
        }

        [Test]
        public void thirteenShouldBe26() {
            Assert.AreEqual(26, this.coreExercise.alphabetLength);
        }

        [Test]
        public void fourteenShouldBe7() {
            Assert.AreEqual(7, this.coreExercise.remainder);
        }
    }
}