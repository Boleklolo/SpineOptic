namespace SpineOptic
{
    internal class Config
    {
        
        BackgroundForm backgroundForm = new BackgroundForm();
        VisibleForm visibleForm = new VisibleForm();    

        //Database
        //Write here all the data that can be used by software
        public bool isFirstNotifShown = false;
        public bool isSecondNotifShown = false;

        public bool isLucCheat = false;
        public bool isCusCheat = false;

        public int eyeBoxValue = 10;
        public int spineBoxValue = 20;
        public string currentTheme = "Dark Theme";
        public void SaveConfig()
        {
            isFirstNotifShown = backgroundForm.isFirstNotifShown;
            isSecondNotifShown = backgroundForm.isSecondNotifShown;
            isLucCheat = backgroundForm.isLucThemeUnlocked;
            isCusCheat = backgroundForm.isCustomThemeUnlocked;

            eyeBoxValue = Convert.ToInt32(visibleForm.textBox1.Text);
            spineBoxValue = Convert.ToInt32(visibleForm.textBox2.Text);
            currentTheme = visibleForm.comboBox1.Text;

            SaveConfigToFile();
        }
        public void SaveConfigToFile()
        {
            // Define the file path for the config.txt file in your project directory
            string filePath = "config.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the values to the config file
                    writer.WriteLine($"isFirstNotifShown={isFirstNotifShown}");
                    writer.WriteLine($"isSecondNotifShown={isSecondNotifShown}");
                    writer.WriteLine($"isLucCheat={isLucCheat}");
                    writer.WriteLine($"isCusCheat={isCusCheat}");
                    writer.WriteLine($"eyeBoxValue={eyeBoxValue}");
                    writer.WriteLine($"spineBoxValue={spineBoxValue}");
                    writer.WriteLine($"currentTheme={currentTheme}");
                    writer.WriteLine(" ");
                    writer.WriteLine("Where you looking at?");
                }

                MessageBox.Show("Configuration saved to config.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void LoadConfigFromFile()
        {
            //Load config saed by saveconfigtofile
            string filePath = "config.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Split each line into key and value parts
                            string[] parts = line.Split('=');

                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();

                                // Set variables based on the key-value pairs
                                switch (key)
                                {
                                    case "isFirstNotifShown":
                                        isFirstNotifShown = bool.Parse(value);
                                        break;
                                    case "isSecondNotifShown":
                                        isSecondNotifShown = bool.Parse(value);
                                        break;
                                    case "isLucCheat":
                                        isLucCheat = bool.Parse(value);
                                        break;
                                    case "isCusCheat":
                                        isCusCheat = bool.Parse(value);
                                        break;
                                    case "eyeBoxValue":
                                        eyeBoxValue = int.Parse(value);
                                        break;
                                    case "spineBoxValue":
                                        spineBoxValue = int.Parse(value);
                                        break;
                                    case "currentTheme":
                                        currentTheme = value;
                                        break;
                                        // Add more cases for other configuration keys
                                }
                            }
                        }
                    }

                    MessageBox.Show("Configuration loaded from config.txt");
                }
                else
                {
                    MessageBox.Show("Config file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
    }
}
