using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegelSpil
{
    class Deck : List<Card>
    {
        Random rnd = new Random();
        public delegate void CardDrawnEventHandler(object sender, CardDrawnEventArgs args);
        public event CardDrawnEventHandler OnCardDrawn;

        public Deck(int jokerCount = 3)
        {
            foreach (Card.CardColor col in Enum.GetValues(typeof(Card.CardColor)).Cast<Card.CardColor>().Where(x => x != Card.CardColor.Joker))
                foreach (Card.CardValue val in Enum.GetValues(typeof(Card.CardValue)))
                    this.Add(new Card(col, val));

            //Jokers
            for (int i = 0; i < jokerCount; i++)
                this.Add(new Card(Card.CardColor.Joker, 0));
        }
        public Card DrawCard()
        {
            if (this.Count == 0)
                throw new NoMoreCardsException();
            else
            {
                Card drawnCard = this[rnd.Next(0, this.Count())];
                this.Remove(drawnCard);

                //Fire event
                OnCardDrawn?.Invoke(this, new CardDrawnEventArgs(drawnCard, this.Count));

                return drawnCard;
            }
        }

        public class CardDrawnEventArgs : EventArgs
        {
            public Card DrawnCard { get; private set; }
            public int CardsLeft { get; private set; }
            public CardDrawnEventArgs(Card drawnCard, int cardsLeft)
            {
                DrawnCard = drawnCard;
                CardsLeft = cardsLeft;
            }
        }

        public class NoMoreCardsException : Exception { }
    }
}
