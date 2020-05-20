namespace PaintLite
{
    partial class ChooseColor
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
            this.Red = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(35, 32);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(27, 13);
            this.Red.TabIndex = 19;
            this.Red.Text = "Red";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Other Colors";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(201, 107);
            this.numeric_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(120, 20);
            this.numeric_Blue.TabIndex = 15;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.numeric_Blue_ValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(201, 69);
            this.numeric_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(120, 20);
            this.numeric_Green.TabIndex = 14;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.numeric_Green_ValueChanged);
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(201, 32);
            this.numeric_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(120, 20);
            this.numeric_Red.TabIndex = 13;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.numeric_Red_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(92, 107);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(80, 17);
            this.Scroll_Blue.TabIndex = 12;
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(92, 69);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(80, 17);
            this.Scroll_Green.TabIndex = 11;
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.Scroll_Green_ValueChanged);
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(92, 32);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(80, 17);
            this.Scroll_Red.TabIndex = 10;
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.Scroll_Red_ValueChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(35, 69);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 13);
            this.Green.TabIndex = 20;
            this.Green.Text = "Green";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(35, 107);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(28, 13);
            this.Blue.TabIndex = 21;
            this.Blue.Text = "Blue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(350, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 95);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Red);
            this.Name = "ColorsForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}