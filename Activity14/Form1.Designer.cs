namespace Activity14
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
            this.Arial = new System.Windows.Forms.RadioButton();
            this.TimesNewRoman = new System.Windows.Forms.RadioButton();
            this.CourierNew = new System.Windows.Forms.RadioButton();
            this.SansSerif = new System.Windows.Forms.RadioButton();
            this.SelectFont = new System.Windows.Forms.GroupBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ColorListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.SelectFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Arial
            // 
            this.Arial.AutoSize = true;
            this.Arial.Location = new System.Drawing.Point(18, 30);
            this.Arial.Name = "Arial";
            this.Arial.Size = new System.Drawing.Size(45, 17);
            this.Arial.TabIndex = 1;
            this.Arial.Text = "Arial";
            this.Arial.UseVisualStyleBackColor = true;
            this.Arial.CheckedChanged += new System.EventHandler(this.Arial_CheckedChanged);
            // 
            // TimesNewRoman
            // 
            this.TimesNewRoman.AutoSize = true;
            this.TimesNewRoman.Location = new System.Drawing.Point(18, 53);
            this.TimesNewRoman.Name = "TimesNewRoman";
            this.TimesNewRoman.Size = new System.Drawing.Size(115, 17);
            this.TimesNewRoman.TabIndex = 2;
            this.TimesNewRoman.Text = "Times New Roman";
            this.TimesNewRoman.UseVisualStyleBackColor = true;
            this.TimesNewRoman.CheckedChanged += new System.EventHandler(this.TimesNewRoman_CheckedChanged);
            // 
            // CourierNew
            // 
            this.CourierNew.AutoSize = true;
            this.CourierNew.Location = new System.Drawing.Point(18, 76);
            this.CourierNew.Name = "CourierNew";
            this.CourierNew.Size = new System.Drawing.Size(83, 17);
            this.CourierNew.TabIndex = 3;
            this.CourierNew.Text = "Courier New";
            this.CourierNew.UseVisualStyleBackColor = true;
            this.CourierNew.CheckedChanged += new System.EventHandler(this.CourierNew_CheckedChanged);
            // 
            // SansSerif
            // 
            this.SansSerif.AutoSize = true;
            this.SansSerif.Location = new System.Drawing.Point(18, 99);
            this.SansSerif.Name = "SansSerif";
            this.SansSerif.Size = new System.Drawing.Size(116, 17);
            this.SansSerif.TabIndex = 4;
            this.SansSerif.Text = "Sans Serif (Default)";
            this.SansSerif.UseVisualStyleBackColor = true;
            this.SansSerif.CheckedChanged += new System.EventHandler(this.SansSerif_CheckedChanged);
            // 
            // SelectFont
            // 
            this.SelectFont.Controls.Add(this.Arial);
            this.SelectFont.Controls.Add(this.SansSerif);
            this.SelectFont.Controls.Add(this.TimesNewRoman);
            this.SelectFont.Controls.Add(this.CourierNew);
            this.SelectFont.Location = new System.Drawing.Point(45, 46);
            this.SelectFont.Name = "SelectFont";
            this.SelectFont.Size = new System.Drawing.Size(150, 150);
            this.SelectFont.TabIndex = 5;
            this.SelectFont.TabStop = false;
            this.SelectFont.Text = "Select Font";
            this.SelectFont.Enter += new System.EventHandler(this.SelectFont_Enter);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox.Location = new System.Drawing.Point(45, 231);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(550, 26);
            this.TextBox.TabIndex = 6;
            this.TextBox.Text = "Enter a line of text here.";
            // 
            // ColorListBox
            // 
            this.ColorListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ColorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ColorListBox.FormattingEnabled = true;
            this.ColorListBox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Default"});
            this.ColorListBox.Location = new System.Drawing.Point(6, 30);
            this.ColorListBox.Name = "ColorListBox";
            this.ColorListBox.Size = new System.Drawing.Size(120, 95);
            this.ColorListBox.TabIndex = 7;
            this.ColorListBox.SelectedIndexChanged += new System.EventHandler(this.ColorListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorListBox);
            this.groupBox1.Location = new System.Drawing.Point(245, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Underline);
            this.groupBox2.Controls.Add(this.Italic);
            this.groupBox2.Controls.Add(this.Bold);
            this.groupBox2.Location = new System.Drawing.Point(445, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 150);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Font Style";
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Location = new System.Drawing.Point(22, 76);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(71, 17);
            this.Underline.TabIndex = 12;
            this.Underline.Text = "Underline";
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.CheckedChanged += new System.EventHandler(this.Underline_CheckedChanged);
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Location = new System.Drawing.Point(22, 53);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(48, 17);
            this.Italic.TabIndex = 11;
            this.Italic.Text = "Italic";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Location = new System.Drawing.Point(22, 30);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(47, 17);
            this.Bold.TabIndex = 10;
            this.Bold.Text = "Bold";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(655, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SelectFont);
            this.Name = "Form1";
            this.Text = "Controls Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectFont.ResumeLayout(false);
            this.SelectFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Arial;
        private System.Windows.Forms.RadioButton TimesNewRoman;
        private System.Windows.Forms.RadioButton CourierNew;
        private System.Windows.Forms.RadioButton SansSerif;
        private System.Windows.Forms.GroupBox SelectFont;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ListBox ColorListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Underline;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.CheckBox Bold;
    }
}

