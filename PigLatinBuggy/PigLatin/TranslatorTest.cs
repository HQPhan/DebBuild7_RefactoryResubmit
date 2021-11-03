using Xunit;

namespace PigLatin
{
    public class TranslatorTest
    {
        //[Theory]
        //[InlineData('e')]
        //[InlineData('m')]
        //[InlineData('a')]
        //[InlineData('t')]
        //[InlineData('i')]
        //[InlineData('o')]
        //[InlineData('u')]
        //public void IsCharAVowel(char letter)
        //{
        //    //Arrange
        //    Translator t = new Translator();
        //    bool expected = true;
        //    //Act
        //    bool actual = t.IsVowel(letter);
        //    //Assert
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        //[InlineData("apple","appleway")]
        //[InlineData("heck", "eckhay")]
        //[InlineData("strong", "ongstray")]
        //[InlineData("tommy@email.com", "tommy@email.com")]
        //[InlineData("aardvark", "aardvarkway")]
        //[InlineData("Tommy", "ommytay")]
        //[InlineData("gym", "gym")]
        [InlineData("apple joy gym tommyemail.com strong", "appleway oyjay gym tommy@email.com, ongstray")]

        public void TestToPigLatin(string input, string expected)
        {
            //Arrange
            Translator t = new Translator();
            //Act
            string actual = t.ToPigLatin(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apple joy gym tommyemail.com strong", "appleway oyjay gym tommy@email.com, ongstray")]
        public void TestUserInputMethod(string input, string expected)
        {
            //Arrange
            Translator t = new Translator();

            //Act
            string actual = t.UserInput(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
