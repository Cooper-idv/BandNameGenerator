using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class Kata003
    {
        public static string BandNameGenerator(string str)
        {
            string newBandName = "";
            if (string.IsNullOrEmpty(str))
            {
                return newBandName;
            }
            if (str.Length < 2)
            {
                return newBandName.Insert(0,"The ").Insert(4, str.ToUpper());
            }
            if ( string.Compare(str.Substring(0,1), str.Substring(str.Length-1), true) == 0)
            {
                newBandName = string.Format("{0}{1}{1}", str.Substring(0, 1).ToUpper(), str.Substring(1));
            }
            else
            {
                newBandName = string.Format("{0}{1}{2}", "The ", str.Substring(0, 1).ToUpper(), str.Substring(1));
            }

            return newBandName;
        }
    }
}
