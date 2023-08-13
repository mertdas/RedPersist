using Microsoft.Win32;
using System;
using System.IO;

namespace RedPersist.Persist
{

    public class Powershell1
    {
       public static void Do(string[] args)
        {
            System.IO.Directory.CreateDirectory(args[1]);
            StreamWriter dosya = new StreamWriter(args[2]);
            string veri;
            veri = args[3];
            dosya.WriteLine(veri);
            dosya.Close();
            Console.WriteLine("[*] Powershell Persistence created");
        }


    }
}
