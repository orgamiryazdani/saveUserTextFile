using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

         Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                form2.Show();
                form2.TopMost = true;
                form2.TopMost = false;
            }
            else
            {
                label3.Text = "لطفا هر دو تکست باکس را پر کنید";
            }
        }
    }
}
