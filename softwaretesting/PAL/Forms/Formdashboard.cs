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
    public partial class Formdashboard : Form
    {
        public Formdashboard()
        {
            InitializeComponent();
        }

        private void Formdashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance_Management_SystemDataSet1.Leave_request' table. You can move, or remove it, as needed.
            this.leave_requestTableAdapter.Fill(this.attendance_Management_SystemDataSet1.Leave_request);
            // TODO: This line of code loads data into the 'attendance_Management_SystemDataSet.Attendance1' table. You can move, or remove it, as needed.
            this.attendance1TableAdapter.Fill(this.attendance_Management_SystemDataSet.Attendance1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            Close();
           /* FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Hide();*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonaccept_Click(object sender, EventArgs e)
        {
            string UName = textBox1.Text;
            int accepeted = 1;
            bool Ain;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True;MultipleActiveResultSets=true");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select User_Name from Leave_request where User_Name='" + UName + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                Ain = dr1.GetValue(0).ToString() == UName;

                if (Ain)
                {
                    SqlCommand cmd = new SqlCommand("update Leave_request set Accepted = '" + accepeted + "' where User_Name = '" + UName + "' ;", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("ACCEPTED");
                    
                    con.Close();
                    Close();
                    Formdashboard formdashboard = new Formdashboard();
                    formdashboard.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("ENTER RIGHT NAME ");
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("ENTER RIGHT NAME ");
                textBox1.Focus();
            }
            
            
   
        }

        private void buttonreject_Click(object sender, EventArgs e)
        {
            string UName = textBox1.Text;
            int accepeted = 0;
            bool Ain;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G5MCV6\MSSQLSERVERDOHA;Initial Catalog=Attendance_Management_System;Integrated Security=True;MultipleActiveResultSets=true");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select User_Name from Leave_request where User_Name='" + UName + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                Ain = dr1.GetValue(0).ToString() == UName;

                if (Ain)
                {
                    SqlCommand cmd = new SqlCommand("update Leave_request set Accepted = '" + accepeted + "' where User_Name = '" + UName + "' ;", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("REJECTED");
                    
                    con.Close();
                    Close();
                    Formdashboard formdashboard = new Formdashboard();
                    formdashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ENTER RIGHT NAME ");
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("ENTER RIGHT NAME ");
                textBox1.Focus();
            }

        }

        
    }
}
