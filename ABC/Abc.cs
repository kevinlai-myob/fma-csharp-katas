using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc
{
    public class Abc
    {
        private List<BlockPairs> _blocks = new List<BlockPairs>
        {
            new BlockPairs('B', 'O'),
            new BlockPairs('X', 'K'),
            new BlockPairs('A', 'N'),
            new BlockPairs('O', 'B'),
            new BlockPairs('D', 'Q'),
            new BlockPairs('C', 'P'),
            new BlockPairs('N', 'A'),
            new BlockPairs('G', 'T'),
            new BlockPairs('R', 'E'),
            new BlockPairs('T', 'G'),
            new BlockPairs('Q', 'D'),
            new BlockPairs('F', 'S'),
            new BlockPairs('J', 'W'),
            new BlockPairs('H', 'U'),
            new BlockPairs('V', 'I'),
            new BlockPairs('E', 'R'),
            new BlockPairs('F', 'S'),
            new BlockPairs('L', 'Y'),
            new BlockPairs('P', 'C'),
            new BlockPairs('Z', 'M'),
        };

        public bool CanMakeWord(string letter)
        {
            var splitLetters = letter.ToUpper().ToList();
            
            var blockComparision = new List<char>();
            
            if (letter.Length == 1)
            {
                return true;
            }

            foreach (char item in splitLetters)
            {
                foreach (BlockPairs block in _blocks)
                {
                    
                    var isExist = block.Pieces[0].Equals(item) || block.Pieces[1].Equals(item);

                    var x = block.Pieces[0].Equals(item);
                    var y = block.Pieces[1].Equals(item);
                    
                    if (block.isAvailable && isExist)
                    {
                        blockComparision.Add(item);
                        block.isAvailable = false;
                        break;
                    }
                }
            }
            
            string yo = String.Join("", blockComparision);
            Console.Write(yo);
            if (yo.Equals(letter.ToUpper()))
            {
                return true;
            }
            
            return false;
            

        }
        


    }
    
}