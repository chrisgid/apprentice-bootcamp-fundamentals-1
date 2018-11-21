using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class PlayingCardDeck : Deck
    {

        public override List<Card> Cards { get; }

        public PlayingCardDeck()
        {
            this.Cards = new List<Card>();

            foreach (var suit in PlayingCard.Suits)
            {
                foreach (var value in PlayingCard.FaceValues)
                {
                    this.Cards.Add(new PlayingCard(value, suit));
                }
            }
        }
    }
}
