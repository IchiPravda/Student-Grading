namespace AirLovers_Upgrated_Version
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finalexamtbx = new System.Windows.Forms.TextBox();
            this.project4tbx = new System.Windows.Forms.TextBox();
            this.project3tbx = new System.Windows.Forms.TextBox();
            this.project2tbx = new System.Windows.Forms.TextBox();
            this.project1tbx = new System.Windows.Forms.TextBox();
            this.attendancetbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusfinal = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.rangepoint = new System.Windows.Forms.Label();
            this.mutlak = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(465, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grading";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student List ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 356);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.finalexamtbx);
            this.groupBox2.Controls.Add(this.project4tbx);
            this.groupBox2.Controls.Add(this.project3tbx);
            this.groupBox2.Controls.Add(this.project2tbx);
            this.groupBox2.Controls.Add(this.project1tbx);
            this.groupBox2.Controls.Add(this.attendancetbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(380, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 385);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(232, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Grade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalexamtbx
            // 
            this.finalexamtbx.Location = new System.Drawing.Point(232, 277);
            this.finalexamtbx.Name = "finalexamtbx";
            this.finalexamtbx.Size = new System.Drawing.Size(149, 22);
            this.finalexamtbx.TabIndex = 11;
            // 
            // project4tbx
            // 
            this.project4tbx.Location = new System.Drawing.Point(232, 223);
            this.project4tbx.Name = "project4tbx";
            this.project4tbx.Size = new System.Drawing.Size(149, 22);
            this.project4tbx.TabIndex = 10;
            this.project4tbx.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // project3tbx
            // 
            this.project3tbx.Location = new System.Drawing.Point(232, 174);
            this.project3tbx.Name = "project3tbx";
            this.project3tbx.Size = new System.Drawing.Size(149, 22);
            this.project3tbx.TabIndex = 9;
            // 
            // project2tbx
            // 
            this.project2tbx.Location = new System.Drawing.Point(232, 126);
            this.project2tbx.Name = "project2tbx";
            this.project2tbx.Size = new System.Drawing.Size(149, 22);
            this.project2tbx.TabIndex = 8;
            // 
            // project1tbx
            // 
            this.project1tbx.Location = new System.Drawing.Point(232, 81);
            this.project1tbx.Name = "project1tbx";
            this.project1tbx.Size = new System.Drawing.Size(149, 22);
            this.project1tbx.TabIndex = 7;
            // 
            // attendancetbx
            // 
            this.attendancetbx.Location = new System.Drawing.Point(232, 39);
            this.attendancetbx.Name = "attendancetbx";
            this.attendancetbx.Size = new System.Drawing.Size(149, 22);
            this.attendancetbx.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Finale Exam (out of 100)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Project 4 (out of 40)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Project 3 (out of 20)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Project 2 (out of 20)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Project 1 (out of 20)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attendance(out of 20)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusfinal);
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Controls.Add(this.rangepoint);
            this.groupBox3.Controls.Add(this.mutlak);
            this.groupBox3.Location = new System.Drawing.Point(808, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // statusfinal
            // 
            this.statusfinal.AutoSize = true;
            this.statusfinal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusfinal.Location = new System.Drawing.Point(141, 149);
            this.statusfinal.Name = "statusfinal";
            this.statusfinal.Size = new System.Drawing.Size(46, 26);
            this.statusfinal.TabIndex = 3;
            this.statusfinal.Text = "N/A";
            this.statusfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(61, 149);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(83, 26);
            this.status.TabIndex = 2;
            this.status.Text = "Status :";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rangepoint
            // 
            this.rangepoint.AutoSize = true;
            this.rangepoint.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangepoint.Location = new System.Drawing.Point(61, 119);
            this.rangepoint.Name = "rangepoint";
            this.rangepoint.Size = new System.Drawing.Size(51, 28);
            this.rangepoint.TabIndex = 1;
            this.rangepoint.Text = "N/A";
            this.rangepoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mutlak
            // 
            this.mutlak.AutoSize = true;
            this.mutlak.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutlak.Location = new System.Drawing.Point(58, 76);
            this.mutlak.Name = "mutlak";
            this.mutlak.Size = new System.Drawing.Size(74, 42);
            this.mutlak.TabIndex = 0;
            this.mutlak.Text = "N/A";
            this.mutlak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(808, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back To Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1089, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox finalexamtbx;
        private System.Windows.Forms.TextBox project4tbx;
        private System.Windows.Forms.TextBox project3tbx;
        private System.Windows.Forms.TextBox project2tbx;
        private System.Windows.Forms.TextBox project1tbx;
        private System.Windows.Forms.TextBox attendancetbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label mutlak;
        private System.Windows.Forms.Label statusfinal;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label rangepoint;
    }
}