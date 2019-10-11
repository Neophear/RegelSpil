using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegelSpil
{
    public class Card
    {
        private CardColor _color;
        private CardValue _value;

        public CardColor Color
        {
            get { return _color; }
        }
        public CardValue Value
        {
            get { return _value; }
        }
        public string ImageName
        {
            get { return $"{_color.ToString()[0]}{(int)_value}"; }
        }
        public string GetColor
        {
            get
            {
                switch (_color)
                {
                    case CardColor.Spades:
                        return "Spar";
                    case CardColor.Hearts:
                        return "Hjerte";
                    case CardColor.Diamonds:
                        return "Rude";
                    case CardColor.Clubs:
                        return "Kløver";
                    case CardColor.Joker:
                        return "Joker";
                    default:
                        return "";
                }
            }
        }
        public string GetValue
        {
            get
            {
                switch (_value)
                {
                    case CardValue.Ace:
                        return "Es";
                    case CardValue.Two:
                        return "2";
                    case CardValue.Three:
                        return "3";
                    case CardValue.Four:
                        return "4";
                    case CardValue.Five:
                        return "5";
                    case CardValue.Six:
                        return "6";
                    case CardValue.Seven:
                        return "7";
                    case CardValue.Eight:
                        return "8";
                    case CardValue.Nine:
                        return "9";
                    case CardValue.Ten:
                        return "10";
                    case CardValue.Jack:
                        return "Knægt";
                    case CardValue.Queen:
                        return "Dame";
                    case CardValue.King:
                        return "Konge";
                    default:
                        return "";
                }
            }
        }
        public Card(CardColor Color, CardValue Value)
        {
            _color = Color;
            _value = Value;
        }

        //public static List<Card> GetDeck(int jokerCount = 3)
        //{
        //    List<Card> deck = new List<Card>();

        //    foreach (CardColor col in Enum.GetValues(typeof(CardColor)).Cast<CardColor>().Where(x => x != CardColor.Joker))
        //        foreach (CardValue val in Enum.GetValues(typeof(CardValue)))
        //            deck.Add(new Card(col, val));

        //    //Jokers
        //    for (int i = 0; i < jokerCount; i++)
        //        deck.Add(new Card(CardColor.Joker, 0));

        //    return deck;
        //}

        public enum CardColor
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs,
            Joker
        }

        public enum CardValue
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }
}