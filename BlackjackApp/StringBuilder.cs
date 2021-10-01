using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;

namespace BlackjackApp
{
    public class StringBuilder
    {
        public string CurrentPoints(int points )
        {
            return $"You are at currently at {points}";
        }

        public string DisplayCards(List<Card> playersCard)
        {
            var temp = new List<string>();
            foreach (var card in playersCard)
            {
                temp.Add($"['{card.Value.ToString().ToUpper()}','{card.Suit.ToString().ToUpper()}']");
            }

            var cardList = String.Join(",", temp);
            return $"with the hand [{cardList}]";
        }

        public string ChooseHitOrStay()
        {
            return "Hit or stay? (Hit = 1, Stay = 0)";
        }
        
        
    }
}