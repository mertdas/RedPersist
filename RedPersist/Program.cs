using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;

namespace RedPersist
{

    internal class Program
    {

        static void Main(string[] args)
        {
            if (true)
            {
                Information.Banner();

            }
            if (args[0] == "--help" || args[0] == "-h" && args[1] == null)
            {
                Persist.Help1.Do();
            }
            if (args[0] == "--extension")
            {
                Persist.Extension1.Do(args);
            }

            if (args[0] == "--screensaver")
            {
                Persist.ScreenSaver1.Do(args);
            }

            if (args[0] == "--eventviewer")
            {
                Persist.Eventviewer1.Do(args);
            }

            if (args[0] == "--startup")
            {
                Persist.Startup1.Do(args);
            }

            if (args[0] == "--autorun")
            {
                Persist.Autorun1.Do(args);
            }

            if (args[0] == "--wmi")
            {
                Persist.Wmi1.PersistWMI(args);
            }

            if (args[0] == "--schedule")
            {
                Persist.Schedule1.Do(args);
            }

            if (args[0] == "--powershell")
            {
                Persist.Powershell1.Do(args);

            }

            if (args[0] == "--winlogon")
            {
                Persist.Winlogon1.Do(args);

            }
        }
    }
}