using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlackjackApp
{
    public class Card
    {
        public ESuits Suit { get; set; }
        public EValue Value { get; set; }
        public Card(EValue value, ESuits suit)
        {
            Value = value;
            Suit = suit;
        }
        
        public int Points
        {
            get
            {
                if (Value == EValue.King || Value == EValue.Queen || Value == EValue.Jack)
                {
                    return 10;
                }
                if (Value == EValue.Ace)
                {
                    return 11;
                }
                return (int) Value;
            }
        }
    }
}