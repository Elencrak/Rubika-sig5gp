using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardBattle.Models;
namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(Value.Ace, Suit.Spades);
            Console.WriteLine(card.ToString());
            Console.ReadLine();
        }
    }
}
