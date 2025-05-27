using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFproject_2105;

namespace IDF_Project
{
    internal class IdfMenu 
    {
        string CommanderName = "eyal zamir";
        int YearOfStart = 1948;

        public IdfMenu(string name,int year)
        {
             CommanderName= name ;
             YearOfStart= year ;
        }
        public void printer()
        {
            Console.WriteLine($"IDF\n commander:{CommanderName} \n start in{YearOfStart}");
        }
        //public string CommanderName(string name)
        //{
        //    return name;
        //}
        //public int YearOfStart(int year)
        //{
        //    return year;
        //}
        public void OptionsOfStrike()
        {
            Console.WriteLine("menu of strikes\n1. f16\n2.zik\n3 cannon");
            string answer =  Console.ReadLine();
            switch (answer)
            {
                case "1":
                    //F16 plain = new F16();
                    //plain.GetILeftAtacks(2);
                    //plain.LeftEnergyBalance(23);
                    //plain.NameOfWapon("");
                    //plain.NameOfAmmunition("");
                    //plain.NameOfTargt(["vghbgb"]);
                    break;
                case "2":

                    break;
                case "3":

                    break;

                
            }
            
        }
        
    }
}
