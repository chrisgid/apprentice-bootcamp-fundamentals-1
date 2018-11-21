using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Card
    {
        public abstract string Value { get; }
        public abstract bool Snap(Card otherCard);
    }
}
