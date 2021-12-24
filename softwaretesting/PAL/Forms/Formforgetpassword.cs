using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace softwaretesting.PAL.Forms
{
    public partial class Formforgetpassword : Form
    {
        public Formforgetpassword()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxclose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxclose, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "dohasameh@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "dohasameh@gmail.com")
                pictureBoxerror.Show();
            else
                pictureBoxerror.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {/*
            if (textBoxEmail.Text == string.Empty)
            {
                textBoxEmail.Text = "Enter Your Email";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "dohasameh@gmail.com")
                pictureBoxerror.Show();
            else
                pictureBoxerror.Hide();*/
        }

        private void pictureBoxerror_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxerror, "Invalid Email!");
        }

        private void buttonverify_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True");
            con.Open();
            string UEmail = textBoxEmail.Text;
            
            SqlCommand cmd = new SqlCommand("select User_Name,User_Pass from User_Table where User_Email='" + UEmail + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hello "+dr.GetValue(0).ToString()+"\nyour Password is:" + dr.GetValue(1).ToString());
            }
            else
            {
                MessageBox.Show("User Not Found");
            }
            con.Close();
            //if (!IsValidEmail(textBoxEmail.Text)
              //  string userName = 
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void Formforgetpassword_Load(object sender, EventArgs e)
        {
            pictureBoxerror.Hide();
        }
  
    }
}
