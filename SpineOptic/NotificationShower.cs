using System.Diagnostics;

namespace SpineOptic
{
    internal class NotificationShower
    {
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
            BackgroundForm backgroundForm = new BackgroundForm();   
            if (!backgroundForm.isSecondNotifShown)
            {
                backgroundForm.isSecondNotifShown = true;
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
            }

        }

        public void ShowFirstNotification()
        {
            BackgroundForm backgroundForm = new BackgroundForm();   
            if (backgroundForm.isFirstNotifShown == false)
            {
                backgroundForm.isFirstNotifShown = true;
                //Set working dir
                string projectLocation = Environment.CurrentDirectory;
                //Create cmd process
                Process cmd = new Process();
                //Start cmd with echo command and pause command later
                cmd.StartInfo.FileName = "powershell.exe";
                cmd.StartInfo.WorkingDirectory = projectLocation;
                cmd.StartInfo.Arguments = "-ExecutionPolicy Bypass -File FirstRun.ps1";
                cmd.StartInfo.CreateNoWindow = true;
                //Run minimized to no disturb user
                cmd.Start();
            }
        }

        public void UpdateThemes()
        {   
            BackgroundForm backgroundForm = new BackgroundForm();  
            VisibleForm visibleForm = new VisibleForm();
            //Theme Unlocker
            if (backgroundForm.isLucThemeUnlocked && !visibleForm.comboBox1.Items.Contains("Lucario Theme"))
            {
                visibleForm.comboBox1.Items.Add("Lucario Theme");
            }
            else if (backgroundForm.isCustomThemeUnlocked && !visibleForm.comboBox1.Items.Contains("Custom Theme"))
            {
                visibleForm.comboBox1.Items.Add("Custom Theme");
            }
        }
    }
}
