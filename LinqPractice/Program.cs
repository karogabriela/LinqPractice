using LinqPractice.Basic;
using LinqPractice.DeckOfCards;
using System;
using System.Collections.Generic;
using LinqPractice.EasyLogger;

namespace LinqPractice
{
    /// <summary>
    /// Linq supports query and method sintax.
    /// Steps for a linq query:
    ///     - Obtain the source
    ///     - Create the query
    ///     - Execute the query
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Welcome to LinqPractice project!!\"");

            //Basic examples
            //LINQ Query from Array
            Console.WriteLine("\n\n¡¡LINQ Query from an Array!!");
            LinqToArray();

            //LINQ method query
            Console.WriteLine("\n\n¡¡LINQ Method Query from an IList!!");
            GetStringList();

            //DeckOfCards examples
            //LINQ Query from two datasets
            Console.WriteLine("\n\n¡¡LINQ Query from two datasets!!");
            LinqFromTwoDataSets();

            //Linq query to manipulate items order.
            Console.WriteLine("\n\n¡¡Linq query to manipulate items order!!");
            LinqToManipulateOrderCards();

            Console.WriteLine("\n\n¡¡Mix two collections to get a new one and logging any new item.!!");
            MixingColors();

            Console.WriteLine("\n\n¡¡THANKS!!");
        }

        private static void LinqToArray()
        {
            string[] myNumbers = { "one", "two", "three" };
            QuerySintax querySintax = new QuerySintax();
            querySintax.LinqToArray(myNumbers);
        }

        private static void GetStringList()
        {
            MethodSintax methodSintax = new MethodSintax();
            methodSintax.GetStringList();
        }
        private static void LinqFromTwoDataSets()
        {
            MyDeckOfCards myDeckOfCards = new MyDeckOfCards();
            myDeckOfCards.LinqFromTwoDataSets();
        }

        private static void LinqToManipulateOrderCards()
        {
            MyDeckOfCards myDeckOfCards = new MyDeckOfCards();
            myDeckOfCards.LinqToManipulateOrderCards();
        }

        private static void MixingColors()
        {
            Colors.MixingColors();
        }
    }
}
