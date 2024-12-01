using Xunit;
using ExerciseFive;

namespace Act5._XUnit
{
    public class TestClassifyAge
    {
        [Fact]
        public void ClassifyAge0()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 0;
            //Act
            int result = personaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void ClassifyAge1()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 1;
            //Act
            int result = personaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void ClassifyAge18()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 18;
            //Act
            int result = personaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void ClassifyAge65()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 65;
            //Act
            int result = personaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void ClassifyAge66()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 66;
            //Act
            int result = personaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(2, result);
        }
    }
    public class IsEven()
    {
        [Fact]
        public void IsEven1()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 1;
            //Act
            bool result = personaHelper.IsEven(age);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsEven2()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            int age = 2;
            //Act
            bool result = personaHelper.IsEven(age);
            //Assert
            Assert.True(result);
        }
    }
    public class NameAnalyser()
    {
        [Fact]
        public void NameAnalyser1()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string name = "E";
            //Act
            var result = personaHelper.NameAnalyser(name);
            //Assert
            Assert.True(result.IsShort);
        }
        [Fact]
        public void NameAnalyser5()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string name = "Eudal";
            //Act
            var result = personaHelper.NameAnalyser(name);
            //Assert
            Assert.False(result.IsShort);
        }
        [Fact]
        public void NameAnalyser6()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string name = "Eudald";
            //Act
            var result = personaHelper.NameAnalyser(name);
            //Assert
            Assert.False(result.IsPalindrome);
        }
    }
    public class VerifyColor()
    {
        [Fact]
        public void VerifyColorNothing()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string colour = "";
            //Act
            int result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(result, -1);
        }
        [Fact]
        public void VerifyColorVerd()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string colour = "verd";
            //Act
            int result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(result, 0);
        }
        [Fact]
        public void VerifyColorVermell()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string colour = "vermell";
            //Act
            int result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(result, 1);
        }

    }
    public class PersonalityTest()
    {
        [Fact]
        public void PersonalityTestMati()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string preference = "matí";
            //Act
            int result = personaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(result, 0);
        }
        [Fact]
        public void PersonalityTestNit()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string preference = "nit";
            //Act
            int result = personaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(result, 1);
        }
        [Fact]
        public void PersonalityTestTarda()
        {
            //Arrange
            var personaHelper = new PersonaHelper();
            string preference = "tarda";
            //Act
            int result = personaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(result, 2);
        }
    }
}