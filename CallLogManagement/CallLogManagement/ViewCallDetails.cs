using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogManagement
{
    public partial class ViewCallDetails : Form
    {
        public ViewCallDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.dataGet("Select * from CallDetails where Date = '" + dateTimePicker1.Value.ToString("yyyy/dd/MM") + "'");
            DataTable dt = new DataTable();
            cn.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSno"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["dgFatherName"].Value = row["FatherName"].ToString();
                dataGridView1.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["dgMobile"].Value = row["Mobile"].ToString();
                dataGridView1.Rows[n].Cells["dgDate"].Value =  Convert.ToDateTime(row["Date"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["dgTime"].Value = row["Time"].ToString();
                dataGridView1.Rows[n].Cells["dgDuration"].Value = row["Duration"].ToString();
                dataGridView1.Rows[n].Cells["dgRemarks"].Value = row["Notes"].ToString();
                dataGridView1.Rows[n].Cells["dgStatus"].Value = row["Status"].ToString();
            }
        }
    }
}
