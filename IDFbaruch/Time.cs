using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class  Time
    {
        public static string GetTime()
        {
            DateTime currentTime = DateTime.Now;
           return currentTime.ToString();
            
        }
            
    }
}
