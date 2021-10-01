using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pangram
{
    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            if (input == "") return false;
            if (UniqueCount(input)) return false;
            
            return true;
        }

        private static bool UniqueCount(string input) => (new HashSet<char>(LowerCased(input))).Count != 26;
        private static string LowerCased(string input) => SpacesRemoved(input).ToLower();
        private static string SpacesRemoved(string input) => Regex.Replace(input, @"[^a-zA-Z]", "");
    }
}