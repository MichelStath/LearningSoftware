using LearningSoftware.Classes;
using LearningSoftware.TestPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LearningSoftware
{
    public partial class EvaluationTasksForm : Form
    {

        TestEnum currentTest = new TestEnum();
        Student currentStudent = new Student();

        public EvaluationTasksForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void introBTN_Click(object sender, EventArgs e)
        {
            clearMainPanel();
            currentTest = TestEnum.INTRO;
            IntroTestPage introtestPage = new IntroTestPage(currentStudent);
            mainPanel.Controls.Add(introtestPage);
        }

        private void langBTN_Click(object sender, EventArgs e)
        {
            clearMainPanel();
            currentTest = TestEnum.LANG;
        }

        private void skilsBTN_Click(object sender, EventArgs e)
        {
            clearMainPanel();

            currentTest = TestEnum.SKILLS;
        }

        private void jobsBTN_Click(object sender, EventArgs e)
        {
            clearMainPanel();

            currentTest = TestEnum.JOBS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearMainPanel();

            currentTest = TestEnum.TOTAL;
        }
        private void clearMainPanel()
        {
            mainPanel.Controls.Clear();
            this.Refresh();
        }
    }
}
