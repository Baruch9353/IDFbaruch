using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject_2105
{
    internal class F16 : IWapons, IAmmunition, IEffectiveAgainst, IEnergyBalance,  ILeftAtacks
    {
        string tipe = "1 ton or 0.5 ton";
        string name = "f16";
        string[] target = { "building", "person", "car" }; 

        public string Trike()
        {
            return "was atackt";
        }
        public string NameOfWapon()
        {
            return name;    
        }
        public string NameOfAmmunition()
        {
            return tipe;
        }
        public string[] NameOfTargt()
        {
            return  target;
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
