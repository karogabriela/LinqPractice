using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPractice.Basic
{
    internal class MethodSintax
    {
        public void GetStringList()
        {
            IList<string> myList = new List<string>(){ 
            "Avocate",
            "Strawberry",
            "Banana",
            "Papaya",
            "Watermelon"};

            var results = myList.Where(a => a.Contains("a"));

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
