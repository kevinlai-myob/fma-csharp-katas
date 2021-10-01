using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Acronym
{
    public class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            if (phrase == String.Empty) return "";
            

            var removeSpecialChars = Regex.Replace(phrase, @"[^a-zA-Z\s\-]", "");
            
            var splitUpperPhrase= removeSpecialChars.Split(' ', '-');
            
            var firstLetterList = AddEveryLetterToList(splitUpperPhrase);

            var joinedAcronym = String.Join("", firstLetterList);

            return joinedAcronym;
        }

        private static List<string> AddEveryLetterToList(string[] splitUpperPhrase)
        {
            List<string> firstLetterList = new List<string>();

            foreach (string word in splitUpperPhrase)
            {
                if (word != String.Empty)
                {
                    var firstLetterOfEachWord = word[0].ToString().ToUpper();

                    firstLetterList.Add(firstLetterOfEachWord);
                }
            }

            return firstLetterList;
        }
    }
}