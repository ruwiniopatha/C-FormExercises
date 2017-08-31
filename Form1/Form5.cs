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
           
            /*
            conn.Open();
            ArrayList rowList = new ArrayList();
            DataTable sTable;   
           // OracleDataReader reader = cmd.ExecuteReader();
            using (var readerl = cmd.ExecuteScalar())
            {
                if (readerl.Read())
                 {

                     object[] values = new object[readerl.FieldCount];
                      readerl.GetValues(values);
                rowList.Add(values);
                   }
            
            }

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            */

            /*
            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                rowList.Add(values);

            }
            DataTable schema = reader.GetSchemaTable();
            *//*
            foreach (object[] row in rowList)
            {
                // Create a string array large enough to hold all
                // the column values in this array
                string[] orderDetails = new string[row.Length];

                // Create a column index into the array
                int columnIndex = 0;

                // Now process each column value
                foreach (object column in row)
                {
                    // Convert the value to a string and stick
                    // it in the string array
                    orderDetails[columnIndex++] = Convert.ToString(column);
                }

                // Now use the string array to create a new item
                // to go in the list view
                //dataGridView1.
                ListViewItem newItem = new ListViewItem(orderDetails);

                // Finally add the new item to the view
                listView1.Items.Add(newItem);
            }

            using (var adapter = new OracleDataAdapter(cmd))
            {
                //conn.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;
            }
            //reader.Close();
            //conn.Close();
           */
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
