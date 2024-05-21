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
    public partial class Form2 : Form
    {
        public Form2()

        {

            InitializeComponent();

          

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            
        }

        private void btnback_Click(object sender, EventArgs e)
            {
            this.Owner.Show(); 
            this.Close();

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
           
            f2.Show();
            f2.Owner = this;
            f2.Location = this.Location;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
