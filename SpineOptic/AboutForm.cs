using System.Diagnostics;

namespace SpineOptic
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        Config Config = new Config();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lucario")
            {
                Config.isLucCheat = true;
            }

            if (textBox1.Text == "1337")
            {
                Config.isCusCheat = true;
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Boleklolo/SpineOptic",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://boleksgarage.cba.pl",
                UseShellExecute = true
            });
        }
    }
}
