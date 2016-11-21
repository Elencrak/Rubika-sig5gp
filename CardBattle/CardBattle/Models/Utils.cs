using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    class Utils
    {
        public static IEnumerable<Card> Frob(IEnumerable<Card> input)
        {
            IEnumerable<Card> tempList = input.Where(c => c.Suit == Suit.Hearts || c.Suit == Suit.Diamonds);

            tempList = tempList.Select(c =>
            {
                if (c.Value == Values.Ace)
                    return new Card(Values.Ace, c.Suit);
                else
                    return new Card(c.Value + 1, c.Suit);
            });

            return tempList;
        }

        public static IEnumerable<ulong> Get90Fibo()
        {
            return Fibanacci().Take(90);
        }

        public static ulong GetMultiple(int n, ulong multiple)
        {
            return Get90Fibo().Where(x => x % multiple == 0).Take(n).Last();
        }

        public static IEnumerable<ulong> DivisorFromFibo(int n, ulong multiple)
        {
            //Select many permet d'avoir une liste de liste et en faire qu'une sequence
            return Fibanacci().Where(f => f % multiple == 0).Take(n).SelectMany(GetDiviseur).Distinct().OrderBy(d => d);
        }

        //Récupère tous les nombres permier d'un nombre
        public static IEnumerable<ulong> GetDiviseur(ulong n)
        {
            for (ulong i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    do
                    {
                        n = n / i;
                    } while (n % i == 0);
                }
            }

            if (n != 1)
            {
                yield return n;
            }
        }

        public static IEnumerable<ulong> Fibanacci()
        {
            ulong current = 1;
            ulong previous = 1;

            yield return previous;

            while (true)
            {
                yield return current;

                checked
                {
                    var next = current + previous;
                    previous = current;
                    current = next;
                }
            }
        }

    }
}
