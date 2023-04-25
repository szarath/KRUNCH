using Microsoft.VisualStudio.TestPlatform.TestHost;
using Krunch;
namespace Krunch.Test
{

    [TestFixture]
    public class KrunchTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string input = "NOW IS THE TIME FOR ALL GOOD MEN TO COME TO THE AID OF THEIR COUNTRY.";
            string expected = "NW S TH M FR L GD C Y.";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            string input = "MISSISSIPPI";
            string expected = "MSP";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            string input = "RAILROAD CROSSING";
            string expected = "RLD CSNG";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            string input = "MADAM I SAY I AM ADAM";
            string expected = "MD SY";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test5()
        {
            string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";
            string expected = "TH QCK BRWN FX JMPS V LZY DG.";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test6()
        {
            string input = "ABCD";
            string expected = "BCD";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test7()
        {
            string input = "RAILROAD CROSSING";
            string expected = "RLD CSNG";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test8()
        {
            string input = "MADAM_I_SAY_I_AM_ADAM__";
            string expected = "MD_SY";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test9()
        {
            string input = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string expected = "B C D F G H J K L M N P Q R S T V W X Y Z";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test10()
        {
            string input = "AAABBBCCCDDDEEEFFF";
            string expected = "BCDF";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test11()
        {
            string input = "HELLO, WORLD!";
            string expected = "HL WRD!";
            string actual = Program.Krunch(input);
            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}