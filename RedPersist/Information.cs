using System;

namespace RedPersist
{
    internal class Information
    {
        public static void Banner()
        {
            var bannerText = @"
                    ______         _______             _     _   
                    | ___ \       | | ___ \           (_)   | |  
                    | |_/ /___  __| | |_/ /__ _ __ ___ _ ___| |_ 
                    |    // _ \/ _` |  __/ _ \ '__/ __| / __| __|
                    | |\ \  __/ (_| | | |  __/ |  \__ \ \__ \ |_ 
                    \_| \_\___|\__,_\_|  \___|_|  |___/_|___/\__|
                                             
                                             

                                Mert Daş @merterpreter
                                   version: v1.0
           

        ";
            Console.WriteLine(bannerText);
        }
    }
}