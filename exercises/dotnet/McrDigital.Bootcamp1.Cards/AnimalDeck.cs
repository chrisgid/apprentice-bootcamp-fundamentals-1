namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class AnimalDeck : Deck
    {

        public override List<Card> Cards { get; }

        public AnimalDeck()
        {
            // Add two cards of each animal type to the deck
            this.Cards = new List<Card>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                this.Cards.Add(new AnimalCard(animal));
                this.Cards.Add(new AnimalCard(animal));
                this.Cards.Add(new AnimalCard(animal));
            }
        }
    }
}