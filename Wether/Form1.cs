using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wether
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gismeteo.ua/ua/weather-ivanchi-93071/14-days/");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.meteoprog.ua/ua/review/Ivanchi-rovenska/");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://ua.sinoptik.ua/10-днів");
            this.Close();
        }
    }
}
