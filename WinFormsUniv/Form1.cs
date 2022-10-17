using System.Windows.Forms;

namespace WinFormsUniv
{
    public partial class Form1 : Form
    {
        public string named { get; set; }
        public string status { get; set; }
        public string date { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.stdName = textBox1.Text;
            form.date = dateTimePicker1.Text;
            form.status = status;
            form.ShowDialog();  


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            status = "Mahasiswa ITTS";
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            status = "Dosen ITTS";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            status = "Tamu ITTS";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}