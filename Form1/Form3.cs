using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace Form1
{
    public partial class Form3 : Form
    {

       


        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean IsSuccess = false;
            
            string usernametext = textBox1.Text.ToString();
            int userpassword = Convert.ToInt32(textBox2.Text);
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text.ToString();
            else
                value = radioButton2.Text.ToString();
          
                string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
            /*
                cmd.CommandText = "insert into aaaa values (2,'"+usernametext+"',"+userpassword+")";
                cmd.CommandType = CommandType.Text;
             */
                cmd.CommandText = "insert_data_aaaa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("empno", OracleDbType.Int32, 5).Value = 5;
                cmd.Parameters.Add("ename", OracleDbType.Varchar2, 15).Value = usernametext;
                cmd.Parameters.Add("ssn", OracleDbType.Int32, 9).Value = userpassword;

                //cmd.ExecuteNonQuery();
                int Count = cmd.ExecuteNonQuery();
                MessageBox.Show("Done", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Form2 newForm = new Form2();
                this.Hide();
                newForm.Show();

                if (Count == 1)
                {
                    IsSuccess = true;
                }
                if (IsSuccess)
                { 
                MessageBox.Show("Done", "My Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                conn.Dispose();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    
    }
}
