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
    public partial class Formleavingrequests : Form
    {
        
        public Formleavingrequests()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            /*FormMain formMain = new FormMain();  
            formMain.ShowDialog();
            this.Hide();*/
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True;MultipleActiveResultSets=true");
            con.Open();
            string UName = textBox1.Text;
            string Date1 = dateTimePicker1.Text;
            string DP = textBox3.Text;
            string RB1 = radiosick.Text;
            string RB2 = radiodrappointment.Text;
            string RB3 = radiodeathcase.Text;
            string RB4 = radioother.Text;
            string reason = string.Empty;
            int hours = int.Parse(textBox4.Text);
            
            if (radiosick.Checked)
            {
                reason = RB1;
            }
            if (radiodrappointment.Checked)
            {
                reason = RB2;
            }
            if (radiodeathcase.Checked)
            {
                reason = RB3;
            }
            if (radioother.Checked)
            {
                reason = RB4;
            }

            /* bool Ain;
            ///////////////////////////////////
             SqlCommand cmd1 = new SqlCommand("select User_Role from User_Table where User_Name='" + Username + "'", con);
             SqlDataReader dr1 = cmd1.ExecuteReader();
             if (dr1.Read())
             {
                 Role = dr1.GetValue(0).ToString();
                
             }

             if (Role == "user" || Role== "User")
             {
                 buttondashboard.Visible = false;
                 pictureBox2.Visible = false;
             }
             //////////////////////////////////////////
        
            */
            SqlCommand cmd = new SqlCommand("insert into Leave_request (User_Name,User_Dept, R_Date, Reason, Hours)" +
                "values('" + UName + "','" + DP + "','" + Date1 + "','" + reason + "','" + hours + "');", con);
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("DONE");
            con.Close();

        }

        private void radiosick_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
