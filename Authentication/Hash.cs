using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class Hash
    {
        public static string Encrypt(string text)
        {
            string key = "";
            key += "82s9";
            foreach (char c in text)
            {
                key += Convert.ToInt32(c);
            }
            key += "!Ysa";
            return key;
        }
    }
}
