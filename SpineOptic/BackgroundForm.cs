namespace SpineOptic
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }
        NotificationShower notificationShower = new NotificationShower();
        VisibleForm visibleForm = new VisibleForm();

        //Nie


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
            Application.Exit();
        }
    }
}
