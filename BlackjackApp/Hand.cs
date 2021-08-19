using System.Collections.Generic;

namespace BlackjackApp
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public int Value
        {
            // write conditions if else ( if ace = 1 or 11)
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