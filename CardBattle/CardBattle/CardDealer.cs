using CardBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public class CardDealer
    {
        Random randomNumber;
        private static readonly int suitLenght = Enum.GetNames(typeof(Suit)).Length;
        private static readonly int valueLenght = Enum.GetNames(typeof(Values)).Length;

        public CardDealer()
        {
            randomNumber = new Random();
        }

        public Card RandomCard()
        {               
            int suitRandom = randomNumber.Next(0, suitLenght);
            int valuesRandom = randomNumber.Next(0, valueLenght);

            Card randomCard = new Card((Values) valuesRandom, (Suit)suitRandom);

            return randomCard;
        }

        public List<Card> Deal(int n)
        {
            if (n > 52)
                return null;

            List<Card> listOfAllCard = new List<Card>();
            for(int i = 0; i < suitLenght; i++)
            {
                for(int j = 0; j < valueLenght; j++)
                {
                    listOfAllCard.Add(new Models.Card((Values) j, (Suit) i));
                }
            }

            List<Card> listOfCard = new List<Card>();
            for (int i = 0; i< n; i++)
            {
                int index = randomNumber.Next(0, listOfAllCard.Count);
                listOfCard.Add(listOfAllCard[index]);
                listOfAllCard.RemoveAt(index);
            }
            return listOfCard;
        }

    }
}

