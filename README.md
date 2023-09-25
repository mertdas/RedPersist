# RedPersist

![redpersist](https://user-images.githubusercontent.com/48562581/201777510-1f868f4d-a273-403d-8270-6f8b0cb865d5.png)

RedPersist is a Windows Persistence tool written in C#

## Compiling Project

Below 3rd party libraries are used in this project.

<b>TaskScheduler</b><br>https://github.com/dahall/TaskScheduler<br>
<b>Fody</b><br>	https://github.com/Fody/Fody<br><br>
Load the Visual Studio project up and go to "Tools" > "NuGet Package Manager" > "Package Manager Settings"<br>
Open "NuGet Package Manager" > "Package Sources"<br><br>
<b>Install the Fody</b><br>``Install-Package Costura.Fody -Version 3.3.3``<br><br>
<b>Install the Taskscheduler</b><br>``Install-Package TaskScheduler -Version 2.8.11``

![image](https://github.com/mertdas/RedPersist/assets/48562581/d7a4b3e9-9ef3-4bd4-86b6-cb162975c2c6)


## Usage

You can use it with execute-assembly or standalone executable

``RedPersist.exe --method C:\Path\to\executable.exe``<br>
``RedPersist.exe --help``

## Available Methods

<b>--help/-h</b> : Help Menu<br>
``RedPersist.exe --help``<br><br>
<b>--eventviewer</b> : Persistence via Eventviewer Helper<br>
``RedPersist.exe --eventviewer C:\Users\User\exe.exe``<br><br>
<b>--startup</b>     : Persistence via Startup and Autologon<br>
``RedPersist.exe --startup C:\Users\User\exe.exe``<br><br>
<b>--screensaver</b> : Persistence via Screensaver<br>
``RedPersist.exe --screensaver C:\Users\User\exe.exe``<br><br>
<b>--wmi</b>         : Persistence via Wmi Event Subscription(To Notepad.exe)<br>
``RedPersist.exe --wmi C:\Users\User\exe.exe``<br><br>
<b>--schedule</b>    : Persistence via Scheduled Tasks<br>
``RedPersist.exe --schedule TaskName C:\Users\User\exe.exe``<br><br>
<b>--extension</b>   : Persistence via Extension Hijacking(TXT)<br>
``RedPersist.exe --extension C:\Users\User\exe.exe``<br><br>
<b>--winlogon</b>   : Persistence via UserInitMprLogonScript<br>
``RedPersist.exe --winlogon TaskName C:\Users\User\exe.exe``<br><br>
<b>--powershell</b>   : Persistence via Powershell Profile<br>
``RedPersist.exe--pwsh C:\Users\User\Documents\windowspowershell C:\Users\User\Documents\windowspowershell\profile.ps1 C:\Users\User\Desktop\exe.exe``<br>

![image](https://user-images.githubusercontent.com/48562581/201770794-8518b92b-6315-4924-817a-71cefd975c41.png)
