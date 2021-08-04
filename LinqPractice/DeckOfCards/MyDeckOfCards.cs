using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPractice.DeckOfCards
{
    internal class MyDeckOfCards //: SecuenceCards
    {
        /// <summary>
        /// Simple example of a LINQ Query from two datasets.
        /// </summary>
        public void LinqFromTwoDataSets()
        {
            var startingDeck = from s in Suits()
                              from r in Ranks()
                              select new { Suits = s, Ranks = r };

            foreach (var item in startingDeck)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Extension method implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">Represents the top half card deck.</param>
        /// <param name="second">Represents the bottom half card deck.</param>
        /// <returns>A pair of items per time.</returns>
        private static IEnumerable<T> InterLeaveSequenceWith<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }

        /// <summary>
        /// Linq query to manipulate items order.
        /// </summary>
        public void LinqToManipulateOrderCards()
        {
            var startingDeck = from s in Suits()
                              from r in Ranks()
                              select new { Suits = s, Ranks = r };

            var top = startingDeck.Take(26);
            var botton = startingDeck.Skip(26);
            var shuffle = InterLeaveSequenceWith(top, botton);

            foreach (var item in shuffle)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        private static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
