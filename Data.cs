

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
            //var phoneDialer = CrossMessaging.Current.PhoneDialer;            
            //if (phoneDialer.CanMakePhoneCall)
            //    phoneDialer.MakePhoneCall(number);
        }
    }
}
