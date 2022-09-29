using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{
    internal class Data
    {
        public static string gurskogo = "";
        public static string chapaeva = "";
        public static void InvokeDialer(string number)
        {
            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Default.Open(number);
        }
    }
}
