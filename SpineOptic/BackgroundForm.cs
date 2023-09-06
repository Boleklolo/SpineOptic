namespace SpineOptic
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
            //Set timer intervals

            EyeTimer.Interval = config.eyeBoxValue * 1000;
            SpineTimer.Interval = config.spineBoxValue * 1000;
            sus();
        }
        NotificationShower notificationShower = new NotificationShower();
        VisibleForm visibleForm = new VisibleForm();
        Config config = new Config();

        private void checkerTimer_Tick(object sender, EventArgs e)
        {
            currentEye = config.eyeBoxValue;
            currentSpine = config.spineBoxValue;
        }

        int currentEye;
        int currentSpine;
        int a;
        int b;

        public void sus()
        {
            int a = config.eyeBoxValue;
            int b = config.spineBoxValue;
        }
        private void EyeTimer_Tick(object sender, EventArgs e)
        {
            if (a != currentEye)
            {
                // Stop the timer
                EyeTimer.Stop();

                // Change the interval
                EyeTimer.Interval = config.eyeBoxValue * 1000;

                // Start the timer again with the new interval
                EyeTimer.Start();

                a = config.eyeBoxValue;
            }
            notificationShower.ShowEyeNotification();
        }

        private void SpineTimer_Tick(object sender, EventArgs e)
        {
            if (b != currentSpine)
            {
                // Stop the timer
                SpineTimer.Stop();

                // Change the interval
                SpineTimer.Interval = config.spineBoxValue * 1000;

                // Start the timer again with the new interval
                SpineTimer.Start();

                b = config.spineBoxValue;
            }
            notificationShower.ShowSpineNotification();
        }

        private void showFormAboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openForm();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openForm();
        }
        private void openForm()
        {
            visibleForm.Show();
            if (Application.OpenForms.OfType<VisibleForm>().Count() == 1)
            {
                Application.OpenForms.OfType<VisibleForm>().First().BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {
            if (!config.isFirstNotifShown)
            {
                notificationShower.ShowFirstNotification();
                config.isFirstNotifShown = true;
            }
        }
    }
}
