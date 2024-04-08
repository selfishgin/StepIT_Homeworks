namespace WordpadKiller
{
    partial class WordpadKiller
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LeftAlignButton = new System.Windows.Forms.Button();
            this.CenterAlignButton = new System.Windows.Forms.Button();
            this.RightAlignButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ItalicButton = new System.Windows.Forms.Button();
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.LoadTextBox = new System.Windows.Forms.TextBox();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FontStyleLabel = new System.Windows.Forms.Label();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(923, 408);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FontComboBox
            // 
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(13, 37);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 21);
            this.FontComboBox.TabIndex = 1;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(140, 37);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(40, 21);
            this.SizeComboBox.TabIndex = 2;
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(483, 37);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 3;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLabel.Location = new System.Drawing.Point(59, 18);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(33, 16);
            this.FontLabel.TabIndex = 4;
            this.FontLabel.Text = "Font";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(147, 18);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(33, 16);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "Size";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(521, 18);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 16);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // LeftAlignButton
            // 
            this.LeftAlignButton.Location = new System.Drawing.Point(226, 35);
            this.LeftAlignButton.Name = "LeftAlignButton";
            this.LeftAlignButton.Size = new System.Drawing.Size(23, 23);
            this.LeftAlignButton.TabIndex = 7;
            this.LeftAlignButton.Text = "L";
            this.LeftAlignButton.UseMnemonic = false;
            this.LeftAlignButton.UseVisualStyleBackColor = true;
            this.LeftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // CenterAlignButton
            // 
            this.CenterAlignButton.Location = new System.Drawing.Point(255, 35);
            this.CenterAlignButton.Name = "CenterAlignButton";
            this.CenterAlignButton.Size = new System.Drawing.Size(23, 23);
            this.CenterAlignButton.TabIndex = 8;
            this.CenterAlignButton.Text = "C";
            this.CenterAlignButton.UseVisualStyleBackColor = true;
            this.CenterAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // RightAlignButton
            // 
            this.RightAlignButton.Location = new System.Drawing.Point(284, 35);
            this.RightAlignButton.Name = "RightAlignButton";
            this.RightAlignButton.Size = new System.Drawing.Size(23, 23);
            this.RightAlignButton.TabIndex = 9;
            this.RightAlignButton.Text = "R";
            this.RightAlignButton.UseVisualStyleBackColor = true;
            this.RightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // BoldButton
            // 
            this.BoldButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldButton.Location = new System.Drawing.Point(354, 35);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 23);
            this.BoldButton.TabIndex = 10;
            this.BoldButton.Text = "B";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalicButton.Location = new System.Drawing.Point(383, 35);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(23, 23);
            this.ItalicButton.TabIndex = 11;
            this.ItalicButton.Text = "I";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderlineButton.Location = new System.Drawing.Point(412, 35);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 23);
            this.UnderlineButton.TabIndex = 12;
            this.UnderlineButton.Text = "U";
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // LoadTextBox
            // 
            this.LoadTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoadTextBox.Location = new System.Drawing.Point(642, 11);
            this.LoadTextBox.Name = "LoadTextBox";
            this.LoadTextBox.Size = new System.Drawing.Size(207, 20);
            this.LoadTextBox.TabIndex = 13;
            this.LoadTextBox.TextChanged += new System.EventHandler(this.LoadTextBox_TextChanged);
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SaveTextBox.Location = new System.Drawing.Point(642, 38);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(207, 20);
            this.SaveTextBox.TabIndex = 14;
            this.SaveTextBox.TextChanged += new System.EventHandler(this.SaveTextBox_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(861, 9);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(861, 34);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // FontStyleLabel
            // 
            this.FontStyleLabel.AutoSize = true;
            this.FontStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontStyleLabel.Location = new System.Drawing.Point(360, 18);
            this.FontStyleLabel.Name = "FontStyleLabel";
            this.FontStyleLabel.Size = new System.Drawing.Size(66, 16);
            this.FontStyleLabel.TabIndex = 17;
            this.FontStyleLabel.Text = "Font Style";
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentLabel.Location = new System.Drawing.Point(232, 16);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(66, 16);
            this.AlignmentLabel.TabIndex = 18;
            this.AlignmentLabel.Text = "Alignment";
            // 
            // WordpadKiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 484);
            this.Controls.Add(this.AlignmentLabel);
            this.Controls.Add(this.FontStyleLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.LoadTextBox);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.ItalicButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.RightAlignButton);
            this.Controls.Add(this.CenterAlignButton);
            this.Controls.Add(this.LeftAlignButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.FontComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "WordpadKiller";
            this.Text = "Wordpad Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button LeftAlignButton;
        private System.Windows.Forms.Button CenterAlignButton;
        private System.Windows.Forms.Button RightAlignButton;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button ItalicButton;
        private System.Windows.Forms.Button UnderlineButton;
        private System.Windows.Forms.TextBox LoadTextBox;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label FontStyleLabel;
        private System.Windows.Forms.Label AlignmentLabel;
    }
}

