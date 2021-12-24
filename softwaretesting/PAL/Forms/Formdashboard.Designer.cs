namespace softwaretesting.PAL.Forms
{
    partial class Formdashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPresenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendance1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_Management_SystemDataSet = new softwaretesting.Attendance_Management_SystemDataSet();
            this.attendance1TableAdapter = new softwaretesting.Attendance_Management_SystemDataSetTableAdapters.Attendance1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonreject = new System.Windows.Forms.Button();
            this.buttonaccept = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaverequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_Management_SystemDataSet1 = new softwaretesting.Attendance_Management_SystemDataSet1();
            this.leave_requestTableAdapter = new softwaretesting.Attendance_Management_SystemDataSet1TableAdapters.Leave_requestTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelemployeename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaverequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.userDPDataGridViewTextBoxColumn,
            this.userPresenceDataGridViewTextBoxColumn,
            this.tDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendance1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userDPDataGridViewTextBoxColumn
            // 
            this.userDPDataGridViewTextBoxColumn.DataPropertyName = "User_DP";
            this.userDPDataGridViewTextBoxColumn.HeaderText = "User_DP";
            this.userDPDataGridViewTextBoxColumn.Name = "userDPDataGridViewTextBoxColumn";
            // 
            // userPresenceDataGridViewTextBoxColumn
            // 
            this.userPresenceDataGridViewTextBoxColumn.DataPropertyName = "User_Presence";
            this.userPresenceDataGridViewTextBoxColumn.HeaderText = "User_Presence";
            this.userPresenceDataGridViewTextBoxColumn.Name = "userPresenceDataGridViewTextBoxColumn";
            // 
            // tDateDataGridViewTextBoxColumn
            // 
            this.tDateDataGridViewTextBoxColumn.DataPropertyName = "T_Date";
            this.tDateDataGridViewTextBoxColumn.HeaderText = "T_Date";
            this.tDateDataGridViewTextBoxColumn.Name = "tDateDataGridViewTextBoxColumn";
            // 
            // attendance1BindingSource
            // 
            this.attendance1BindingSource.DataMember = "Attendance1";
            this.attendance1BindingSource.DataSource = this.attendance_Management_SystemDataSet;
            // 
            // attendance_Management_SystemDataSet
            // 
            this.attendance_Management_SystemDataSet.DataSetName = "Attendance_Management_SystemDataSet";
            this.attendance_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendance1TableAdapter
            // 
            this.attendance1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance List";
            // 
            // buttonprevious
            // 
            this.buttonprevious.BackColor = System.Drawing.Color.White;
            this.buttonprevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonprevious.FlatAppearance.BorderSize = 0;
            this.buttonprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonprevious.Location = new System.Drawing.Point(12, 4);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(97, 30);
            this.buttonprevious.TabIndex = 12;
            this.buttonprevious.Text = "Previous";
            this.buttonprevious.UseVisualStyleBackColor = false;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::softwaretesting.Properties.Resources.download__7_3;
            this.pictureBox2.Location = new System.Drawing.Point(103, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4minimize
            // 
            this.pictureBox4minimize.BackgroundImage = global::softwaretesting.Properties.Resources.download__5_2;
            this.pictureBox4minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4minimize.Image = global::softwaretesting.Properties.Resources.download__4_;
            this.pictureBox4minimize.Location = new System.Drawing.Point(932, 4);
            this.pictureBox4minimize.Name = "pictureBox4minimize";
            this.pictureBox4minimize.Size = new System.Drawing.Size(30, 33);
            this.pictureBox4minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4minimize.TabIndex = 5;
            this.pictureBox4minimize.TabStop = false;
            this.pictureBox4minimize.Click += new System.EventHandler(this.pictureBox4minimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::softwaretesting.Properties.Resources._880361_exit_512x512;
            this.pictureBox1.Location = new System.Drawing.Point(968, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonreject
            // 
            this.buttonreject.BackColor = System.Drawing.Color.White;
            this.buttonreject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonreject.FlatAppearance.BorderSize = 0;
            this.buttonreject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreject.Location = new System.Drawing.Point(795, 330);
            this.buttonreject.Name = "buttonreject";
            this.buttonreject.Size = new System.Drawing.Size(97, 30);
            this.buttonreject.TabIndex = 13;
            this.buttonreject.Text = "Reject";
            this.buttonreject.UseVisualStyleBackColor = false;
            this.buttonreject.Click += new System.EventHandler(this.buttonreject_Click);
            // 
            // buttonaccept
            // 
            this.buttonaccept.BackColor = System.Drawing.Color.White;
            this.buttonaccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaccept.FlatAppearance.BorderSize = 0;
            this.buttonaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaccept.Location = new System.Drawing.Point(631, 330);
            this.buttonaccept.Name = "buttonaccept";
            this.buttonaccept.Size = new System.Drawing.Size(97, 30);
            this.buttonaccept.TabIndex = 14;
            this.buttonaccept.Text = "Accept";
            this.buttonaccept.UseVisualStyleBackColor = false;
            this.buttonaccept.Click += new System.EventHandler(this.buttonaccept_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn1,
            this.User_Dept,
            this.R_Date,
            this.Reason,
            this.Hours,
            this.Accepted});
            this.dataGridView2.DataSource = this.leaverequestBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(480, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(482, 195);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            // 
            // User_Dept
            // 
            this.User_Dept.DataPropertyName = "User_Dept";
            this.User_Dept.HeaderText = "User_Dept";
            this.User_Dept.Name = "User_Dept";
            this.User_Dept.Width = 60;
            // 
            // R_Date
            // 
            this.R_Date.DataPropertyName = "R_Date";
            this.R_Date.HeaderText = "R_Date";
            this.R_Date.Name = "R_Date";
            this.R_Date.Width = 75;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            this.Hours.Width = 40;
            // 
            // Accepted
            // 
            this.Accepted.DataPropertyName = "Accepted";
            this.Accepted.HeaderText = "Accepted";
            this.Accepted.Name = "Accepted";
            this.Accepted.Width = 60;
            // 
            // leaverequestBindingSource
            // 
            this.leaverequestBindingSource.DataMember = "Leave_request";
            this.leaverequestBindingSource.DataSource = this.attendance_Management_SystemDataSet1;
            // 
            // attendance_Management_SystemDataSet1
            // 
            this.attendance_Management_SystemDataSet1.DataSetName = "Attendance_Management_SystemDataSet1";
            this.attendance_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leave_requestTableAdapter
            // 
            this.leave_requestTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(652, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 16;
            // 
            // labelemployeename
            // 
            this.labelemployeename.AutoSize = true;
            this.labelemployeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemployeename.Location = new System.Drawing.Point(507, 290);
            this.labelemployeename.Name = "labelemployeename";
            this.labelemployeename.Size = new System.Drawing.Size(139, 16);
            this.labelemployeename.TabIndex = 17;
            this.labelemployeename.Text = "Employee’s Name:";
            // 
            // Formdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 382);
            this.Controls.Add(this.labelemployeename);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonaccept);
            this.Controls.Add(this.buttonreject);
            this.Controls.Add(this.buttonprevious);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4minimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formdashboard";
            this.Load += new System.EventHandler(this.Formdashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaverequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Attendance_Management_SystemDataSet attendance_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource attendance1BindingSource;
        private Attendance_Management_SystemDataSetTableAdapters.Attendance1TableAdapter attendance1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPresenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonreject;
        private System.Windows.Forms.Button buttonaccept;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Attendance_Management_SystemDataSet1 attendance_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource leaverequestBindingSource;
        private Attendance_Management_SystemDataSet1TableAdapters.Leave_requestTableAdapter leave_requestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accepted;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelemployeename;
    }
}