namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class Snap
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Animal snap (a), playing card snap (p) or super snap (s) ?");
            var input = Console.ReadLine();
            if (input.Length > 0 && input[0] == 'a')
            {
                var snap = new Snap(new AnimalDeck());
                snap.Play();
            }
            else if (input.Length > 0 && input[0] == 'p')
            {
                var snap = new Snap(new PlayingCardDeck());
                snap.Play();
            }
            else if (input.Length > 0 && input[0] == 's')
            {
                var snap = new Snap(new SuperDeck());
                snap.Play();
            }
        }

        private int _player1Score;
        private int _player2Score;
        private readonly Deck _deck;

        public Snap(Deck deck)
        {
            this._deck = deck;
            this._deck.Shuffle();
        }

        public void Play()
        {
            Card previousCard = null;
            while (this._deck.GetCards().Length > 0)
            {
                var currentCard = this._deck.Deal();
                Console.WriteLine(currentCard);

                var input = Console.ReadLine();
                if (input.Length > 0 && input[0] == 'a')
                {
                    if (currentCard.Snap(previousCard))
                    {
                        Console.WriteLine("SNAP! score Player 1");
                        this._player1Score++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG! deducting score from Player 1");
                        this._player1Score--;
                    }
                }
                else if (input.Length > 0 && input[0] == 'l')
                {
                    if (currentCard.Snap(previousCard))
                    {
                        Console.WriteLine("SNAP! score Player 2");
                        this._player2Score++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG! deducting score from Player 2");
                        this._player2Score--;
                    }
                }
                previousCard = currentCard;
            }

            if (this._player1Score == this._player2Score)
            {
                Console.WriteLine("Draw.");
            }
            else if (this._player1Score > this._player2Score)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }

            Console.WriteLine($"Scores: {this._player1Score} vs {this._player2Score}");
        }
    }
}