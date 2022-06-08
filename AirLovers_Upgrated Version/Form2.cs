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
    public partial class Form2 : Form
    {
        List<Student> students = new List<Student>();//student list
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.ShowDialog();
            this.Close();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //this if else statement for error message if user make an input wrong
            if(idtbx.Text.Length !=5)
            {
                MessageBox.Show("Your ID must have 5 characters","Failed to Input", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else if(nametbx.Text == string.Empty)
            //actually we can use else if(nametbx.Text=="") but combination between blue and white looks good thats why i use it:)

            {
                MessageBox.Show("Please Input Your Name", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nametbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Your Name", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lastnametbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Your Last Name", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (emailtbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Your Email", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dobtbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Your Birthday", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dostbx.Text == string.Empty)
            {
                MessageBox.Show("Please Input Your First Date", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Id = idtbx.Text;//define and assign our variable
                string Name = nametbx.Text;
                string Lastname = lastnametbx.Text;
                string Email = emailtbx.Text;
                string DateOfBirth = dobtbx.Text;
                string DateofStart = dostbx.Text;

                Student student = new Student();
                student.Id = Id;
                student.Name = Name;
                student.Lastname = Lastname;
                student.Email = Email;
                student.DateOfBirth = DateOfBirth;
                student.DateOfStart = DateofStart;

                students.Add(student);

                myData.students.Add(student);

                MessageBox.Show("New Student Added");//if all data is correct and this is for succes message

                idtbx.Clear();//for Clear all text was input user
                nametbx.Clear();
                lastnametbx.Clear();
                emailtbx.Clear();
                dobtbx.Clear();
                dostbx.Clear();
            }
        }

        private void idtbx_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
