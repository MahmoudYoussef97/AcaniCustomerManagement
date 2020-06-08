using System;

namespace Acani.Common
{
    public static class StringHandler
    {   
        /// <summary>
        /// Insert sapces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if(!string.IsNullOrEmpty(source))
            {
                foreach (var letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
