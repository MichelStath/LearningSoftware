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

namespace LearningSoftware.Classes
{
    public class Helper
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=LEARNINGDB.db;Version=3;New=True;Compress=True;");
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;
        private int studentCount;
        private int counter = 0;

        public int GetStudentCount(String username)
        {
            //SELECT count(S_ID) FROM STUDENTS WHERE USERNAME = 'ASD'
            sqlite_cmd = con.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT count(S_ID) FROM STUDENTS WHERE USERNAME = '{username}'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                studentCount = sqlite_datareader.GetInt32(0);
            }
            sqlite_datareader.Close();
            
            return studentCount;
        }

        public bool LoginStudent(string username, string password)
        {
            con.Open();
            if (GetStudentCount(username) > 0)
            {
                //do login
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"SELECT count(S_ID) FROM STUDENTS WHERE USERNAME = '{username}' AND PASSWORD = '{password}'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    counter = sqlite_datareader.GetInt32(0);
                }
                sqlite_datareader.Close();

                if (counter > 0) { 
                    con.Close();
                    return true; 
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    con.Close();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Not Registered");
                con.Close();
                return false;
            }
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

                sqlite_cmd.CommandText = $"SELECT DISTINCT S_ID FROM STUDENTS WHERE USERNAME = '{s.USERNAME}'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    s.S_ID = sqlite_datareader.GetInt32(0);
                }
                sqlite_datareader.Close();
                //set lesson read to 0 
                sqlite_cmd.CommandText = $"INSERT INTO LESSONVIEW (S_ID, LESSON_1, LESSON_2, LESSON_3, LESSON_4) VALUES ('{s.S_ID}', 0, 0, 0, 0)";
                sqlite_cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Already Registered");
            }
            con.Close();
        }

        public Student GetStudent(String username) {
            con.Open();
            Student s = new Student();
            sqlite_cmd = con.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT DISTINCT * FROM STUDENTS WHERE USERNAME = '{username}'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                s.S_ID = sqlite_datareader.GetInt32(0);
                s.USERNAME= sqlite_datareader.GetString(1);
                s.PASSWORD= sqlite_datareader.GetString(2);
                s.F_NAME= sqlite_datareader.GetString(3);
                s.S_NAME= sqlite_datareader.GetString(4);
            }
            sqlite_datareader.Close();
            con.Close();
            return s;
        }
    }
}
