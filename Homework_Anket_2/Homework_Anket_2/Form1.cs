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
using System.Xml.Linq;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using static Homework_Anket_2.Form1;

namespace Homework_Anket_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataHandler dataHandler = new DataHandler();

        public class DataHandler
        {
            private string filePath = "userdata.json";
            private List<UserData> userDataList;

            public DataHandler()
            {
                userDataList = LoadUserDataList();
            }

            private List<UserData> LoadUserDataList()
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<UserData>>(json);
                }
                else
                {
                    return new List<UserData>();
                }
            }

            public void SaveUserData(UserData userData)
            {
                if (userDataList == null)  // Initialize if null
                {
                    userDataList = new List<UserData>();
                }

                userDataList.Add(userData); // ERROR

                string json = JsonConvert.SerializeObject(userDataList);

                File.WriteAllText(filePath, json);

                MessageBox.Show("Anket məlumatları yükləndi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            public UserData LoadUserData(string name)
            {
                if (userDataList != null)
                {
                    foreach (UserData userData in userDataList)
                    {
                        if (userData.Name == name)
                        {
                            return userData;
                        }
                    }

                }
                return null;
            }
        }



        public class UserData
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Father { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserData userData = new UserData
            {
                Name = Ad.Text,
                Surname = Soyad.Text,
                Father = AtaAdı.Text,
                Country = Ölkə.Text,
                City = Şəhər.Text,
                Phone = Telefon.Text,
                BirthDate = DoğumTarixi.Value,
                Gender = Kişi.Checked ? "Kişi" : "Qadın"
            };
            dataHandler.SaveUserData(userData);

            // save eledikden sonra boxlar temizlenir
            Ad.Text = "";
            Soyad.Text = "";
            AtaAdı.Text = "";
            Ölkə.Text = "";
            Şəhər.Text = "";
            Telefon.Text = "";
            DoğumTarixi.Value = DateTime.Now; 
            Kişi.Checked = false; 
            Qadın.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = AnketorAdı.Text;
            UserData userData = dataHandler.LoadUserData(name);

            if (userData != null)
            {
                Ad.Text = userData.Name;
                Soyad.Text = userData.Surname;
                AtaAdı.Text = userData.Father;
                Ölkə.Text = userData.Country;
                Şəhər.Text = userData.City;
                Telefon.Text = userData.Phone;
                DoğumTarixi.Value = userData.BirthDate;
                if (userData.Gender == "Kişi")
                    Kişi.Checked = true;
                else
                    Qadın.Checked = true;
            }
            else
            {
                MessageBox.Show("Belə bir məlumat mövcud deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AnketorAdı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
