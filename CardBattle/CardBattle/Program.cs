using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardBattle.Models;
using System.Diagnostics;

namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var spadesAce = new Card(Values.Ace, Suit.Spades);
            
            Console.WriteLine("I created a card: " + spadesAce);

            var dealer = new CardDealer();
            Card randomCard = null;
            /* for (int i = 0; i <= 10; i++)
             {       
                 randomCard = dealer.RandomCard();
                 Console.WriteLine("I drew a card: " + randomCard);
             }*/
            List<Card> dealCard = dealer.Deal(20);
            //dealCard = SortCard.ShakeSort(dealCard);
            foreach (Card c in dealCard)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("");
            //Affiche la valeur suivante des carte rouge
            dealCard = Frob(dealCard).ToList();
            foreach (Card c in dealCard)
            {
                Console.WriteLine(c.ToString());
            }
            foreach(ulong i in GetDiviseur(64))
            {
                Console.WriteLine(i);
            }

            //var watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    List<Card> dealCard = dealer.Deal(9);

            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);

            //foreach(ulong i in Fibanacci().Take(90))
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }      
    }
}
