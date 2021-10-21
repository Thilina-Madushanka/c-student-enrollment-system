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
    public partial class FormStudentInfo : Form
    {
        FormStudent form;
        private object dataGridView;

        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }

        public void Display()
        {
            DBStudent.DisplayAndSearch("SELECT ID ,regNum, name, dob, age, gender, contNo, ecourse FROM student_table", dataGridView);

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBStudent.DisplayAndSearch("SELECT ID , regNum, name, dob, age, gender, contNo, ecourse FROM student_table WHERE Name LIKE '%" +  txtSearch.Text +"%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit
               // regNum, name, dob, age, gender, contNo, ecourse

                form.Clear();

                form.id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.regNum = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.dob = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.age = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.gender = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.contNo = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.ecourse = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Delete
               if( MessageBox.Show("Are you want to delete Student Record?","Information",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information) == DialogResult.Yes);
                {
                    DBStudent.DeleteStudents(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
