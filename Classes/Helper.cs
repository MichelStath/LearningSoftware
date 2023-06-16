using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
        static SQLiteConnection con = new SQLiteConnection("Data Source=LEARNINGDB.db;Version=3;New=True;Compress=True;");
        static SQLiteCommand sqlite_cmd;

        public static int GetStudentCount(String username)
        {
            //works
            string s = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(s, null).AsList();
            var num = st.Where(x => x.USERNAME.Equals(username)).Count();
            return num;
        }

        public static bool LoginStudent(string username, string password)
        {
            //works
            string s = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(s, null).AsList();
            var num = st.Where(x => x.USERNAME.Equals(username) && x.PASSWORD.Equals(password)).Count();
            return num == 1;
        }


        public static void RegisterStudent(Student s)
        {
            con.Open();
            if(GetStudentCount(s.USERNAME) < 1)
            {
                string insertQuery = @"INSERT INTO [STUDENTS]([USERNAME], [PASSWORD], [F_NAME], [S_NAME]) VALUES (@USERNAME, @PASSWORD, @F_NAME, @S_NAME)";
                var result = con.Execute(insertQuery, s);
                MessageBox.Show("Student Registered");

                string query = $"SELECT DISTINCT * FROM STUDENTS";
                List<Student> st = con.Query<Student>(query, null).AsList();
                var sid = st.Where(x => x.USERNAME.Equals(s.USERNAME)).Select(x=> x.S_ID).First();

                //set lesson read to 0 
                insertQuery = @"INSERT INTO [LESSONVIEW]([S_ID], [LESSON_1], [LESSON_2], [LESSON_3], [LESSON_4]) VALUES (@S_ID, @LESSON_1, @LESSON_2, @LESSON_3, @LESSON_4)";
                LessonView lv = new LessonView(sid, 0, 0, 0, 0);
                var result2 = con.Execute(insertQuery, lv);
            }
            else
            {
                MessageBox.Show("Already Registered");
            }
            con.Close();
        }

        public static Student GetStudent(String username) {
            //works
            string query = $"SELECT DISTINCT * FROM STUDENTS";
            List<Student> st = con.Query<Student>(query, null).AsList();
            var sid = st.Where(x => x.USERNAME.Equals(username)).AsList().First();
            return sid;
        }
        public static LessonView GetLessonView(int SID)
        {
            //works
            string query = $"SELECT DISTINCT * FROM LESSONVIEW";
            List<LessonView> st = con.Query<LessonView>(query, null).AsList();
            var sid = st.Where(x => x.S_ID.Equals(SID)).AsList().First();
            return sid;
        }

        public static void updateLessonView(LessonView lv)
        {
            string sql = "update [LESSONVIEW] set LESSON_1 = @LESSON_1, LESSON_2 = @LESSON_2, LESSON_3 = @LESSON_3, LESSON_4 = @LESSON_4  WHERE S_ID = @S_ID";
            var results = con.Execute(sql, lv);
        }

    }
}
