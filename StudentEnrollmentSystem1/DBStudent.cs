using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentEnrollmentSystem1
{

    
    class DBStudent
    {
        /*public static MySqlConnection GetConnection()
        {
            String sql = "datasource = localhost; port=3306 ; username = root; password=; database= student ";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }*/

                                    //database connection

        public static SqlConnection GetConnection()
        {
            String sql = "datasource = localhost; port=3306 ; username = root; password=; database= student ";
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }





        //add students



        public static void AddStudent(Student std)
        {
            string sql = "Insert INTO student_table VALUES (NULL , @StudentRegNum, @StudentName, @StudentDOB , @StudentAge,@StudentGender,@StudentContNo , @StudentECourse NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@StudentRegNum", MySqlDbType.VarChar).Value = std.RegNum;
            cmd.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@StudentDOB", MySqlDbType.VarChar).Value = std.DOB;
            cmd.Parameters.Add("@StudentAge", MySqlDbType.VarChar).Value = std.Age;
            cmd.Parameters.Add("@StudentGender", MySqlDbType.VarChar).Value = std.Gender;
            cmd.Parameters.Add("@StudentContNo", MySqlDbType.VarChar).Value = std.ContNo;
            cmd.Parameters.Add("@StudentECourse", MySqlDbType.VarChar).Value = std.ECourse;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added sucessfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not insert" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();

        }

        internal static void DisplayAndSearch(string v, object dataGridView)
        {
            throw new NotImplementedException();
        }

        //update students 

       

        public static void updateStudent(Student std, String id)
        {
            string sql = "UPDATE INTO student_table SET RegNum = @StudentRegNum ,Name = @StudentName ,@StudentDOB = DOB, Age = @StudentAge , Gender =  @StudentGender, ContNo = @StudentContNo, ECourse = @StudentECourse WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@StudentRegNum", MySqlDbType.VarChar).Value = std.RegNum;
            cmd.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@StudentDOB", MySqlDbType.VarChar).Value = std.DOB;
            cmd.Parameters.Add("@StudentAge", MySqlDbType.VarChar).Value = std.Age;
            cmd.Parameters.Add("@StudentGender", MySqlDbType.VarChar).Value = std.Gender;
            cmd.Parameters.Add("@StudentContNo", MySqlDbType.VarChar).Value = std.ContNo;
            cmd.Parameters.Add("@StudentECourse", MySqlDbType.VarChar).Value = std.ECourse;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated sucessfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not updated sucessfully!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();

        }


                                //delete students


        public static void DeleteStudents(String id)
        {

            String sql = " DLETE from students_table WHERE ID = @StudentsID";

            string sql = "UPDATE INTO student_table set RegNum = @StudentRegNum ,Name = @StudentName ,@StudentDOB = DOB, Age = @StudentAge , Gender =  @StudentGender, ContNo = @StudentContNo, ECourse = @StudentECourse WHERE ID = StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete sucessfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Student Not Deleted!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }


                                                 //Display Students

        public static void DisplayAndSearch(String query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        

        }
}