using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class SuperDeck : Deck
    {
        public override List<Card> Cards { get; }

        public SuperDeck()
        {
            this.Cards = new List<Card>();

            PlayingCardDeck playingCardDeck = new PlayingCardDeck();

            var deckLength = playingCardDeck.Cards.Count;
            for (int i = 0; i < deckLength; i++)
            {
                this.Cards.Add(playingCardDeck.Deal());
            }

            AnimalDeck animalDeck = new AnimalDeck();

            deckLength = animalDeck.Cards.Count;
            for (int i = 0; i < deckLength; i++)
            {
                this.Cards.Add(animalDeck.Deal());
            }

            this.PrintCards();
        }
    }
}
