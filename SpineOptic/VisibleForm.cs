using System.Security.Cryptography.X509Certificates;

namespace SpineOptic
{
    public partial class VisibleForm : Form
    {
        public VisibleForm()
        {
            InitializeComponent();
            //Find CustomTheme.png in project dir
            pictureBox2.ImageLocation = Environment.CurrentDirectory + "\\CustomTheme.png";
        }

        readonly Config config = new Config();
        readonly NotificationShower notificationShower = new NotificationShower();
        readonly About aboutForm = new About();
        private void VisibleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent the form from closing
            e.Cancel = true;
            config.SaveConfigToFile();
            // Hide the form
            this.Hide();
            if (!config.isSecondNotifShown)
            {
                notificationShower.ShowExitNotification();
                config.isSecondNotifShown = true;
            }

        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedValue = comboBox1.SelectedItem.ToString();

            if (selectedValue == "Lucario Theme")
            {
                //Enable picturebox
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (selectedValue == "Custom Theme")
            {
                //Enable picturebox
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                //Disable picturebox
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }

            // Perform actions based on the selected item
            switch (selectedValue)
            {
                case "White Theme":
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.BackColor = Color.White;
                    break;

                case "Dark Theme":
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.BackColor = Color.FromArgb(40, 40, 40);
                    break;

                case "Blue Theme":
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case "Lucario Theme":
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;

                    break;
                case "Custom Theme":
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    break;

                default:
                    // Handle unexpected selection
                    MessageBox.Show("Unknown selection.");
                    break;
            }
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Remove non-numeric characters
            textBox1.Text = System.Text.RegularExpressions.Regex.Replace(textBox1.Text, "[^0-9]", "");

            //Remove if char number is higher than 6

            if (textBox1.Text.Length > 6)
            {
                textBox1.Text = textBox1.Text.Remove(6);
            }
            // Check if the textbox is empty (it might be after removing non-numeric characters)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = Convert.ToString(0); // Set a default value or handle this case as needed
            }

        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {

            // Remove non-numeric characters
            textBox2.Text = System.Text.RegularExpressions.Regex.Replace(textBox2.Text, "[^0-9]", "");
            //Remove if char number is higher than 6
            if (textBox2.Text.Length > 6)
            {
                textBox2.Text = textBox2.Text.Remove(6);
            }
            // Check if the textbox is empty (it might be after removing non-numeric characters)
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = Convert.ToString(0); // Set a default value or handle this case as needed
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.isLucCheat = true;
            config.isCusCheat = true;
        }


        private void VisibleForm_Load(object sender, EventArgs e)
        {
            config.LoadConfigFromFile();
            textBox1.Text = Convert.ToString(config.eyeBoxValue);
            textBox2.Text = Convert.ToString(config.spineBoxValue);
            comboBox1.Text = Convert.ToString(config.currentTheme);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateThemes();
            FixNulls();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            ExportValues();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ImportValues();
        }

        private void About_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        public void ImportValues()
        {
            config.LoadConfigFromFile();
            textBox1.Text = Convert.ToString(config.eyeBoxValue);
            textBox2.Text = Convert.ToString(config.spineBoxValue);
            comboBox1.Text = Convert.ToString(config.currentTheme);


        }
        public void ExportValues()
        {
            config.eyeBoxValue = Convert.ToInt32(textBox1.Text);
            config.spineBoxValue = Convert.ToInt32(textBox2.Text);
            config.currentTheme = comboBox1.SelectedItem.ToString();
            config.SaveConfigToFile();
        }
        public void UpdateThemes()
        {
            //Theme Unlocker
            //if config.isLucCheat = true and no Lucario Theme in combobox1
            if (config.isLucCheat == true && !comboBox1.Items.Contains("Lucario Theme"))
            {
                comboBox1.Items.Add("Lucario Theme");
            }
            //ditto but with config.isCusCheat and no Custom Theme in combobox1
            if (config.isCusCheat == true && !comboBox1.Items.Contains("Custom Theme"))
            {
                comboBox1.Items.Add("Custom Theme");
            }
        }
        public void FixNulls()
        {
            //Pretty self explainatory, fixes unhandled exceptions for saving/loading config
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.SelectedItem = "Dark Theme";
            }
            if (textBox1.Text == null)
            {
                textBox1.Text = "20";
            }
            if (textBox2.Text == null)
            {
                textBox2.Text = "20";
            }
        }

    }
}
