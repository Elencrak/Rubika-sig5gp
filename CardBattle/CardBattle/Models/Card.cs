using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }


    public enum Value
    {
        Seven,
        Eight,
        Nine,
        Ten,
        Jacks,
        Queen,
        King,
        Ace
    }
    class Card
    {
        public Card(Value values, Suit suit)
        {
            Suit = suit;
            Values = values;
        }
        public Suit Suit { get; set; }
        public Value Values { get; set; }

        public override string ToString()
        {

            return Suit.ToString() + Values.ToString();
        }
    }
}
