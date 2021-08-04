using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPractice.Basic
{
    internal class QuerySintax
    {
        /// <summary>
        /// LINQ Query from Array
        /// </summary>
        /// <param name="myNumbers"></param>
        /// <returns></returns>
        public void LinqToArray(string[] myNumbers)
        {
            //linq query - from / where / select
            var myLinqQuery = from number in myNumbers
                              where number.Contains('o')
                              select number;

            foreach (var number in myLinqQuery)
            {
                Console.WriteLine(number);
            }
        }
    }
}
