using System;
using System.Collections.Generic;

namespace Abc
{
    public class BlockPairs
    {

        public List<char> Pieces { get; set; }
        public bool isAvailable = true;
        public BlockPairs(char piece1, char piece2)
        {
            var newBlock = new List<char>{piece1, piece2};
            Pieces = newBlock;
        }
    }
}