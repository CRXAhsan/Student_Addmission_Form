using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_country.Items.Add("Pakistan");
            cb_country.Items.Add("Canada");
            cb_country.Items.Add("America");
            cb_country.Items.Add("India");
        }

        private void Cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_city.Items.Clear();
            cb_city.Text = string.Empty;
            cb_province.Items.Clear();
            cb_province.Text = string.Empty;

            if (cb_country.Text == "Pakistan")
            {
                cb_city.Items.Add("Sindh");
                cb_city.Items.Add("Punjab");
                cb_city.Items.Add("Balochistan");
                cb_city.Items.Add("K.P.K");
            }

            else if (cb_country.Text == "Canada")
            {
                cb_city.Items.Add("Alberta");
                cb_city.Items.Add("Ontario");
                cb_city.Items.Add("Quebec");
                cb_city.Items.Add("Manitoba");
            }

            else if (cb_country.Text == "America")
            {
                cb_city.Items.Add("New York");
                cb_city.Items.Add("Washington");
                cb_city.Items.Add("Texas");
                cb_city.Items.Add("New Mexico");
            }

            else if (cb_country.Text == "India")
            {
                cb_city.Items.Add("Bihar");
                cb_city.Items.Add("Chandigarh");
                cb_city.Items.Add("Dehli");
                cb_city.Items.Add("Gujrat");
            }
        }

        private void Cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_province.Items.Clear();
            cb_province.Text = string.Empty;

            if(cb_country.Text == "Pakistan")
            {
                if (cb_city.Text == "Sindh")
                {
                    cb_province.Items.Add("Karachi");
                    cb_province.Items.Add("Hyderabad");
                    cb_province.Items.Add("Sukkhar");
                }
                else if (cb_city.Text == "Punjab")
                {
                    cb_province.Items.Add("Multan");
                    cb_province.Items.Add("Lahore");
                    cb_province.Items.Add("Bhawalpur");
                    cb_province.Items.Add("Rawalpindi");
                }
                else if (cb_city.Text == "Balochistan")
                {
                    cb_province.Items.Add("Quetta");
                    cb_province.Items.Add("Gawadar");
                    cb_province.Items.Add("Pasni");
                    cb_province.Items.Add("Ghotki");
                }
                else if (cb_city.Text == "K.P.K")
                {
                    cb_province.Items.Add("Peshawar");
                    cb_province.Items.Add("Abbatobad");
                    cb_province.Items.Add("Kohat");
                    cb_province.Items.Add("Noshera");
                }
            }

            else if (cb_country.Text == "Canada")
            {
                if (cb_city.Text == "Alberta")
                {
                    cb_province.Items.Add("Banff");
                    cb_province.Items.Add("Brook");
                    cb_province.Items.Add("Jasper");
                }
                else if (cb_city.Text == "Ontario")
                {
                    cb_province.Items.Add("Chatham");
                    cb_province.Items.Add("Hamilton");
                    cb_province.Items.Add("Guelph");
                    cb_province.Items.Add("Fort Erie");
                }
                else if (cb_city.Text == "Quebec")
                {
                    cb_province.Items.Add("Asbestos");
                    cb_province.Items.Add("Beloli");
                    cb_province.Items.Add("Pasni");
                    cb_province.Items.Add("Ghotki");
                }
                else if (cb_city.Text == "Manitoba")
                {
                    cb_province.Items.Add("Brandon");
                    cb_province.Items.Add("Churchill");
                    cb_province.Items.Add(" Dervoil");
                    cb_province.Items.Add("granby");
                }
            }

            else if (cb_country.Text == "America")
            {
                if (cb_city.Text == "New York")
                {
                    cb_province.Items.Add("Atlanta");
                    cb_province.Items.Add("Boise");
                    cb_province.Items.Add("Topika");
                }
                else if (cb_city.Text == "Washington")
                {
                    cb_province.Items.Add("Bostan");
                    cb_province.Items.Add("frankfort");
                    cb_province.Items.Add("Jackson");
                    cb_province.Items.Add("Billings");
                }
                else if (cb_city.Text == "Texas")
                {
                    cb_province.Items.Add("Coulumbus");
                    cb_province.Items.Add("Asutin");
                    cb_province.Items.Add("Hostan");
                    cb_province.Items.Add("Olympia");
                }
                else if (cb_city.Text == "India")
                {
                    cb_province.Items.Add("Seattle");
                    cb_province.Items.Add("Pierre");
                    cb_province.Items.Add("Lincoln");
                    cb_province.Items.Add("Albany");
                }
            }

            else if (cb_country.Text == "India")
            {
                if (cb_city.Text == "Bihar")
                {
                    cb_province.Items.Add("Dehri");
                    cb_province.Items.Add("Gaya");
                    cb_province.Items.Add("Hojapuri");
                }
                else if (cb_city.Text == "Chandigarh")
                {
                    cb_province.Items.Add("Bhilai");
                    cb_province.Items.Add("Dhamtri");
                    cb_province.Items.Add("Durg");
                    cb_province.Items.Add("Raipur");
                }
                else if (cb_city.Text == "Dehli")
                {
                    cb_province.Items.Add("Mandi");
                    cb_province.Items.Add("Nihan");
                    cb_province.Items.Add("Shimla");
                    cb_province.Items.Add("Una");
                }
                else if (cb_city.Text == "Gujrat")
                {
                    cb_province.Items.Add("Okha");
                    cb_province.Items.Add("Patan");
                    cb_province.Items.Add("Panipat");
                    cb_province.Items.Add("Sisrat");
                }
            }


        }
    }
}
