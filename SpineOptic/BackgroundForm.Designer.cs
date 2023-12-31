﻿namespace SpineOptic
{
    partial class BackgroundForm
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
            NotifyIcon notifyIcon1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            ToolStripMenuItem showFormAboutToolStripMenuItem;
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            EyeTimer = new System.Windows.Forms.Timer(components);
            SpineTimer = new System.Windows.Forms.Timer(components);
            CheckerTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            showFormAboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Right click to show options, double click to open.";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showFormAboutToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 52);
            // 
            // showFormAboutToolStripMenuItem
            // 
            showFormAboutToolStripMenuItem.Name = "showFormAboutToolStripMenuItem";
            showFormAboutToolStripMenuItem.Size = new Size(151, 24);
            showFormAboutToolStripMenuItem.Text = "Dashboard";
            showFormAboutToolStripMenuItem.Click += showFormAboutToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(151, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // EyeTimer
            // 
            EyeTimer.Enabled = true;
            EyeTimer.Interval = 5000;
            EyeTimer.Tick += EyeTimer_Tick;
            // 
            // SpineTimer
            // 
            SpineTimer.Enabled = true;
            SpineTimer.Interval = 5000;
            SpineTimer.Tick += SpineTimer_Tick;
            // 
            // CheckerTimer
            // 
            CheckerTimer.Enabled = true;
            CheckerTimer.Tick += checkerTimer_Tick;
            // 
            // BackgroundForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BackgroundForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += BackgroundForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showFormAboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer EyeTimer;
        private System.Windows.Forms.Timer SpineTimer;
        private System.Windows.Forms.Timer CheckerTimer;
    }
}