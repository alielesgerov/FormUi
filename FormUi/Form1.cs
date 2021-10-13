using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FormUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCountryComboBox();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.IconColor = Color.IndianRed;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.IconColor = Color.White;
        }

        private void PopulateCountryComboBox()
        {
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.DisplayName.ToString());
            }

            IEnumerable nameAdded = countryNames.OrderBy(names => names).Distinct();

            foreach (string item in nameAdded)
            {
                cmbbx_Country.Items.Add(item);
            }

        }

        private void WriteToJson()
        {
            List<User> user = new List<User>();
            user.Add(new User()
            {
                Name = txtbx_Name.Text,
                Surname = txtbx_Surname.Text,
                Patronymic = txtbx_Patronymic.Text,
                Address = txtbx_Address.Text,
                ZipCode = txtbx_ZipCode.Text,
                City = txtbx_City.Text,
                Gender=WritingGender(),
                Country = cmbbx_Country.Text,
                PhoneNumber = txtbx_PhoneNumber.Text,
                BirthDate = Convert.ToDateTime(dtpckr_Birthdate.Text)
            });
            string json = JsonConvert.SerializeObject(user.ToArray());
            System.IO.File.WriteAllText(@"C:\Users\User\source\repos\FormUi\FormUi\data.json", json);
        }

        private void ReadFromJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\User\source\repos\FormUi\FormUi\data.json"))
            {
                string json = r.ReadToEnd();
                List<User> user = JsonConvert.DeserializeObject<List<User>>(json);
                txtbx_Name.Text = user[0].Name;
                txtbx_Surname.Text = user[0].Surname;
                txtbx_Patronymic.Text = user[0].Patronymic;
                txtbx_Address.Text = user[0].Address;
                txtbx_ZipCode.Text = user[0].ZipCode;
                txtbx_City.Text = user[0].City;
                ReadingGender(user[0].Gender);
                cmbbx_Country.Text = user[0].Country;
                txtbx_PhoneNumber.Text = user[0].PhoneNumber;
                dtpckr_Birthdate.Text = user[0].BirthDate.ToString();

            }
        }

        private string WritingGender()
        {
            if (rdbtn_Male.Checked == true)
                return rdbtn_Male.Text;
            else if (rdbtn_Female.Checked == true)
                return rdbtn_Female.Text;
            else
                return rdbtn_Other.Text;
        }

        private void ReadingGender(string gender)
        {
            if (gender == "Male")
                rdbtn_Male.Checked = true;
           else if (gender == "Female")
                rdbtn_Female.Checked = true;
           else if (gender == "Other")
                rdbtn_Other.Checked = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            WriteToJson();
            MessageBox.Show("Data saved seccessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ReadFromJson();
        }
    }
}
