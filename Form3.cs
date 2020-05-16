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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Wybierz plik",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mdf",
                Filter = "pliki bazy danych (*.mdf)|*.mdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_file.Text = openFileDialog1.FileName;
            }
        }

        private void Button_load_database_Click(object sender, EventArgs e)
        {
            string datebase_path = textBox_file.Text;

            if (datebase_path == "")
            {
                System.Windows.Forms.MessageBox.Show("Wybierz plik!", "Błąd");
            }
            else
            {

            }
        }
    }
}
