using LearningSoftware.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSoftware.TestPages
{
    public partial class IntroTestPage : UserControl
    {
        Student currentStudent = new Student();
        bool canSubmit = false;
        public int grade = 0;
        public IntroTestPage(Student student)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            currentStudent= student;
        }

        private void IntroTestPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grade = 0;
            canSubmit = true;
            string ans1 = q1TB.Text.Trim();
            string ans2 = q2TB.Text.Trim();
            string ans3 = q3TB.Text.Trim();
            string ans4 = q4TB.Text.Trim();

            if ((ans1.Length == 1 && ans2.Length == 1 && ans3.Length == 1 && ans4.Length == 1))
            {
                lockTB();
                if (ans1 == "c")
                {
                    asn1LB.Text = "Σωστή απάντηση";
                    asn1LB.ForeColor = Color.Green;
                    grade += 25;
                }
                else
                {
                    asn1LB.Text = "Λάθος απάντηση.Η σωστή απάντηση ειναι το 'c'";
                    asn1LB.ForeColor = Color.Red;

                }

                if (ans2 == "d")
                {
                    asn2LB.Text = "Σωστή απάντηση";
                    asn2LB.ForeColor = Color.Green;
                    grade += 25;
                }
                else
                {
                    asn2LB.Text = "Λάθος απάντηση.Η σωστή απάντηση ειναι το 'd'";
                    asn2LB.ForeColor = Color.Red;

                }

                if (ans3 == "c")
                {
                    asn3LB.Text = "Σωστή απάντηση";
                    asn3LB.ForeColor = Color.Green;
                    grade += 25;
                }
                else
                {
                    asn3LB.Text = "Λάθος απάντηση.Η σωστή απάντηση ειναι το 'c'";
                    asn3LB.ForeColor = Color.Red;

                }

                if (ans4 == "b")
                {
                    asn4LB.Text = "Σωστή απάντηση";
                    asn4LB.ForeColor = Color.Green;
                    grade += 25;
                }
                else
                {
                    asn4LB.Text = "Λάθος απάντηση.Η σωστή απάντηση ειναι το 'b'";
                    asn4LB.ForeColor = Color.Red;

                }

                gradesLB.Text = $"Your grades are: {grade}";
            }
            else
            {
                MessageBox.Show("Watch out your answer formatting \n" +
                    "Your answer must be only ONE LETTER !", "Warning");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Helper.AddTestGrade(currentStudent.S_ID, TestEnum.INTRO, grade);
                MessageBox.Show("Your test has been submited!", "Notification");
                unLockTB();
                clearAll();
            }
            else
            {
                MessageBox.Show("You must Check your answers first!", "Warning");
            }
        }

        private void lockTB()
        {
            q1TB.Enabled = false;
            q2TB.Enabled = false;
            q3TB.Enabled = false;
            q4TB.Enabled = false;
        }

        private void unLockTB()
        {
            q1TB.Enabled = true;
            q2TB.Enabled = true;
            q3TB.Enabled = true;
            q4TB.Enabled = true;
        }

        private void clearAll()
        {
            grade = 0;

            q1TB.Text = "";
            q2TB.Text = "";
            q3TB.Text = "";
            q4TB.Text = "";

            asn1LB.Text = "";
            asn1LB.ForeColor = Color.Black;
            asn2LB.Text = "";
            asn2LB.ForeColor = Color.Black;
            asn3LB.Text = "";
            asn3LB.ForeColor = Color.Black;
            asn4LB.Text = "";
            asn4LB.ForeColor = Color.Black;

            canSubmit = false;

        }
    }
}
