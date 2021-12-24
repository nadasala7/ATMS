using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace softwaretesting.PAL.Forms
{
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void pictureBox4minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void labelemployeename_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            Close();



           
            /*FormMain formMain = new FormMain();
            formMain.ShowDialog();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True;MultipleActiveResultSets=true");
            con.Open();
            string UName = textBox1.Text;
            string DP = textBox2.Text;
            int Upresence = 0;
            if (radioButton1.Checked)
            {
                Upresence = 1;
            }
            if (radioButton2.Checked)
            {
                Upresence = 0;
            }
            bool Ain ;
            //SqlCommand cmd1 = new SqlCommand("select User_Name,T_Date from ATTENDANCE1 where User_Name='" + UName + "'", con);
            SqlCommand cmd1 = new SqlCommand("select User_Name,T_Date from ATTENDANCE1 where T_Date='"+ dateTimePicker1.Text+"'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                Ain = dr1.GetValue(0).ToString() == UName && dr1.GetValue(1).ToString() == dateTimePicker1.Text;

                if (Ain)
                {

                    MessageBox.Show("Already In ");

                }
                else
                {

                    /*MessageBox.Show(dr1.GetValue(1).ToString() + " " + dateTimePicker1.Text);*/
                    
                    SqlCommand cmd = new SqlCommand("insert into ATTENDANCE1 (User_Name,User_DP,T_Date,User_Presence)" + "values('" + UName + "','" + DP + "','" + dateTimePicker1.Text + "','" + Upresence + "');", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    MessageBox.Show("DONE");
                }

            }
            else 
            {
                //MessageBox.Show("out dr1");
                SqlCommand cmd = new SqlCommand("insert into ATTENDANCE1 (User_Name,User_DP,T_Date,User_Presence)" + "values('" + UName + "','" + DP + "','" + dateTimePicker1.Text + "','" + Upresence + "');", con);

                SqlDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("DONE");
            }


            con.Close();
   
        }
    }
}
