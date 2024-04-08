using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordpadKiller
{
    public partial class WordpadKiller : Form
    {
        public WordpadKiller()
        {
            InitializeComponent();
            InitializeFontComboBox();
            InitializeFontSizeComboBox();
            InitializeColorComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BoldButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);

        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontComboBox.SelectedItem != null)
            {
                string fontName = FontComboBox.SelectedItem.ToString();
                Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                Font newFont = new Font(fontName, currentFont.Size, currentFont.Style);
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void InitializeFontComboBox()
        {
            foreach (FontFamily fontFamily in System.Drawing.FontFamily.Families)
            {
                FontComboBox.Items.Add(fontFamily.Name);
            }
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeComboBox.SelectedItem != null)
            {
                if (float.TryParse(SizeComboBox.SelectedItem.ToString(), out float newSize))
                {
                    Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                    Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
        }

        private void InitializeFontSizeComboBox()
        {
            for (int i = 8; i <= 72; i += 2)
            {
                SizeComboBox.Items.Add(i);
            }
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void InitializeColorComboBox()
        {
            ColorComboBox.Items.Add("Black");
            ColorComboBox.Items.Add("Red");
            ColorComboBox.Items.Add("Green");
            ColorComboBox.Items.Add("Blue");
            ColorComboBox.Items.Add("Yellow");
            ColorComboBox.Items.Add("Purple");
            ColorComboBox.Items.Add("Orange");
            ColorComboBox.Items.Add("Brown");
            ColorComboBox.Items.Add("White");
            ColorComboBox.Items.Add("Gray");
            ColorComboBox.Items.Add("Cyan");
            ColorComboBox.Items.Add("Magenta");
            ColorComboBox.Items.Add("Pink");
            ColorComboBox.Items.Add("LightBlue");
            ColorComboBox.Items.Add("DarkGreen");
            ColorComboBox.Items.Add("DarkRed");
            ColorComboBox.Items.Add("DarkBlue");
            ColorComboBox.Items.Add("DarkGray");
            ColorComboBox.Items.Add("LightGray");
        }
        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorComboBox.SelectedItem != null)
            {
                string colorName = ColorComboBox.SelectedItem.ToString();
                Color newColor = Color.FromName(colorName);
                richTextBox1.SelectionColor = newColor;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string fileName = LoadTextBox.Text.Trim();

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            try
            {
                if (File.Exists(fileName))
                {
                    richTextBox1.Text = File.ReadAllText(fileName);
                    MessageBox.Show("File loaded successfully.");
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while loading the file: {ex.Message}");
            }
        }
    
        private void button5_Click(object sender, EventArgs e) // Save Button
        {
            string fileName = SaveTextBox.Text.Trim();

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("File saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while saving the file: {ex.Message}");
            }
        }

        private void SaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
