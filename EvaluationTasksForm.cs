using LearningSoftware.Classes;
using LearningSoftware.OnlineHelp;
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
            DialogResult dialogResult = MessageBox.Show("Unsubmited test will be lost. \nDo you want to continue ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearMainPanel();
                IntroTestPage introtestPage = new IntroTestPage(currentStudent);
                mainPanel.Controls.Add(introtestPage);
            }
        }

        private void langBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Unsubmited test will be lost. \nDo you want to continue ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearMainPanel();
                LangTestPage langTestPage = new LangTestPage(currentStudent);
                mainPanel.Controls.Add(langTestPage);
            }
        }

        private void skilsBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Unsubmited test will be lost. \nDo you want to continue ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearMainPanel();
                SkillsTestPage skillsTestPage = new SkillsTestPage(currentStudent);
                mainPanel.Controls.Add(skillsTestPage);
            }
        }

        private void jobsBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Unsubmited test will be lost. \nDo you want to continue ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearMainPanel();
                JobsTestPage jobsTestPage = new JobsTestPage(currentStudent);
                mainPanel.Controls.Add(jobsTestPage);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Unsubmited test will be lost. \nDo you want to continue ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearMainPanel();
                TotalTestPage jobsTestPage = new TotalTestPage(currentStudent);
                mainPanel.Controls.Add(jobsTestPage);
            }
        }
        private void clearMainPanel()
        {
            mainPanel.Controls.Clear();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobFinderForm f = new JobFinderForm(currentStudent);
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestHelper c = new TestHelper();
            OnlineHelpForm f = new OnlineHelpForm(c);
            f.ShowDialog();
        }
    }
}
