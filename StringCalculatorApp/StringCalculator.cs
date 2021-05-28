using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace StringCalculatorApp
{
    public class StringCalculator
    {
        public int StringCalculation(string numbers)
        {
            // Case 1: Take Empty String Return Zero
            if (numbers == "" || numbers == "0")
            {
                return 0;
            }
            // Case 3: Take Two Strings with Commas and Return Sum Of Number
            if (numbers.Contains(',') || numbers.Contains('\n'))
            {
                return ExtractNumberListFromCommaAndLineBreaks(numbers);
            }
            
            // Case 2: Take Single String Return Number
            int result = int.Parse(numbers);
            if (result > 0)
            {
                return result;
            }
            
            return 100;
        }

        private int ExtractNumberListFromCommaAndLineBreaks(string numbers)
        {
            var numberList = new List<int>();
            foreach (string number in numbers.Split(',', '\n'))
            {
                numberList.Add(int.Parse(number));
            }
            // Aggregate = reduce in JS
            return numberList.Aggregate((x, y) => x + y);
        }
    }
}