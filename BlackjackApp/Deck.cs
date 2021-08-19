using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlackjackApp
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public int NumberOfCards
        {
            get
            {
                return Cards.Count;
            }
        }

        public Deck()
        {
            List<Card> newDeck = new List<Card>();
            List<ESuits> listOfSuits = new List<ESuits> { ESuits.Clubs , ESuits.Diamonds , ESuits.Hearts, ESuits.Spades};
            List<EValue> listOfValues= new List<EValue> {EValue.Ace, EValue.Two, EValue.Three, EValue.Four, EValue.Five, EValue.Six, EValue.Seven, EValue.Eight, EValue.Nine, EValue.Ten, EValue.Jack, EValue.Queen, EValue.King};
            // var listOfValues = Enum.GetValues(typeof(EValue));
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var newCard = new Card(listOfValues[j], listOfSuits[i]);
                    newDeck.Add(newCard);
                }
            }

            Cards = newDeck;
        }
        
    }
}