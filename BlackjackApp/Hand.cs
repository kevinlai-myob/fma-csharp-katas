using System.Collections.Generic;

namespace BlackjackApp
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public int Value
        {
            get
            {
                var points = 0;
                for (int i = 0; i < Cards.Count; i++)
                {
                    points += (int)Cards[i].Value;
                }

                return points;
            }
        }
        
        public Hand(List<Card> cards)
        {
            Cards = cards;
        }
    }
}