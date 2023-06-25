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
        private string link;
        private string link2;
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
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ Software Developer";
                    link = "https://www.computerscience.org/careers/software-developer/#:~:text=Software%20developers%20write%20code%20using,updates%2C%20and%20upgrades%20as%20needed.";
                    link2 = "https://www.masterstudies.gr/master/%CF%84%CE%B5%CF%87%CE%BD%CE%BF%CE%BB%CE%BF%CE%B3%CE%AF%CE%B1-%CE%BB%CE%BF%CE%B3%CE%B9%CF%83%CE%BC%CE%B9%CE%BA%CE%BF%CF%8D";
                    break;
                case "NETWORK":
                    this.BackgroundImage = Properties.Resources.network;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ Network Designer";
                    link = "https://resources.workable.com/network-engineer-job-description#:~:text=A%20Network%20Engineer%20is%20a,with%20others%20to%20resolve%20issues.";
                    link2 = "https://www.masterstudies.gr/master/%CE%B4%CE%AF%CE%BA%CF%84%CF%85%CE%B1-%CF%85%CF%80%CE%BF%CE%BB%CE%BF%CE%B3%CE%B9%CF%83%CF%84%CF%8E%CE%BD";
                    break;
                case "UI":
                    this.BackgroundImage = Properties.Resources.UI;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ UX-UI dESIGNER";
                    link = "https://resources.workable.com/ui-designer-job-description#:~:text=A%20User%20Interface%20(UI)%20Designer,ensure%20a%20seamless%20user%20experience.";
                    link2 = "https://www.onlinestudies.gr/masters/%CF%88%CE%B7%CF%86%CE%B9%CE%B1%CE%BA%CE%AD%CF%82-%CF%84%CE%AD%CF%87%CE%BD%CE%B5%CF%82";
                    break;
                case "AI":
                    this.BackgroundImage = Properties.Resources.ai;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ AI Developer";
                    link = "https://blog.lewagon.com/career/tech-jobs-data-science-ai-developer/";
                    link2 = "https://www.masterstudies.gr/master/%CF%84%CE%B5%CF%87%CE%BD%CE%B7%CF%84%CE%AE-%CE%BD%CE%BF%CE%B7%CE%BC%CE%BF%CF%83%CF%8D%CE%BD%CE%B7";
                    break;
                case "TEACHER":
                    this.BackgroundImage = Properties.Resources.teacher;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ ΚΑΘΗΓΗΤΗ ΠΛΗΡΟΦΟΡΙΚΗΣ";
                    link = "https://www.mightyrecruiter.com/job-descriptions/computer-science-teacher/#:~:text=Computer%20science%20teachers%20instruct%20students,of%20different%20data%20management%20applications.";
                    label3.Visible = false;
                    button2.Visible = false;
                    break;
                default:
                    label1.Text = "";
                    button1.Visible=false;
                    button2.Visible = false;

                    MessageBox.Show("Something gone wrong", "ERROR");
                    this.Close();
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser f = new WebBrowser(link);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser f = new WebBrowser(link2);
            f.ShowDialog();
        }
    }
}
