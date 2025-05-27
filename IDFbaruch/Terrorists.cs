using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Project
{
    internal class Terrorist
    {
        string NameOfTrrorist;       
        public Terrorist(string nameOfTrrorist)
        {
            this.NameOfTrrorist = nameOfTrrorist;
        }
        public string EnterTerroristLevel()
        {
            Console.WriteLine("Please enter terrorist level");
            string level = Console.ReadLine();
            return level;
        }
        public string EnterTerroristStatus()
        {
            Console.WriteLine("Please enter terrorist status");
            string status = Console.ReadLine();
            return status;
        }
        public string EnterTerroristWeapons()
        {
            Console.WriteLine("Please enter terrorist weapons");
            string weapons = Console.ReadLine();
            return weapons;
        }
    }
}
