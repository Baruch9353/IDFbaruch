using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject_2105
{
    internal class Drone : IWapons, IAmmunition, IEffectiveAgainst, IEnergyBalance, ILeftAtacks
    {
        string tipe = "fue types of bombs";
        string name = "drone";
        string[] target = { "person", "car" };

        
        public string NameOfWapon()
        {
            return name;
        }
        public string NameOfAmmunition()
        {
            return tipe;
        }
        public string [] NameOfTargt()
        {
            return target;
        }
        public int LeftEnergyBalance(int num)
        {
            return num;
        }
        public int GetILeftAtacks(int num)
        {
            return num;
        }
    }
}
