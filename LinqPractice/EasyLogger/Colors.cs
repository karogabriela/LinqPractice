using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPractice.EasyLogger
{
    internal static class Colors
    {
        private static IEnumerable<T> LogQuery<T>(this IEnumerable<T> secuence, string tag)
        {
            using (var writter = File.AppendText("debug.log"))
            {
                writter.Write($"\nExecuting query: {tag}");
            }
            return secuence;
        }

        /// <summary>
        /// Mix two collections to get a new one and logging any new item.
        /// </summary>
        public static void MixingColors()
        {
            var mixColors = (from l in LightColors().LogQuery("Getting Light Colors")
                             from d in DarkColors().LogQuery("Getting Dark Colors")
                             select new { LightColors = l, DarkColors = d }).LogQuery("Mixing colors");

            foreach (var item in mixColors)
            {
                Console.WriteLine(item);
            }
        }
        private static IEnumerable<string> LightColors()
        {
            yield return "White";
            yield return "Grey";
            yield return "LightBlue";
            yield return "Yellow";
            yield return "Beige";
        }

        private static IEnumerable<string> DarkColors()
        {
            yield return "Black";
            yield return "Purple";
            yield return "Green";
            yield return "Red";
        }
    }
}
