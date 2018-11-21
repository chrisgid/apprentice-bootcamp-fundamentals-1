using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Deck
    {
        public abstract List<Card> Cards { get; }

        public Card Deal()
        {
            var card = this.Cards[0];
            this.Cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            this.Cards.KnuthShuffle();
        }

        public string[] GetCards()
        {
            var result = new String[this.Cards.Count];
            for (var index = 0; index < this.Cards.Count; index++)
            {
                var card = this.Cards[index];
                result[index] = card.ToString();
            }
            return result;
        }

        public void PrintCards()
        {
            var cards = this.GetCards();
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
            
        }
    }
}
