using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Load_SQL_to_DataGridComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ClassMate;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From StudentInformation", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.HeaderText = "Select Data";
            //cmb.Name = "cmb";
            //cmb.MaxDropDownItems = 4;
            //cmb.Items.Add("True");
            //cmb.Items.Add("False");
            //dataGridView1.Columns.Add(cmb);

           // string[] StringList = { "item A1", "item B1", "item C1" };
            ArrayList StringList = new ArrayList();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select * From Holiday", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            foreach (DataRow item in dt1.Rows)
            {
                StringList.Add(item["Description"].ToString());
            }

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                var CellSample = new DataGridViewComboBoxCell();
                CellSample.DataSource = StringList;

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["StudentName"].ToString();
                dataGridView1.Rows[n].Cells[2] = CellSample;
            }

        }
    }
}
