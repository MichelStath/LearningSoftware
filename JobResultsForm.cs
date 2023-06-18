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

namespace LearningSoftware
{
    public partial class JobResultsForm : Form
    {
        private Student currentStudent = new Student();
        private List<JobsClass> currentJobs = new List<JobsClass>();
        private JobsClass currentJob = new JobsClass();
        public JobResultsForm(List<JobsClass> jobs, Student s)
        {
            InitializeComponent();
            currentStudent = s;
            currentJobs = jobs;
            currentJob = currentJobs.OrderByDescending(x => x.JOB_SCORE).First();


        }

        private void JobResultsForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.ai;

            switch (currentJob.JOB_NAME)
            {
                case "SOFTWARE":
                    this.BackgroundImage = Properties.Resources.software;
                    break;
                case "NETWORK":
                    this.BackgroundImage = Properties.Resources.network;
                    break;
                case "UI":
                    this.BackgroundImage = Properties.Resources.UI;
                    break;
                case "AI":
                    this.BackgroundImage = Properties.Resources.ai;
                    break;
                case "TEACHER":
                    this.BackgroundImage = Properties.Resources.teacher;
                    break;
                default:
                    break;
            }

        }
    }
}
