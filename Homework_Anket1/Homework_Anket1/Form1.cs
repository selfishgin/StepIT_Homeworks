using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Homework_Anket1
{
    public partial class Form1 : Form
    {
        private List<SurveyItem> surveyItems = new List<SurveyItem>();
        private const string defaultFileName = "survey.json";
        private string currentFileName = defaultFileName;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSurveyData(currentFileName);
        }

        private void ƏlavəEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdText.Text) ||
                string.IsNullOrWhiteSpace(SoyadText.Text) ||
                string.IsNullOrWhiteSpace(EmailText.Text) ||
                string.IsNullOrWhiteSpace(TelefonText.Text) ||
                string.IsNullOrWhiteSpace(DoğumTarixiBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSurveyItem = new SurveyItem
            {
                Ad = AdText.Text,
                Soyad = SoyadText.Text,
                Email = EmailText.Text,
                Telefon = TelefonText.Text,
                DoğumTarixi = DoğumTarixiBox.Value
            };

            listBox.Items.Add(newSurveyItem);

            surveyItems.Add(newSurveyItem);

            ClearFields();
        }

        private void ClearFields()
        {
            AdText.Clear();
            SoyadText.Clear();
            EmailText.Clear();
            TelefonText.Clear();
            DoğumTarixiBox.Value = DateTime.Now;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSurveyData();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            currentFileName = Ad.Text.Trim();
            LoadSurveyData(currentFileName);
        }

        private void SaveSurveyData()
        {
            string fileName = FaylAdı.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
                fileName = defaultFileName;

            List<SurveyItem> existingData = new List<SurveyItem>();
            if (File.Exists(fileName))
            {
                string existingJsonData = File.ReadAllText(fileName);
                existingData = JsonConvert.DeserializeObject<List<SurveyItem>>(existingJsonData);
            }

            existingData.AddRange(surveyItems);

            string jsonData = JsonConvert.SerializeObject(existingData);

            File.WriteAllText(fileName, jsonData);

            MessageBox.Show("Survey information saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void LoadSurveyData(string fileName)
        {
            if (File.Exists(fileName))
            {
                string jsonData = File.ReadAllText(fileName);
                surveyItems = JsonConvert.DeserializeObject<List<SurveyItem>>(jsonData);

                SurveyItem selectedItem = surveyItems.Find(item => item.Ad == FaylAdı.Text);

                if (selectedItem != null)
                {
                    AdText.Text = selectedItem.Ad;
                    SoyadText.Text = selectedItem.Soyad;
                    EmailText.Text = selectedItem.Email;
                    TelefonText.Text = selectedItem.Telefon;
                    DoğumTarixiBox.Value = selectedItem.DoğumTarixi;

                    MessageBox.Show("Survey information loaded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No survey information found for the specified name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No saved survey information found for the specified file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dəyiş_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SurveyItem selectedSurveyItem = (SurveyItem)listBox.SelectedItem;
            selectedSurveyItem.Ad = AdText.Text;
            selectedSurveyItem.Soyad = SoyadText.Text;
            selectedSurveyItem.Email = EmailText.Text;
            selectedSurveyItem.Telefon = TelefonText.Text;
            selectedSurveyItem.DoğumTarixi = DoğumTarixiBox.Value;

            listBox.Items[listBox.SelectedIndex] = selectedSurveyItem;

            surveyItems[listBox.SelectedIndex] = selectedSurveyItem;

            MessageBox.Show("Survey information updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                SurveyItem selectedSurveyItem = (SurveyItem)listBox.SelectedItem;
                AdText.Text = selectedSurveyItem.Ad;
                SoyadText.Text = selectedSurveyItem.Soyad;
                EmailText.Text = selectedSurveyItem.Email;
                TelefonText.Text = selectedSurveyItem.Telefon;
                DoğumTarixiBox.Value = selectedSurveyItem.DoğumTarixi;
            }
        }


    }

    public class SurveyItem
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime DoğumTarixi { get; set; }

        public override string ToString()
        {
            return $"{Ad}";
        }
    }
}
