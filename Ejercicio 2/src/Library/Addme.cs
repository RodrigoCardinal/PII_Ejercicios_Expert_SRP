using System;
using System.Text;

namespace Library
{
    public class Addme
    {
        public static bool AddMe(string[] addme)
        {
            foreach (string a in addme)
            {
                if (string.IsNullOrEmpty(a))
                { 
                return false;
                }
            }
            return true;
        }
    }
}