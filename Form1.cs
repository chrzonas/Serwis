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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_client_add_Click(object sender, EventArgs e)
        {
            Form2 add_client = new Form2();
            add_client.ShowDialog();
        }

        private void Button_settings_Click(object sender, EventArgs e)
        {
            Form3 settings = new Form3();
            settings.ShowDialog();
        }
    }
}
