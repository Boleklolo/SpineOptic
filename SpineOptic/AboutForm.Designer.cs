namespace SpineOptic
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 0;
            label1.Text = "By Boleklolo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(12, 64);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github Repo";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(12, 94);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(156, 25);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Website (useless)";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(182, 35);
            label2.TabIndex = 3;
            label2.Text = "Special Thanks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 178);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 4;
            label3.Text = "- Makison";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 203);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 5;
            label4.Text = "- Fvlvte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 253);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 7;
            label5.Text = "- IAmTimCorey";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 228);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 6;
            label6.Text = "- CodeBro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 294);
            label7.Name = "label7";
            label7.Size = new Size(88, 35);
            label7.TabIndex = 8;
            label7.Text = "Secret:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 383);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
    }
}