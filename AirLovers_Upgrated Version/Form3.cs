using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLovers_Upgrated_Version
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender,  EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                attendancetbx.Enabled = false;
                project1tbx.Enabled = false;
                project2tbx.Enabled = false;
                project3tbx.Enabled = false;
                project4tbx.Enabled = false;
                finalexamtbx.Enabled = false;
            }
            //load user data INput
            Student StudentMethod = new Student();
            List<Student> list = StudentMethod.GetAddstudents();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i].Id + ":" + list[i].Name +""+ list[i].Lastname); 
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //same with before. this if else statement is for error Message or warning message if our user input the wrong data
            if(attendancetbx.Text==string.Empty )
            {
                MessageBox.Show("Please Input Attendance Mark","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(attendancetbx.Text) >20)
            {
                MessageBox.Show("Maximum Point for attendance is 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(project1tbx.Text==string.Empty)
            {
                MessageBox.Show("Please Input Project 1 Mark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(project1tbx.Text) > 20)
            {
                MessageBox.Show("Maximum Point for Project 1 is 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (project2tbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Project 2 Mark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(project2tbx.Text) > 20)
            {
                MessageBox.Show("Maximum Point for Project 2 is 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (project3tbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Project 3 Mark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(project3tbx.Text) > 20)
            {
                MessageBox.Show("Maximum Point for Project 3 is 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(project4tbx.Text) > 40)
            {
                MessageBox.Show("Maximum Point for Project 4 is 40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (project4tbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Project 4 Mark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (finalexamtbx.Text == string.Empty)
            {
                MessageBox.Show("Maximum Point for Project 1 is 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(finalexamtbx.Text) > 100)
            {
                MessageBox.Show("Maximum Point for Final Exam is 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Grade nm=new Grade();
                nm.attendance=Convert.ToDouble(attendancetbx.Text);
                nm.project1=Convert.ToDouble(project1tbx.Text);
                nm.project2=Convert.ToDouble(project2tbx.Text);
                nm.project3=Convert.ToDouble(project3tbx.Text);
                nm.project4=Convert.ToDouble(project4tbx.Text);
                nm.finalexam=Convert.ToDouble(finalexamtbx.Text);
                double akhir = nm.FinalExam2();
                double akhir1 = Math.Round(akhir * 2, MidpointRounding.AwayFromZero) / 2;
                //because in actual grading in vistula our teacher always Round our grade like example
                //my grade is 3.2 so they round my grade to 3 thats why i make this Math.Round to Round The Grade
               

                attendancetbx.Clear();//for clear all text
                project1tbx.Clear();
                project2tbx.Clear();
                project3tbx.Clear();
                project4tbx.Clear();
                finalexamtbx.Clear();
                mutlak.Text = akhir1 + "";
                double nl1 = nm.FinalExam3();
                rangepoint.Text = nl1 + "/100";
                if (nm.FinalExam3() >= 60)
                {
                    mutlak.ForeColor = Color.Black;
                    statusfinal.Text = "Pass";
                    statusfinal.ForeColor = Color.Green;
                    rangepoint.ForeColor = Color.Green;
                }
                else
                {
                    mutlak.Text = "NHK";
                    mutlak.ForeColor = Color.Red;
                    statusfinal.Text = "Failed";
                    statusfinal.ForeColor = Color.Red;//to change color
                    rangepoint.ForeColor = Color.Red;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendancetbx.Clear();
            project1tbx.Clear();
            project2tbx.Clear();
            project3tbx.Clear();
            project4tbx.Clear();
            finalexamtbx.Clear();
            mutlak.Text = "N/A";
            mutlak.ForeColor=Color.Black;
            rangepoint.Text = "N/A";
            statusfinal.ForeColor=Color.Black;
            statusfinal.Text = "N/A";
            rangepoint.ForeColor=Color.Black;
        }
    }
}
