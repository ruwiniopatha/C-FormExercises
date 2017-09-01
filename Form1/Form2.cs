using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Form1
{
    public partial class Form2 : Form
    {
        Validation validInstanstance = new Validation();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label3.Text = DateTime.Now.ToString("dd MMMM");
            this.label4.Text = DateTime.Now.ToString("hh:mm tt");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OracleParameter countpp;
            int count = 0 ;
            string username = textBox1.Text;
            
            if(validInstanstance.validate_as_letters(username)&&validInstanstance.validate_as_numbers(textBox2.Text.ToString())
                &&validInstanstance.check_values_are_null(username)&& validInstanstance.check_values_are_null(textBox2.Text.ToString()))
            {
                int userpass = Convert.ToInt32(textBox2.Text);
            string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "check_data_in_aaaa";
            


            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = "name";
            p1.OracleDbType = OracleDbType.Varchar2;
            p1.Direction = ParameterDirection.Input;
            p1.Value = username;

            OracleParameter p2 = new OracleParameter();
            p1.ParameterName = "pass";
            p2.OracleDbType = OracleDbType.Int32;
            p2.Direction = ParameterDirection.Input;
            p2.Value = userpass;

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "result";
            p5.OracleDbType = OracleDbType.Int32;
            p5.Direction = ParameterDirection.Output;
            OracleParameter[] Params = new OracleParameter[] { p1, p2, p5 };

            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(Params);
            cmd.ExecuteNonQuery();
            object result = cmd.Parameters["result"].Value;
            cmd.Parameters.Clear();
            //Console.WriteLine(cmd.Parameters["result"].Value + " Rows Found.");
            //this.label3.Text = Convert.ToString(result);

            if (Convert.ToInt32(Convert.ToString(result)) == 1)
            {
                MessageBox.Show("Successfully logged in", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Form5 newf = new Form5();
                this.Hide();
                newf.Show();

            }
            else 
            {
                MessageBox.Show("Wrong credentials!", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            }
            else
            {
             MessageBox.Show("Please check the validation rules and enter the values again !!", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ;
            textBox2.Text = "" ;
        }
       
    }
}
