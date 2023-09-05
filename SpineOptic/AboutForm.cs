namespace SpineOptic
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Updatelabels();
        }

        int i;
        private void Updatelabels()
        {
            
            i++;
            Config config = new Config();
            //Update labels using config.cs data
            label1.Text = config.isFirstNotifShown.ToString();
            label2.Text = config.isSecondNotifShown.ToString();
            label3.Text = config.isLucCheat.ToString();
            label4.Text = config.isCusCheat.ToString();
            label5.Text = config.eyeBoxValue.ToString();
            label6.Text = config.spineBoxValue.ToString();
            label7.Text = config.currentTheme.ToString();
            label8.Text = Convert.ToString(i);

        }
    }
}
