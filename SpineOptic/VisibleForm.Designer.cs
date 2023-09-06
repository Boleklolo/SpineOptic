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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            loadConfigToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            Import = new ToolStripMenuItem();
            Export = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-425, -288);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1008, 542);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { Import, Export, About });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(542, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // Import
            // 
            Import.Name = "Import";
            Import.Size = new Size(102, 24);
            Import.Text = "Load config";
            Import.ToolTipText = "Load Config";
            Import.Click += Import_Click;
            // 
            // Export
            // 
            Export.Name = "Export";
            Export.Size = new Size(100, 24);
            Export.Text = "Save config";
            Export.ToolTipText = "Save a config";
            Export.Click += Export_Click;
            // 
            // About
            // 
            About.Name = "About";
            About.Size = new Size(64, 24);
            About.Text = "About";
            About.ToolTipText = "About the program...";
            About.Click += About_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(542, 185);
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(404, 135);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 12;
            label4.Text = "By Boleklolo";
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
            // VisibleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(542, 178);
            Controls.Add(label4);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(560, 225);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(560, 225);
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
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBox1;
        public TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        public ComboBox comboBox1;
    }
}