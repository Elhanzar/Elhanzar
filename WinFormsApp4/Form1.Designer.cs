namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            sizePenToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(705, 311);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, clearToolStripMenuItem, colorsToolStripMenuItem, sizePenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(705, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(46, 20);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(53, 20);
            colorsToolStripMenuItem.Text = "Colors";
            colorsToolStripMenuItem.Click += colorsToolStripMenuItem_Click;
            // 
            // sizePenToolStripMenuItem
            // 
            sizePenToolStripMenuItem.Name = "sizePenToolStripMenuItem";
            sizePenToolStripMenuItem.Size = new Size(153, 20);
            sizePenToolStripMenuItem.Text = "Handle line thickness size";
            sizePenToolStripMenuItem.Click += sizePenToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 34);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.System;
            button8.Location = new Point(213, 5);
            button8.Name = "button8";
            button8.Size = new Size(23, 23);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(184, 5);
            button7.Name = "button7";
            button7.Size = new Size(23, 23);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(155, 5);
            button6.Name = "button6";
            button6.Size = new Size(23, 23);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(126, 5);
            button5.Name = "button5";
            button5.Size = new Size(23, 23);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(97, 5);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(39, 5);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(68, 5);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(10, 5);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(trackBar1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 0);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Top;
            trackBar1.Location = new Point(0, 0);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(233, 45);
            trackBar1.TabIndex = 0;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 369);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private ToolStripMenuItem sizePenToolStripMenuItem;
        private Button button8;
        private Panel panel2;
        private TrackBar trackBar1;
    }
}