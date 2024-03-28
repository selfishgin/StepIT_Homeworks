using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntroToWindowsForms
{
    internal class IntroToWPF : Form
    {
        [STAThread] 
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false); 

            Form form = new Form();
            form.Text = "Hello Windows Forms!";
            form.Size = new System.Drawing.Size(900, 840);
            form.Icon = new Icon("C:\\Users\\Antec\\source\\repos\\IntroToWindowsForms\\stepitlogo_deu_icon.ico");

            Button buttonBaku = new Button();
            buttonBaku.Location = new System.Drawing.Point(100, 50); 
            
            Button buttonLondon = new Button();
            buttonLondon.Location = new System.Drawing.Point(450, 50);

            string bakuTimeZoneId = "Azerbaijan Standard Time";
            string londonTimeZoneId = "GMT Standard Time";

            DateTime localTime = DateTime.Now;

            TimeZoneInfo bakuTimeZone = TimeZoneInfo.FindSystemTimeZoneById(bakuTimeZoneId);
            TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById(londonTimeZoneId);

            DateTime bakuTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, bakuTimeZone);
            DateTime londonTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, londonTimeZone);

            Image bakuImage = Image.FromFile("C:\\Users\\Antec\\source\\repos\\IntroToWindowsForms\\baku.jpg");
            Image londonImage = Image.FromFile("C:\\Users\\Antec\\source\\repos\\IntroToWindowsForms\\london.jpg");

            buttonBaku.Width = 350;
            buttonBaku.Height = 600;
            buttonBaku.Image = bakuImage;
            buttonBaku.Click += (sender, e) => MessageBox.Show($"Baku date and time: {bakuTime}");            

            buttonLondon.Width = 350;
            buttonLondon.Height = 600;
            buttonLondon.Image = londonImage;
            buttonLondon.Click += (sender, e) => MessageBox.Show($"London date and time: {londonTime}");

            form.Controls.Add(buttonBaku);
            form.Controls.Add(buttonLondon);

            Application.Run(form); 
        }

    }
}
