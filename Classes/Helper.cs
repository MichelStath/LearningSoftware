using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LearningSoftware.Classes
{
    public class Helper
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=LEARNINGDB.db;Version=3;New=True;Compress=True;");
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        public int GetStudentCount(String username)
        {
            //works
            string s = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(s, null).AsList();
            var num = st.Where(x => x.USERNAME.Equals(username)).Count();
            return num;
        }

        public bool LoginStudent(string username, string password)
        {
            //works
            string s = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(s, null).AsList();
            var num = st.Where(x => x.USERNAME.Equals(username) && x.PASSWORD.Equals(password)).Count();
            return num == 1;
        }


        public void RegisterStudent(Student s)
        {
            con.Open();
            if(GetStudentCount(s.USERNAME) < 1)
            {
                sqlite_cmd = null;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO STUDENTS (USERNAME, PASSWORD, F_NAME, S_NAME) VALUES ('{s.USERNAME}', '{s.PASSWORD}', '{s.F_NAME}', '{s.S_NAME}')";
                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Student Registered");

                string query = $"SELECT DISTINCT * FROM STUDENTS";
                List<Student> st = con.Query<Student>(query, null).AsList();
                var sid = st.Where(x => x.USERNAME.Equals(s.USERNAME)).Select(x=> x.S_ID).First();

                //set lesson read to 0 
                sqlite_cmd.CommandText = $"INSERT INTO LESSONVIEW (S_ID, LESSON_1, LESSON_2, LESSON_3, LESSON_4) VALUES ('{sid}', 0, 0, 0, 0)";
                sqlite_cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Already Registered");
            }
            con.Close();
        }

        public Student GetStudent(String username) {
            string query = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(query, null).AsList();
            var sid = st.Where(x => x.USERNAME.Equals(username)).AsList().First();
            return sid;
        }

        public List<Student> GetStudents(string username) {
            string s = $"SELECT DISTINCT * FROM STUDENTS";
            return con.Query<Student>(s, null).AsList();
        }
    }
}
