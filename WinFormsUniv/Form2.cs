using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUniv
{
    public partial class Form2 : Form
    {
        public string stdName { get; set; }
        public string status { get; set; }
        public string date { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = stdName;
            label3.Text = status;
            label6.Text = date;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
