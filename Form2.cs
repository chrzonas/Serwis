using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox_name_add_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
        }

        private void textBox_surname_add_Click(object sender, EventArgs e)
        {
            textBox_surname.Clear();
        }

        private void textBox_tel_add_Click(object sender, EventArgs e)
        {
            textBox_tel.Clear();
        }

        private void textBox_street_add_Click(object sender, EventArgs e)
        {
            textBox_street.Clear();
        }

        private void textBox_house_number_add_Click(object sender, EventArgs e)
        {
            textBox_house_number.Clear();
        }

        private void textBox_apartment_number_add_Click(object sender, EventArgs e)
        {
            textBox_apartment_number.Clear();
        }

        private void textBox_city_add_Click(object sender, EventArgs e)
        {
            textBox_city.Clear();
        }

        private void textBox_zip_code_add_Click(object sender, EventArgs e)
        {
            textBox_zip_code.Clear();
        }

        private void textBox_post_office_add_Click(object sender, EventArgs e)
        {
            textBox_post_office.Clear();
        }

        private void Button1_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            string tel = textBox_tel.Text;
            string street = textBox_street.Text;
            string house_number = textBox_house_number.Text;
            string apartment_number = textBox_apartment_number.Text;
            string city = textBox_city.Text;
            string zip_code = textBox_zip_code.Text;
            string post_office = textBox_post_office.Text;
        }
    }
}
