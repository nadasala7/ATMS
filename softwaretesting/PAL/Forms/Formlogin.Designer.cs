namespace softwaretesting.PAL.Forms
{
    partial class Formlogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFP = new System.Windows.Forms.Label();
            this.pictureBoxshow = new System.Windows.Forms.PictureBox();
            this.pictureBoxhide = new System.Windows.Forms.PictureBox();
            this.pictureBoxerror = new System.Windows.Forms.PictureBox();
            this.labelerror = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxminimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFP);
            this.groupBox1.Controls.Add(this.pictureBoxshow);
            this.groupBox1.Controls.Add(this.pictureBoxhide);
            this.groupBox1.Controls.Add(this.pictureBoxerror);
            this.groupBox1.Controls.Add(this.labelerror);
            this.groupBox1.Controls.Add(this.buttonlogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(581, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login First";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFP.ForeColor = System.Drawing.Color.Blue;
            this.labelFP.Location = new System.Drawing.Point(175, 295);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(119, 16);
            this.labelFP.TabIndex = 9;
            this.labelFP.Text = "Forget Password?";
            this.labelFP.Click += new System.EventHandler(this.labelFP_Click);
            // 
            // pictureBoxshow
            // 
            this.pictureBoxshow.Image = global::softwaretesting.Properties.Resources.download__5_;
            this.pictureBoxshow.Location = new System.Drawing.Point(352, 187);
            this.pictureBoxshow.Name = "pictureBoxshow";
            this.pictureBoxshow.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxshow.TabIndex = 8;
            this.pictureBoxshow.TabStop = false;
            this.pictureBoxshow.Click += new System.EventHandler(this.pictureBoxshow_Click);
            this.pictureBoxshow.MouseHover += new System.EventHandler(this.pictureBoxshow_MouseHover);
            // 
            // pictureBoxhide
            // 
            this.pictureBoxhide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxhide.Image = global::softwaretesting.Properties.Resources.download__2_;
            this.pictureBoxhide.Location = new System.Drawing.Point(352, 187);
            this.pictureBoxhide.Name = "pictureBoxhide";
            this.pictureBoxhide.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxhide.TabIndex = 7;
            this.pictureBoxhide.TabStop = false;
            this.pictureBoxhide.Click += new System.EventHandler(this.pictureBoxhide_Click);
            this.pictureBoxhide.MouseHover += new System.EventHandler(this.pictureBoxhide_MouseHover);
            // 
            // pictureBoxerror
            // 
            this.pictureBoxerror.Image = global::softwaretesting.Properties.Resources.download__3_;
            this.pictureBoxerror.Location = new System.Drawing.Point(98, 247);
            this.pictureBoxerror.Name = "pictureBoxerror";
            this.pictureBoxerror.Size = new System.Drawing.Size(29, 19);
            this.pictureBoxerror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxerror.TabIndex = 6;
            this.pictureBoxerror.TabStop = false;
            this.pictureBoxerror.Visible = false;
            this.pictureBoxerror.Click += new System.EventHandler(this.pictureBoxerror_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(133, 247);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(241, 19);
            this.labelerror.TabIndex = 5;
            this.labelerror.Text = "Invalid Username Or Password";
            this.labelerror.Visible = false;
            this.labelerror.Click += new System.EventHandler(this.labelerror_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Blue;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(178, 325);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(104, 39);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "Log In";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(68, 187);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(278, 27);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyUp);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(68, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(306, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(534, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 446);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::softwaretesting.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(40, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxminimize
            // 
            this.pictureBoxminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxminimize.Image = global::softwaretesting.Properties.Resources.download__1_;
            this.pictureBoxminimize.Location = new System.Drawing.Point(1018, 3);
            this.pictureBoxminimize.Name = "pictureBoxminimize";
            this.pictureBoxminimize.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxminimize.TabIndex = 1;
            this.pictureBoxminimize.TabStop = false;
            this.pictureBoxminimize.Click += new System.EventHandler(this.pictureBoxminimize_Click);
            this.pictureBoxminimize.MouseHover += new System.EventHandler(this.pictureBoxminimize_MouseHover);
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxclose.Image = global::softwaretesting.Properties.Resources.images;
            this.pictureBoxclose.Location = new System.Drawing.Point(1049, 3);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclose.TabIndex = 0;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            this.pictureBoxclose.MouseHover += new System.EventHandler(this.pictureBoxclose_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(61, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attendance Managment System";
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxminimize);
            this.Controls.Add(this.pictureBoxclose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.PictureBox pictureBoxminimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxshow;
        private System.Windows.Forms.PictureBox pictureBoxhide;
        private System.Windows.Forms.PictureBox pictureBoxerror;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}