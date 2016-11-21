using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    class SortCard
    {
        public static List<Card> SortByInsertion(List<Card> unSortList)
        {
            for (var i = 0; i < unSortList.Count; i++)
            {
                for (var j = i + 1; j < unSortList.Count; j++)
                {
                    if (unSortList[i].CompareTo(unSortList[j]) > 0)
                    {
                        var temp = unSortList[i];
                        unSortList[i] = unSortList[j];
                        unSortList[j] = temp;
                    }
                }
            }
            return unSortList;
        }

        public static List<Card> BubbleSort(List<Card> unSortedCard)
        {
            // le i me sert juste à décaler mon sort pour avoir parcours avec un -1 sur chaque
            // iteration
            for (var i = 0; i < unSortedCard.Count; i++)
            {
                for (var j = 0; j < unSortedCard.Count - i - 1; j++)
                {
                    if (unSortedCard[j].CompareTo(unSortedCard[j + 1]) > 0)
                    {
                        var temp = unSortedCard[j];
                        unSortedCard[j] = unSortedCard[j + 1];
                        unSortedCard[j + 1] = temp;
                    }
                }
            }
            return unSortedCard;
        }
        public static List<Card> ShakeSort(List<Card> unSortedCard)
        {
            // On parcours le tableau
            for (var i = 0; i < unSortedCard.Count; i++)
            {
                // on passe tout le tableau de manière croissante
                for (var j = i; j < unSortedCard.Count - i - 1; j++)
                {
                    if (unSortedCard[j].CompareTo(unSortedCard[j + 1]) > 0)
                    {
                        var temp = unSortedCard[j];
                        unSortedCard[j] = unSortedCard[j + 1];
                        unSortedCard[j + 1] = temp;
                    }
                }
                // ON passe tout le tableaux de manière décroissante
                for (var j = unSortedCard.Count - i - 1; j > 0; j--)
                {
                    if (unSortedCard[j].CompareTo(unSortedCard[j - 1]) < 0)
                    {
                        var temp = unSortedCard[j];
                        unSortedCard[j] = unSortedCard[j - 1];
                        unSortedCard[j - 1] = temp;
                    }
                }
            }
            return unSortedCard;
        }

        //public static List<Card> FusionSort(List<Card> unSortedCard)
        //{
        //    if(unSortedCard.Count <= 2)
        //    {
        //        if (unSortedCard.Count == 2 && unSortedCard[0].CompareTo(unSortedCard[1])> 0)
        //        {

        //        }
        //    }
        //    else
        //    {
        //        int middle = unSortedCard.Count / 2;
        //        List<Card> lowList = new List<Card>();
        //        List<Card> higtList = new List<Card>();

        //        for(int i = 0; i < unSortedCard.Count; i++)
        //        {
        //            if (i < middle)
        //            {
        //                lowList.Add(unSortedCard[i]);
        //            }
        //            else
        //            {
        //                higtList.Add(unSortedCard[i]);
        //            }
        //        }              
        //        FusionSort(lowList);
        //        FusionSort(higtList);
        //    }
        //}
        public static List<T> QuickSort<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var result = new List<T>();

            var beforeList = new List<T>();
            var afterList = new List<T>();

            var pivot = list[0];
            foreach (var item in list.Skip(1))
            {
                if (pivot.CompareTo(item) > 0)
                {
                    beforeList.Add(item);
                }
                else
                {
                    afterList.Add(item);
                }
            }

            result.AddRange(QuickSort(beforeList));
            result.Add(pivot);
            result.AddRange(QuickSort(afterList));

            return result;
        }
    }
}
