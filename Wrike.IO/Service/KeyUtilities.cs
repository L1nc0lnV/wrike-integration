using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Wrike.IO.Service
{
    public class KeyUtilities
    {
        public static string GetKey(string keyPath)
        {
            using (StreamReader sr = new StreamReader(keyPath))
            {
                var key = sr.ReadToEnd();
                return key;
            }
               
        }
        
    }
}
