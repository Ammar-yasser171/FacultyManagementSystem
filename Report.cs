using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Report : UserControl
    {
        private readonly string connectionString = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable1();
            dataGridView2.DataSource = LoadUserTable2();
            dataGridView3.DataSource = LoadUserTable3();
            dataGridView4.DataSource = LoadUserTable4();
        }
        private DataTable LoadUserTable1()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                string query = "SELECT course.course_name, COUNT(stud_courses.stud_id) AS student_number " +
                               "FROM course " +
                               "LEFT JOIN stud_courses ON course.course_code = stud_courses.course_code " +
                               "GROUP BY course.course_name " +
                               "ORDER BY student_number";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }
        private DataTable LoadUserTable2()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                string query = "select departement.depart_name ,  COUNT(student.stud_id)As student_number " +
                    "from departement,student where departement.depart_code = student.depart_code " +
                    "group by departement.depart_name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                }
                return dt;
            }
        }
        private DataTable LoadUserTable3()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                con.Open();
                string q = "select stud_courses.stud_id,stud_courses.course_code,stud_courses.grade,student.major" +
                    ",student.depart_code " +
                    "from stud_courses join student on stud_courses.stud_id = student.stud_id ";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                sda.Fill(dt);
                return dt;
            }
        }
        private DataTable LoadUserTable4()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                con.Open();
                string q = "select stud_courses.course_code,  MAX(stud_courses.grade) as max_grade from stud_courses group by stud_courses.course_code";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
