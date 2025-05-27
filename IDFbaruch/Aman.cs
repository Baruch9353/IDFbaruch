using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class Aman
    {
        public static Dictionary<string, string> Inteligentes()
        {
            return Hamas.AddTNewTeroris();    
        }
        public static void printInteligentes()
        {
            Inteligentes();
            foreach (var value in Hamas.terroristsDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
    
}
