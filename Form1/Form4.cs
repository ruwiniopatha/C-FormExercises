using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("dd MMMM");
            this.label1.Text = DateTime.Now.ToString("hh:mm tt");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            //child.MdiParent = this;
            this.Hide();
            child.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            //child.MdiParent = this;
            this.Hide();
            child.Show();
        }
    }
}
