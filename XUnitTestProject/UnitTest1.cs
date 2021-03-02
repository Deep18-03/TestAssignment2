using System;
using Xunit;
using TestingAssignment2;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test_convertString()
        {
            string Name = "dEEp";
            string result = Name.convertString();
        }

     
        [Fact]
        public void Test_AllCharlower()
        {
            string Name = "deep Shah";
            bool result = Name.AllCharlower();
        }
        [Fact]
        public void Test_Capitalized()
        {
            string Name = "manish SHah";
            string result = Name.Capitalized();
        }
        [Fact]
        public void Test_ConvertToCapitalCase()
        {
            string Name = "deep Shah";
            string result = Name.Capitalized();
        }

        [Fact]
        public void Test_AllCharUpper()
        {
            string Name = "deep Shah";
            bool result = Name.AllCharUpper();
        }

        [Fact]
        public void Test_IsValidNumeric()
        {
            string Name = "deep Shah";
            bool result = Name.IsValidNumeric();
        }

        [Fact]
        public void Test_RemoveLastChar()
        {
            string Name = "deep Shah";
            string result = Name.RemoveLastChar();
        }


        [Fact]
        public void Test_StrToINT()
        {
            string Name = "123";
            int result = Name.StrToINT();
        }
        [Fact]
        public void Test_WordCount()
        {
            string Name = "Hello How are you";
            int result = Name.WordCount();
        }

    }
}
