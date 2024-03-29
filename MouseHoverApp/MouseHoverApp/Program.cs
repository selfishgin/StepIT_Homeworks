using System;
using System.Windows.Forms;

namespace MouseHoverApp
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // Enable visual styles for the application
            Application.SetCompatibleTextRenderingDefault(false); // Set compatibility with older versions of Windows Forms

            // Create and show your Windows Forms application


            Application.Run(new Form1()); // Start the application message loop


        }
    }
}
