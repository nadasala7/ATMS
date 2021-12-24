namespace softwaretesting.PAL.Forms
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltimer = new System.Windows.Forms.Label();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.pictureBox4minimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonattendance = new System.Windows.Forms.Button();
            this.buttondashboard = new System.Windows.Forms.Button();
            this.labelrole = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerdateandtime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.masterDataSet1 = new softwaretesting.masterDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4minimize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.labeltimer);
            this.panel1.Controls.Add(this.buttonlogout);
            this.panel1.Controls.Add(this.pictureBox4minimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(200, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 149);
            this.panel1.TabIndex = 0;
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimer.ForeColor = System.Drawing.Color.White;
            this.labeltimer.Location = new System.Drawing.Point(47, 22);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(0, 18);
            this.labeltimer.TabIndex = 3;
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.White;
            this.buttonlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogout.FlatAppearance.BorderSize = 0;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonlogout.Location = new System.Drawing.Point(719, 108);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(84, 30);
            this.buttonlogout.TabIndex = 2;
            this.buttonlogout.Text = "Log Out";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // pictureBox4minimize
            // 
            this.pictureBox4minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4minimize.Image = global::softwaretesting.Properties.Resources.download__9_1;
            this.pictureBox4minimize.Location = new System.Drawing.Point(787, 3);
            this.pictureBox4minimize.Name = "pictureBox4minimize";
            this.pictureBox4minimize.Size = new System.Drawing.Size(30, 33);
            this.pictureBox4minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4minimize.TabIndex = 1;
            this.pictureBox4minimize.TabStop = false;
            this.pictureBox4minimize.Click += new System.EventHandler(this.pictureBox4minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.buttonattendance);
            this.panel2.Controls.Add(this.buttondashboard);
            this.panel2.Controls.Add(this.labelrole);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelusername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 559);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::softwaretesting.Properties.Resources.download__7_2;
            this.pictureBox3.Location = new System.Drawing.Point(25, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(11, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Leaving Requests";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::softwaretesting.Properties.Resources.download__8_1;
            this.pictureBox2.Location = new System.Drawing.Point(27, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonattendance
            // 
            this.buttonattendance.BackColor = System.Drawing.Color.White;
            this.buttonattendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonattendance.FlatAppearance.BorderSize = 0;
            this.buttonattendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonattendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonattendance.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonattendance.Location = new System.Drawing.Point(11, 383);
            this.buttonattendance.Name = "buttonattendance";
            this.buttonattendance.Size = new System.Drawing.Size(189, 59);
            this.buttonattendance.TabIndex = 8;
            this.buttonattendance.Text = "Attendance";
            this.buttonattendance.UseVisualStyleBackColor = false;
            this.buttonattendance.Click += new System.EventHandler(this.buttonattendance_Click);
            // 
            // buttondashboard
            // 
            this.buttondashboard.BackColor = System.Drawing.Color.White;
            this.buttondashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondashboard.FlatAppearance.BorderSize = 0;
            this.buttondashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondashboard.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttondashboard.Location = new System.Drawing.Point(11, 308);
            this.buttondashboard.Name = "buttondashboard";
            this.buttondashboard.Size = new System.Drawing.Size(189, 54);
            this.buttondashboard.TabIndex = 7;
            this.buttondashboard.Text = "Dashboard";
            this.buttondashboard.UseVisualStyleBackColor = false;
            this.buttondashboard.Click += new System.EventHandler(this.buttondashboard_Click);
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.ForeColor = System.Drawing.Color.White;
            this.labelrole.Location = new System.Drawing.Point(80, 233);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(31, 20);
            this.labelrole.TabIndex = 6;
            this.labelrole.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role:";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(115, 191);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(31, 20);
            this.labelusername.TabIndex = 3;
            this.labelusername.Text = "{?}";
            this.labelusername.Click += new System.EventHandler(this.labelusername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wellcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::softwaretesting.Properties.Resources._____2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerdateandtime
            // 
            this.timerdateandtime.Tick += new System.EventHandler(this.timerdateandtime_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::softwaretesting.Properties.Resources.images__5_;
            this.pictureBox4.Location = new System.Drawing.Point(216, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(812, 404);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Management System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4minimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4minimize;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonattendance;
        private System.Windows.Forms.Button buttondashboard;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerdateandtime;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private masterDataSet masterDataSet1;
    }
}