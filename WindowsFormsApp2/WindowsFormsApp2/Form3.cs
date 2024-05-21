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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input;
            input = textBox1.Text;
            if (input == "console.log(Hello World);") 
            {
                label1.Text = ("Hello World");
            }
            else if (input == "")
            {
                label1.Text = ("Print Hello World");
            }
            else
            {
                label1.Text = ("Error detected");
            }
        }
    }
}
