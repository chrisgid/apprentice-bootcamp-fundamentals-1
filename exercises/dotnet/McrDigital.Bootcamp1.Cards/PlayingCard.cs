using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class PlayingCard : Card
    {
        public string FaceValue { get; }
        public string Suit { get; }

        public override string Value { get => FaceValue; }

        public static string[] FaceValues = new string[]
        {
            "ace",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "jack",
            "queen",
            "king"
        };

        public static string[] Suits = new string[]
        {
            "hearts",
            "spades",
            "diamonds",
            "clubs"
        };

        public PlayingCard(string value, string suit)
        {
            this.FaceValue = value;
            this.Suit = suit;
        }

        public override bool Snap(Card otherCard)
        {
            if (otherCard is PlayingCard card)
            {
                return this.Value == otherCard.Value;
            }

            return false;
        }

        public override string ToString()
        {
            return this.FaceValue + " of " + this.Suit;
        }
    }
}
