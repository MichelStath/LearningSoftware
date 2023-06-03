using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSoftware.Classes
{
    public class Helper
    {
        private static string DBPath = Application.StartupPath + "\\lsDB.mdb";
        private OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath + "; Persist Security Info = True");

        public void saveStudentToDB(Student s)
        {
            con.Open();


            con.Close();
        }

        public int getStudentCount(String username)
        { 
            con.Open();



            con.Close();
            return 0;
        }

        public Student getStudentFromDB(string username, string password) {
            con.Open();
            MessageBox.Show("Connected to DB successfully");



            con.Close();
            return new Student(null,null,null,null);
        }
    }
}
