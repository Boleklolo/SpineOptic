namespace SpineOptic
{
    partial class VisibleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisibleForm));
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            loadConfigToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            Import = new ToolStripMenuItem();
            Export = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dark Theme", "White Theme", "Blue Theme" });
            comboBox1.Location = new Point(88, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-424, -53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1340, 750);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // loadConfigToolStripMenuItem
            // 
            loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            loadConfigToolStripMenuItem.Size = new Size(182, 24);
            loadConfigToolStripMenuItem.Text = "Load config";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Import, Export, About, Exit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // Import
            // 
            Import.Name = "Import";
            Import.Size = new Size(114, 24);
            Import.Text = "Import config";
            Import.ToolTipText = "Import exported config";
            // 
            // Export
            // 
            Export.Name = "Export";
            Export.Size = new Size(112, 24);
            Export.Text = "Export config";
            Export.ToolTipText = "Export a config";
            // 
            // About
            // 
            About.Name = "About";
            About.Size = new Size(64, 24);
            About.Text = "About";
            About.ToolTipText = "About the program...";
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(47, 24);
            Exit.Text = "Exit";
            Exit.ToolTipText = "Exit the program";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-18, -34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(710, 500);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(372, 28);
            label1.TabIndex = 8;
            label1.Text = "Posture Notification Intervals (in seconds)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(378, 28);
            label2.TabIndex = 9;
            label2.Text = "Eye Rest Notification Intervals (in seconds)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 11;
            label3.Text = "Theme";
            // 
            // button1
            // 
            button1.Location = new Point(12, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "EyeTime";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 198);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "SpineTime";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(212, 198);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "SecondNotif";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(312, 198);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "IsFirst";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(412, 198);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 16;
            button6.Text = "Save(kys)";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // VisibleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(557, 228);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(575, 275);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(575, 275);
            Name = "VisibleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spinoptic Dashboard";
            FormClosing += VisibleForm_FormClosing;
            Load += VisibleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem loadConfigToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Import;
        private ToolStripMenuItem About;
        private ToolStripMenuItem Export;
        private ToolStripMenuItem Exit;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        public ComboBox comboBox1;
        public TextBox textBox1;
        public TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}