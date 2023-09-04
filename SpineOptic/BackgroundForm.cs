namespace SpineOptic
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }
        public bool isFirstNotifShown = false;
        public bool isSecondNotifShown = false;
        public bool isLucThemeUnlocked = false;
        public bool isCustomThemeUnlocked = false;

        NotificationShower notificationShower = new NotificationShower();


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }


        private void EyeTimer_Tick(object sender, EventArgs e)
        {
            notificationShower.ShowEyeNotification();
        }

        private void SpineTimer_Tick(object sender, EventArgs e)
        {
            notificationShower.ShowSpineNotification();
        }

        private void ThemeTimer_Tick(object sender, EventArgs e)
        {
            notificationShower.UpdateThemes();
        }

        private void showFormAboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openForm();
        }
        private void openForm()
        {
            //If there is an existing instance of visibleform, move to front, if not, open
            if (Application.OpenForms.OfType<VisibleForm>().Count() == 1)
            {
                Application.OpenForms.OfType<VisibleForm>().First().BringToFront();
            }
            else
            {
                VisibleForm visibleForm = new VisibleForm();
                visibleForm.Show();
            }
        }
    }
}
