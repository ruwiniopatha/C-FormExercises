using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;
namespace Form1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
           // OracleDataAdapter oAdapter;
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_aaaa";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            //OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            /*
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            conn.Close();
            */
            OracleDataAdapter adapterS = new OracleDataAdapter(cmd);
            foreach (DataRow row in dt.Rows)
            {
                //row.SetAdded();
                adapterS.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           
           
        }
            

        /*
         * string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
           // OracleDataAdapter oAdapter;
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from aaaa";
            cmd.CommandType = CommandType.Text;

            using (var adapter = new OracleDataAdapter(cmd))
            {
                conn.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;
            }
         * 
         * 
         */
    }
}
