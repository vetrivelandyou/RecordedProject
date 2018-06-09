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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Focus();
                }                
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    dateTimePicker1.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox6.Focus();
                }
                else
                {
                    textBox5.Focus();
                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox6.Text.Length > 0)
                {
                    textBox7.Focus();
                }
                else
                {
                    textBox6.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Enter Name");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Enter Mobile No");
            }
            else
            {
                Connection cn = new Connection();
                cn.dataSend(@"INSERT INTO CallDetails (Name, FatherName, Address, Mobile, Date, Time, Duration, Notes, Status)
                            VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox4.Text+"','"+textBox3.Text+"','"+dateTimePicker1.Value.ToString()+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+comboBox1.Text+"')");
                MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallLogManagement.ViewCallDetails VCD = new ViewCallDetails();
            VCD.StartPosition = FormStartPosition.CenterParent;
            VCD.Show();
        }
    }
}
