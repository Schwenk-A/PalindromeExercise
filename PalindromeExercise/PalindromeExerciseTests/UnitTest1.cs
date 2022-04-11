using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("anna", true)]  
        [InlineData("civic", true)]  
        [InlineData("level", true)]  
        [InlineData("madam", true)]  
        [InlineData("mark", false)]  
        [InlineData("mistletoe", false)]  
          
        public void PalindromeTester(string word, bool result)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(result, actual);
        }
        
    }
}
