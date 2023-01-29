using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Seminar_App_Final_
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                String email = textBox2.Text;
                long n = long.Parse(textBox3.Text);
                int rno = int.Parse(textBox4.Text);
                String sug = textBox5.Text;

                String seminar = " ";

                String course = " ";

                String year = " ";

                if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                {
                    seminar = seminar + " Robotics Today \n ";
                }

                if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
                {
                    seminar = seminar + " Artificial Intelligence \n ";
                }
                if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
                {
                    seminar = seminar + " Web Development \n ";
                }

                if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
                {
                    seminar = seminar + " Cyber Security \n ";
                }

                if (listBox1.SelectedIndex == 0)
                {
                    course = " Computer ";
                }

                else if (listBox1.SelectedIndex == 1)
                {
                    course = " Electrical ";
                }

                else if (listBox1.SelectedIndex == 2)
                {
                    course = " Mechanical ";
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    course = " Civil ";
                }

                if (listBox2.SelectedIndex == 0)
                {
                    year = " FE ";
                }

                else if (listBox2.SelectedIndex == 1)
                {
                    year = " SE ";
                }

                else if (listBox2.SelectedIndex == 2)
                {
                    year = " TE ";
                }
                else if (listBox2.SelectedIndex == 3)
                {
                    year = " BE ";
                }

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source='D:\\REGISTERATION.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                String sql = "insert into[Sheet1$] values ('" + name + "','" + email + "'," + n + "," + rno + ",'" + seminar + "','" + course + "','" + year + "','" + sug + "')";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();

                Form9 f9 = new Form9();
                this.Hide();
                f9.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
