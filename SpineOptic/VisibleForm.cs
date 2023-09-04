﻿namespace SpineOptic
{
    public partial class VisibleForm : Form
    {
        public VisibleForm()
        {
            InitializeComponent();


            //Find CustomTheme.png in project dir
            pictureBox2.ImageLocation = Environment.CurrentDirectory + "\\CustomTheme.png";

            //Set values of textBox1 and 2 to 2

            //Load system
            textBox1.Text = "5";
            textBox2.Text = "10";
            comboBox1.SelectedItem = "Dark Theme";


        }//Initializator
        
        Config config = new Config();
        NotificationShower notificationShower = new NotificationShower();
        private void VisibleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!config.isSecondNotifShown)
            {
                notificationShower.ShowExitNotification();
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
            }
            else if (selectedValue == "Custom Theme")
            {
                pictureBox1.Visible = false;
                //Enable picturebox
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
            textBox1.Text = System.Text.RegularExpressions.Regex.Replace(textBox2.Text, "[^0-9]", "");
            //Remove if char number is higher than 6

            if (textBox1.Text.Length > 6)
            {
                textBox1.Text = textBox2.Text.Remove(6);
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
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;


            switch (itemText)
            {
                case "Export config":
                    MessageBox.Show("Export config");
                    break;

                case "Import config":
                    MessageBox.Show("Import config");
                    break;

                case "About":
                    AboutForm aboutForm = new AboutForm();
                    aboutForm.ShowDialog();
                    break;

                case "Exit":
                    Application.Exit();
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.isLucCheat = true;
            config.isCusCheat = true;

            //config.SaveConfig();

        }


    }
}