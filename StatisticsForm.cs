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
    public partial class StatisticsForm : Form
    {
        private Student currentStudent = new Student(); 
        private List<LessonView> allLessonViewList = new List<LessonView>();
        public StatisticsForm(Student st)
        {
            InitializeComponent();
            LoadStatistics();
            currentStudent = st;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStatistics()
        {
            allLessonViewList = Helper.GetAllLessonView();
            introLB.Text = allLessonViewList.Select(x => x.LESSON_1).Sum().ToString();
            langLB.Text = allLessonViewList.Select(x => x.LESSON_2).Sum().ToString();
            jobsLB.Text = allLessonViewList.Select(x => x.LESSON_3).Sum().ToString();
            skillsLB.Text = allLessonViewList.Select(x => x.LESSON_4).Sum().ToString();
            totalLB.Text = allLessonViewList.Select(x => x.LESSON_1 + x.LESSON_2 + x.LESSON_3 + x.LESSON_4).Sum().ToString();

            userIntroLB.Text = allLessonViewList.Where(x => x.S_ID == 1).Select(x => x.LESSON_1).First().ToString(); 
            userLangLB.Text = allLessonViewList.Where(x => x.S_ID == 1).Select(x => x.LESSON_2).First().ToString(); 
            userJobsLB.Text = allLessonViewList.Where(x => x.S_ID == 1).Select(x => x.LESSON_3).First().ToString(); 
            userSKillsLB.Text = allLessonViewList.Where(x => x.S_ID == 1).Select(x => x.LESSON_4).First().ToString(); 
            userTotalLB.Text = allLessonViewList.Where(x => x.S_ID == 1).Select(x => x.LESSON_1 + x.LESSON_2 + x.LESSON_3 + x.LESSON_4).Sum().ToString(); 
        
        
        }
    }
}
