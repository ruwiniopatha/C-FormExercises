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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //HookEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("dd MMMM");
            this.label1.Text = DateTime.Now.ToString("hh:mm tt");

            



            //panel1.Location = new Point(panel1.Location.X - 740, panel1.Location.Y);
            //for (int i = -(panel1.Width); i <= 200; i++)
            //{
             //   panel1.Location = new Point(i, panel1.Location.Y);
            //}
            //Util.Animate(panel1, Util.Effect.Slide, 10, 20);
            //label1.Font = new Font("Lucida Fax", 30);
            //label2.Font = new Font("Arial", 20);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            //child.MdiParent = this;
            this.Hide();
            child.Show();
        }
        /*
               private void FadeIn(Label o, int interval = 80) 
               {
                   //Object is not fully invisible. Fade it in
                   while (o.Opacity < 1.0)
                   {
                   await Task.Delay(interval);
                   o.Opacity += 0.05;
                   }
                   o.Opacity = 1; //make fully visible       
               }
        
       
               private void HookEvents()
               {
                   foreach (Control ctl in this.Controls)
                   {
                       ctl.MouseClick += new MouseEventHandler(Form1_MouseClick);
                   }
               }

               void Form1_MouseClick(object sender, MouseEventArgs e)
               {
                   //LogEvent(sender, "MouseClick");
                   Form2 child = new Form2();
                   //child.MdiParent = this;
                   this.Hide();
                   child.Show();
               }
               */
        // and then this just logs to a multiline textbox you have somwhere on the form
        /*
        private void LogEvent(object sender, string msg)
        {
            this.textBox1.Text = string.Format("{0} {1} ({2}) \n {3}",
                DateTime.Now.TimeOfDay.ToString(),
                msg,
                sender.GetType().Name,
                textBox1.Text
                );
        }*/

   
       

        
        
    }
}
