namespace GVMSAPR
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ReflectX = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonContrastTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSharp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущее разрешение изображения";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(606, 58);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 13);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X =";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelY.Location = new System.Drawing.Point(693, 58);
            this.labelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 13);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Y =";
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.BackgroundImage = global::GVMSAPR.Properties.Resources.Increase;
            this.buttonIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIncrease.Location = new System.Drawing.Point(536, 158);
            this.buttonIncrease.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(54, 57);
            this.buttonIncrease.TabIndex = 9;
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.BackgroundImage = global::GVMSAPR.Properties.Resources.Decrease_;
            this.buttonDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDecrease.Location = new System.Drawing.Point(478, 158);
            this.buttonDecrease.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(54, 57);
            this.buttonDecrease.TabIndex = 8;
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonDecrease_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::GVMSAPR.Properties.Resources.ReflectY;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(536, 95);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 57);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReflectX
            // 
            this.ReflectX.BackgroundImage = global::GVMSAPR.Properties.Resources.icons8_отразить_по_вертикали_96;
            this.ReflectX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReflectX.Location = new System.Drawing.Point(478, 95);
            this.ReflectX.Margin = new System.Windows.Forms.Padding(2);
            this.ReflectX.Name = "ReflectX";
            this.ReflectX.Size = new System.Drawing.Size(54, 57);
            this.ReflectX.TabIndex = 3;
            this.ReflectX.UseVisualStyleBackColor = true;
            this.ReflectX.Click += new System.EventHandler(this.ReflectX_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.BackgroundImage = global::GVMSAPR.Properties.Resources.RotateRight;
            this.buttonRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateRight.Location = new System.Drawing.Point(536, 32);
            this.buttonRotateRight.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(54, 57);
            this.buttonRotateRight.TabIndex = 2;
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.BackgroundImage = global::GVMSAPR.Properties.Resources.RotateLeft;
            this.buttonRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateLeft.Location = new System.Drawing.Point(478, 32);
            this.buttonRotateLeft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(54, 57);
            this.buttonRotateLeft.TabIndex = 1;
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(429, 399);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(429, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(478, 239);
            this.buttonInvert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(92, 19);
            this.buttonInvert.TabIndex = 10;
            this.buttonInvert.Text = "Инверсия";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // buttonContrastTest
            // 
            this.buttonContrastTest.Location = new System.Drawing.Point(4, 54);
            this.buttonContrastTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContrastTest.Name = "buttonContrastTest";
            this.buttonContrastTest.Size = new System.Drawing.Size(113, 19);
            this.buttonContrastTest.TabIndex = 11;
            this.buttonContrastTest.Text = "Подтвердить";
            this.buttonContrastTest.UseVisualStyleBackColor = true;
            this.buttonContrastTest.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonContrastTest);
            this.groupBox1.Location = new System.Drawing.Point(602, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(122, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контрастность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "от -100 до 100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 12;
            // 
            // buttonSharp
            // 
            this.buttonSharp.Location = new System.Drawing.Point(478, 291);
            this.buttonSharp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSharp.Name = "buttonSharp";
            this.buttonSharp.Size = new System.Drawing.Size(92, 20);
            this.buttonSharp.TabIndex = 13;
            this.buttonSharp.Text = "Четкость";
            this.buttonSharp.UseVisualStyleBackColor = true;
            this.buttonSharp.Click += new System.EventHandler(this.Sharpen_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 440);
            this.Controls.Add(this.buttonSharp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.buttonIncrease);
            this.Controls.Add(this.buttonDecrease);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReflectX);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.Button ReflectX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonContrastTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSharp;
    }
}

