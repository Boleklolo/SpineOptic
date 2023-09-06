using System.Diagnostics;

namespace SpineOptic
{
    internal class NotificationShower
    {
        readonly Config config = new Config();
        public void ShowEyeNotification()
        {
            //Set working dir
            string projectLocation = Environment.CurrentDirectory;
            //Create cmd process
            Process cmd = new Process();
            //Start cmd
            cmd.StartInfo.FileName = "powershell.exe";
            cmd.StartInfo.WorkingDirectory = projectLocation;
            cmd.StartInfo.Arguments = "-ExecutionPolicy Bypass -File Eyesight.ps1";
            cmd.StartInfo.CreateNoWindow = true;
            //Run minimized to no disturb user
            cmd.Start();
        }

        public void ShowSpineNotification()
        {
            //Set working dir
            string projectLocation = Environment.CurrentDirectory;
            //Create cmd process
            Process cmd = new Process();
            //Start cmd with echo command and pause command later
            cmd.StartInfo.FileName = "powershell.exe";
            cmd.StartInfo.WorkingDirectory = projectLocation;
            cmd.StartInfo.Arguments = "-ExecutionPolicy Bypass -File Posture.ps1";
            cmd.StartInfo.CreateNoWindow = true;
            //Run minimized to no disturb user
            cmd.Start();
        }

        public void ShowExitNotification()
        {
            
            if (!config.isSecondNotifShown)
            {
                config.isSecondNotifShown = true;
                //Set working dir
                string projectLocation = Environment.CurrentDirectory;
                //Create cmd process
                Process cmd = new Process();
                //Start cmd with echo command and pause command later
                cmd.StartInfo.FileName = "powershell.exe";
                cmd.StartInfo.WorkingDirectory = projectLocation;
                cmd.StartInfo.Arguments = "-ExecutionPolicy Bypass -File FirstClose.ps1";
                cmd.StartInfo.CreateNoWindow = true;
                //Run minimized to no disturb user
                cmd.Start();
                //backgroundForm.Close(); //Tu sie odpierdala
                //Fiut nademna juz nie jest potrzebny #frajer
            }

        }

        public void ShowFirstNotification() //This dot work :cry: (a kurwa odwolan nie ma xddddddddddd)
        {
            if (!config.isFirstNotifShown)
            {
                config.isFirstNotifShown = true;
                //Set working dir
                string projectLocation = Environment.CurrentDirectory;
                //Create cmd process
                Process cmd = new Process();
                //Start cmd with echo command and pause command later
                cmd.StartInfo.FileName = "powershell.exe";
                cmd.StartInfo.WorkingDirectory = projectLocation;
                cmd.StartInfo.Arguments = "-ExecutionPolicy Bypass -File FirstRun.ps1";
                cmd.StartInfo.CreateNoWindow = true;
                //Run minimized to not disturb user
                cmd.Start();
            }
        }


    }
}
