namespace McrDigital.Bootcamp1.Cards
{
    public class AnimalCard : Card
    {
        private readonly Animal _animal;
        public override string Value { get => this.ToString(); }

        public AnimalCard(Animal animal)
        {
            this._animal = animal;
        }

        public Animal Animal
        {
            get => this._animal;
        }

        public override bool Snap(Card otherCard)
        {

            if (otherCard is AnimalCard card)
            {
                return this._animal == card._animal;
            }

            return false;
        }

        public override string ToString()
        {
            return this._animal.ToString();
        }
    }
}