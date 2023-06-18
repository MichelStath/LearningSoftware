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
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ \nSoftware Developer";
                    link = "";
                    link2 = "";
                    break;
                case "NETWORK":
                    this.BackgroundImage = Properties.Resources.network;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ \nNetwork Designer";
                    link = "";
                    link2 = "";
                    break;
                case "UI":
                    this.BackgroundImage = Properties.Resources.UI;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ \nUX-UI dESIGNER";
                    link = "";
                    link2 = "";
                    break;
                case "AI":
                    this.BackgroundImage = Properties.Resources.ai;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ \nAI Developer";
                    link = "";
                    link2 = "";
                    break;
                case "TEACHER":
                    this.BackgroundImage = Properties.Resources.teacher;
                    label1.Text = "η ΔΟΥΛΕΙΑ ΠΟΥ ΣΕ ΕΝΔΙΑΦΕΡΕΙ ΕΙΝΑΙ ΑΥΤΗ ΤΟΥ \nΚΑΘΗΓΗΤΗ ΠΛΗΡΟΦΟΡΙΚΗΣ";
                    link = "";
                    link2 = "";
                    break;
                default:
                    label1.Text = "";
                    button1.Enabled=false;
                    button2.Enabled = false;
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
