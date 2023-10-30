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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string textBox1Value = Form1.Instance.textBox1.Text;
            string textBox2Value = Form1.Instance.textBox2.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = Path.Combine(desktopPath, "savedData.txt");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
             writer.WriteLine("userName : " + textBox1Value);
             writer.WriteLine("password : " + textBox2Value);
            }

            label1.Text = "اطلاعات ذخیره شد";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
