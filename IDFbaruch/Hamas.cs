using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Project
{
    internal class Hamas
    {
        public Terrorist Terrorist;
        public string YearOfEstablishment = "1987";
        public string HeadOfOrganization = "Yahya Sanwar";

        public static Dictionary <string,string> terroristsDictionary = new Dictionary <string,string> ();

        public  void HamasInpho()
        {
            Console.WriteLine($"Year Of Establishment: {YearOfEstablishment}\n "+
            $"Head Of Organization; {HeadOfOrganization}");
        }
        public static Dictionary<string, string> AddTNewTeroris()
        {
            string[] mikoom = { "Home", "Car", "Out"};
            for (int i = 1; i < 6; i++)
            {
                terroristsDictionary.Add("name" + i, " mehabel num " + i + "  "+  Time.GetTime() + "  mikoom: " + mikoom[i/2]);
            }
            return Hamas.terroristsDictionary;           
        }

    }
}
