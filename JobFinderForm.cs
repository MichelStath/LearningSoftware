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
    public partial class JobFinderForm : Form
    {
        private int softwareDeveloper_counter = 0;
        private int network_counter = 0;
        private int UI_UX_counter = 0;
        private int AI_counter = 0;
        private int Teacher_counter = 0;
        private List<NumericUpDown> softwareDeveloper_NUP_LIST;
        private List<NumericUpDown> network_NUP_LIST;
        private List<NumericUpDown> UI_UX_NUP_LIST;
        private List<NumericUpDown> AI_NUP_LIST;
        private List<NumericUpDown> Teacher_NUP_LIST;
        private Student currentStudent = new Student();
        private JobsClass SOFWARE_JOB;
        private JobsClass NETWORK_JOB;
        private JobsClass UI_JOB;
        private JobsClass AI_JOB;
        private JobsClass TEACHER_JOB;
        private List<JobsClass> jobList = new List<JobsClass>();
        public JobFinderForm(Student s)
        {
            InitializeComponent();
            currentStudent = s;
            LoadLists();

        }

        private void JobFinderForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            jobList.Clear();
            ClearCounters();
            setCountersValues();
            SOFWARE_JOB = new JobsClass("SOFTWARE", softwareDeveloper_counter);
            NETWORK_JOB = new JobsClass("NETWORK", network_counter);
            UI_JOB = new JobsClass("UI", UI_UX_counter);
            AI_JOB = new JobsClass("AI", AI_counter);
            TEACHER_JOB = new JobsClass("TEACHER", Teacher_counter);
            jobList.Add(SOFWARE_JOB);
            jobList.Add(NETWORK_JOB);
            jobList.Add(UI_JOB);
            jobList.Add(AI_JOB);
            jobList.Add(TEACHER_JOB);
            JobResultsForm f = new JobResultsForm(jobList, currentStudent);
            f.ShowDialog();

        }

        private void setCountersValues()
        {
            foreach (NumericUpDown n in softwareDeveloper_NUP_LIST)
            {
                softwareDeveloper_counter += (int)n.Value;
                n.Value = 0;
            }

            foreach (NumericUpDown n in network_NUP_LIST)
            {
                network_counter += (int)n.Value;
                n.Value = 0;
            }

            foreach (NumericUpDown n in UI_UX_NUP_LIST)
            {
                UI_UX_counter += (int)n.Value;
                n.Value = 0;
            }

            foreach (NumericUpDown n in AI_NUP_LIST)
            {
                AI_counter += (int)n.Value;
                n.Value = 0;
            }

            foreach (NumericUpDown n in Teacher_NUP_LIST)
            {
                Teacher_counter += (int)n.Value;
                n.Value = 0;
            }
        }

        private void LoadLists()
        {
            softwareDeveloper_NUP_LIST = new List<NumericUpDown>()
            {
                sdNUP1, sdNUP2, sdNUP3,
                sdNUP4, sdNUP5, sdNUP6,
                sdNUP7, sdNUP8, teNUP7
            };

            network_NUP_LIST = new List<NumericUpDown>()
            {
                nwNUP1, nwNUP2, nwNUP3, nwNUP4
            };

            UI_UX_NUP_LIST = new List<NumericUpDown>()
            {
                uxNUP1, uxNUP2, uxNUP3, uxNUP4, uxNUP5, teNUP7
            };

            AI_NUP_LIST = new List<NumericUpDown>()
            {
                aiNUP1, aiNUP2, aiNUP3
            };

            Teacher_NUP_LIST = new List<NumericUpDown>()
            {
                teNUP1, teNUP2, teNUP3,
                teNUP4, teNUP5, teNUP6,
                teNUP7
            };
        }

        private void ClearCounters()
        {
            softwareDeveloper_counter = 0;
            network_counter = 0;
            UI_UX_counter = 0;
            AI_counter = 0;
            Teacher_counter = 0;
        }

    }
}
