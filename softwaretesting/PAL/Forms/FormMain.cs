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
    public partial class FormMain : Form
    {
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();
            timerdateandtime.Stop();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {



                timerdateandtime.Stop(); 
                Close();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True");
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select User_Role from User_Table where User_Name='" + Username + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                Role = dr1.GetValue(0).ToString();
                labelrole.Text = Role;
            }

            labelusername.Text = Username;
            
            
            if (Role == "user" || Role== "User")
            {
                buttondashboard.Visible = false;
                pictureBox2.Visible = false;
            }
            dr1.Close();
            con.Close(); 

        }

        private void pictureBox4minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerdateandtime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labeltimer.Text = now.ToString("F");
            
        }
        
        private void MoveSidepanal(Control button)
        {
            panel1.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);

        }
        private void MoveSidePanel(Control button)
        {
            panel1.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void buttondashboard_Click(object sender, EventArgs e)
        {
            Formdashboard formdashboard = new Formdashboard();
            formdashboard.FormClosed += new FormClosedEventHandler(formdashboard_FormClosed);
            this.Hide();
            formdashboard.Show();
            
        }


        void formdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonattendance_Click(object sender, EventArgs e)
        {                    
              FormAttendance formattendance = new FormAttendance();
                    formattendance.FormClosed += new FormClosedEventHandler(formattendance_FormClosed);
                    this.Hide();
                    formattendance.Show();      
            
        /*

            FormAttendance formattendance = new FormAttendance();
            this.Hide();
            formattendance.ShowDialog();*/
            
        }

        void formattendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Ain;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True");
            con.Open();
             DateTime dateTime = DateTime.UtcNow.Date;
             string today = dateTime.ToString("dd-MM-yyyy");
             //MessageBox.Show(today);
             
             SqlCommand cmd2 = new SqlCommand("select User_Name,R_Date,Accepted from Leave_request where R_Date='" + today+ "'", con);
             SqlDataReader dr1 = cmd2.ExecuteReader();
             
             
             if (dr1.Read())
             {
                // MessageBox.Show(dr1.GetValue(0).ToString() + " " + Username);
                 Ain = dr1.GetValue(0).ToString() == Username;
                 if (Ain)
                 {
                     if (dr1.GetValue(2).ToString() == "1")
                     {

                         MessageBox.Show("REQUEST ACCEPTED");
                     }
                     else 
                     {
                         MessageBox.Show("your request is denied");
                         Formleavingrequests formleavingrequests = new Formleavingrequests();
                         formleavingrequests.FormClosed += new FormClosedEventHandler(formleavingrequests_FormClosed);
                         this.Hide();
                         formleavingrequests.Show();
                         
                     }
                 }
                else
                 {
                     Formleavingrequests formleavingrequests = new Formleavingrequests();

                     formleavingrequests.FormClosed += new FormClosedEventHandler(formleavingrequests_FormClosed);
                     this.Hide();
                     formleavingrequests.Show(); 
                     /*
                     SqlCommand cmd = new SqlCommand("insert into ATTENDANCE1 (User_Name,User_DP,T_Date,User_Presence)" + "values('" + UName + "','" + DP + "','" + dateTimePicker1.Text + "','" + Upresence + "');", con);
                     SqlDataReader dr = cmd.ExecuteReader();
                     MessageBox.Show("DONE");
                      * */
                 }

             }
             else
             {
                 Formleavingrequests formleavingrequests = new Formleavingrequests();

                 formleavingrequests.FormClosed += new FormClosedEventHandler(formleavingrequests_FormClosed);
                 this.Hide();
                 formleavingrequests.Show(); 
              /*   SqlCommand cmd = new SqlCommand("insert into ATTENDANCE1 (User_Name,User_DP,T_Date,User_Presence)" + "values('" + UName + "','" + DP + "','" + dateTimePicker1.Text + "','" + Upresence + "');", con);
                 SqlDataReader dr = cmd.ExecuteReader();
                 MessageBox.Show("DONE");*/
             }

            /* formleavingrequests.ShowDialog();
            this.Hide();*/
        }
        void formleavingrequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      } 
    }

