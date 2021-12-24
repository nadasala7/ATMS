namespace softwaretesting.PAL.Forms
{
    partial class Formforgetpassword
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
            this.buttonverify = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxminimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxerror = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxerror)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxerror);
            this.panel1.Controls.Add(this.buttonverify);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxminimize);
            this.panel1.Controls.Add(this.pictureBoxclose);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 290);
            this.panel1.TabIndex = 0;
            // 
            // buttonverify
            // 
            this.buttonverify.BackColor = System.Drawing.Color.Blue;
            this.buttonverify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonverify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonverify.ForeColor = System.Drawing.Color.White;
            this.buttonverify.Location = new System.Drawing.Point(174, 217);
            this.buttonverify.Name = "buttonverify";
            this.buttonverify.Size = new System.Drawing.Size(104, 39);
            this.buttonverify.TabIndex = 7;
            this.buttonverify.Text = "Verify";
            this.buttonverify.UseVisualStyleBackColor = false;
            this.buttonverify.Click += new System.EventHandler(this.buttonverify_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(62, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 2);
            this.panel2.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(62, 152);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 13);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Text = "Example@Example.Ex";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(117, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forget Password?";
            // 
            // pictureBoxminimize
            // 
            this.pictureBoxminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxminimize.Image = global::softwaretesting.Properties.Resources.download__1_;
            this.pictureBoxminimize.Location = new System.Drawing.Point(390, 3);
            this.pictureBoxminimize.Name = "pictureBoxminimize";
            this.pictureBoxminimize.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxminimize.TabIndex = 2;
            this.pictureBoxminimize.TabStop = false;
            this.pictureBoxminimize.Click += new System.EventHandler(this.pictureBoxminimize_Click);
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxclose.Image = global::softwaretesting.Properties.Resources.images;
            this.pictureBoxclose.Location = new System.Drawing.Point(428, 3);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclose.TabIndex = 1;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            this.pictureBoxclose.MouseHover += new System.EventHandler(this.pictureBoxclose_MouseHover);
            // 
            // pictureBoxerror
            // 
            this.pictureBoxerror.Image = global::softwaretesting.Properties.Resources.download__3_;
            this.pictureBoxerror.Location = new System.Drawing.Point(392, 152);
            this.pictureBoxerror.Name = "pictureBoxerror";
            this.pictureBoxerror.Size = new System.Drawing.Size(29, 19);
            this.pictureBoxerror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxerror.TabIndex = 8;
            this.pictureBoxerror.TabStop = false;
            this.pictureBoxerror.MouseHover += new System.EventHandler(this.pictureBoxerror_MouseHover);
            // 
            // Formforgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 317);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formforgetpassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxerror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.PictureBox pictureBoxminimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonverify;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxerror;
    }
}