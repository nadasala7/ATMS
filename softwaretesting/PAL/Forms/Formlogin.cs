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
    public partial class Formlogin : Form
    {
        
        public Formlogin()
        {
            InitializeComponent();
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void pictureBoxminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxshow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxshow, " Show Password");
        }

        private void pictureBoxhide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxhide, " Hide Password");
        }

        private void pictureBoxshow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxshow.Hide();
            pictureBoxhide.Show();
        }

        private void pictureBoxhide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxshow.Show();
            pictureBoxhide.Hide();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxhide.Hide();
            pictureBoxerror.Hide();
            labelerror.Hide();
           

        }

        private void pictureBoxclose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxclose, " Close");
        }

        private void pictureBoxminimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxminimize, " Minimize");
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True");
           con.Open();
            string userid = textBoxName.Text;  
            string password = textBoxPassword.Text;

            SqlDataAdapter sda = new SqlDataAdapter("select User_Name,User_Pass from User_Table where User_Name='" + userid + "'and User_Pass='" + password + "'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormMain formMain = new FormMain();
                formMain.Username = textBoxName.Text;

                textBoxName.Clear();
                textBoxPassword.Clear();
                pictureBoxhide_Click(sender, e);
                textBoxName.Focus();
                pictureBoxerror.Hide();
                labelerror.Hide();
                
                formMain.FormClosed += new FormClosedEventHandler(formMain_FormClosed);
                this.Hide();
                formMain.Show();


            }
            else
            {

                textBoxName.Clear();
                textBoxPassword.Clear();
                //pictureBoxhide_Click(sender, e);
                textBoxName.Focus();
                labelerror.Visible = true;
                pictureBoxerror.Visible = true;
            }
            
        }
        void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonlogin.PerformClick();
                e.Handled = true;
            }
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            Formforgetpassword formforgetpassword = new Formforgetpassword();
            formforgetpassword.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelerror_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxerror_Click(object sender, EventArgs e)
        {

        }
    }
}
