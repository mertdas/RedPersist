using Microsoft.Win32;
using System;
namespace RedPersist.Persist
{
    public class Help1
    {

        public static void Do()
        {
            Console.WriteLine(" Usage: Redpersist.exe --method C:\\exepath\\file.exe\n");
            Console.WriteLine(" available persistence methods: \n --eventviewer : Persistence via Eventviewer Helper\n --screensaver : Persistence via Screensaver\n --startup : Persistence via Startup\n --extension : Persistence via Extension Hijacking(TXT)\n --wmi : Persistence via Wmi Event Subscription \n --schedule : Persistence Via Scheduled Tasks(Daily) \n --winlogon : Persistence Via UserInitMprLogonScript \n\n To get more information: RedPersist.exe --help methodname");
        }

    }

}
