using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestingAssignment2
{
    public static class UtilityHelper
    {
        //Converted to uppercase to lovercase and viseversa
        public static string convertString(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    charArray[i] = char.IsUpper(charArray[i]) ? char.ToLower(charArray[i]) : char.ToUpper(charArray[i]);
                }
                return new string(charArray);
            }
            return inputString;
        }

        //Capitalized version of input string
        public static string Capitalized(this string inputstring)
        {
            if (inputstring.Length > 0)
            {
                char[] charArray = inputstring.ToCharArray();
                //check first letter
                charArray[0] = char.ToUpper(charArray[0]);
                //check remaining letters   
                for (int i = 1; i < inputstring.Length; i++)
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                return new string(charArray);
            }
            return inputstring;
        }


        //Remove Last Char
        public static string RemoveLastChar(this string inputstring)
        {
            if (inputstring.Length > 0)
            {
                string inputstringminus1 = inputstring.Remove(inputstring.Length - 1, 1);
                return inputstringminus1;
            }
            return inputstring;
        }

        //Word Count
        public static int WordCount(this string inputstring)
        {
            if (inputstring.Length > 0)
            {
                string[] words = inputstring.Split(' ');
                return words.Length;
            }
            return 0;
        }

  

        /// <summary>
        /// Lower Case Check
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool AllCharlower(this string inputstring)
        {
            int c = 0;
            int l = inputstring.Length;
            if (inputstring.Length > 0)
            {
                char[] cArray = inputstring.ToCharArray();
                for (int i = 0; i < inputstring.Length; i++)
                {
                    if (char.IsLower(cArray[i]) || char.IsWhiteSpace(cArray[i]))
                    {
                        c++;
                    }
                }
                if (c == l)
                    return true;
            }
            return false;
        }

        /// <summary>
        ///ConvertToTitleCase
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ConvertToTitleCase(this string inputstring)
        {
            if (inputstring.Length > 0)
            {
                string result = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputstring.ToLower());
                return result;
            }
            return inputstring;
        }

        /// <summary>
        ///Check Upper Case
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool AllCharUpper(this string inputString)
        {
            int c = 0;
            int l = inputString.Length;
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (char.IsUpper(charArray[i]) || char.IsWhiteSpace(charArray[i]))
                    {
                        c++;
                    }
                }
                if (c == l)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Convert to INTERGER
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int StrToINT(this string inputstring)
        {
            int x = Int32.Parse(inputstring);
            
            return x;
        }
        /// <summary>
        /// Check Whether number or not
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsValidNumeric(this string inputString)
        {
            if (inputString.Length > 0)
            {
                int no;
                return int.TryParse(inputString, out no);
            }
            return false;
        }


      


       
    }
}
