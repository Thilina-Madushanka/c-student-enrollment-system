using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnrollmentSystem1
{
    public partial class FormStudent : Form
    { 

        private readonly FormStudentInfo _parent;
        String id, regNum, name, dob, age, gender, contNo, ecourse;
        private bool isCollapsed;

        public FormStudent(FormStudentInfo parent)
        {

            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Update Student";
            btnSave.Text = "Update";

            txtRegNum.Text = regNo;
            txtName.Text = name;
            txtDOB.Text = dob;
            txtAge.Text = age;
            txtGender.Text = gender;
            txtContNo.Text = contNo;
            txtECourse.Text = ecourse;
           

        }

        public void SaveInfo()
        {
            lbltext.Text = "Add Student";
            btnSave.Text = "Save";

        }
        public void Clear()
        {
            txtRegNum.Text = txtName.Text = txtDOB.Text = txtAge.Text = txtGender.Text = txtContNo.Text = txtECourse.Text= String.Empty;

        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {

        }

        //combo

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            if (txtRegNum.Text.Trim().Length < 3)
            {
                MessageBox.Show("students Registration NUmber is empty( > 1 ).");
                return;

            }
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("students Name is empty(>3).");
                return;

            }
            
            if (txtDOB.Text.Trim().Length == 3)
            {
                MessageBox.Show("students Date of Birth is empty( > 1 ).");
                return;
            }

            if (txtAge.Text.Trim().Length < 1)
            {
                MessageBox.Show("students Age is empty( > 1 ).");
                return;
            }
            if (txtContNo.Text.Trim().Length < 3)
            {
                MessageBox.Show("students Contact Number is empty( > 1 ).");
                return;
            }
            if (txtGender.Text.Trim().Length == 0)
            {
                MessageBox.Show("students gender is empty!"); txtRegNum.Text = txtName.Text = txtDOB.Text = txtAge.Text = txtGender.Text = txtContNo.Text = txtECourse.Text
                return;
            }
            if (btnSave.Text == "Save")
            {
                Student std = new Student(txtRegNum.Text.Trim(),txtName.Text.Trim(), , txtDOB.Text.Trim() = txtAge.Text.Trim(), txtGender.Text.Trim(), txtContNo.Text.Trim(), txtECourse.Text.Trim());
                DBStudent.AddStudent(std);
                Clear();
            }
            if(btnSave.Text == "Update")
            {
                Student std = new Student(txtRegNum.Text.Trim(), txtName.Text.Trim(), , txtDOB.Text.Trim() = txtAge.Text.Trim(), txtGender.Text.Trim(), txtContNo.Text.Trim(), txtECourse.Text.Trim());
                DBStudent.updateStudent(std, id);
            }
            _parent.Display();
        }
    }
}