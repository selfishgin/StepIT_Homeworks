using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHoverApp
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(900, 600);
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int newX = random.Next(0, this.ClientSize.Width - button.Width);
            int newY = random.Next(0, this.ClientSize.Height - button.Height);
            button.Location = new Point(newX, newY);
        }

    }
}
