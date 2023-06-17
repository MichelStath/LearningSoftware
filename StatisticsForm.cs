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
        public Student currentStudent = new Student(); 
        private List<LessonView> allLessonViewList = new List<LessonView>();
        public StatisticsForm(Student st)
        {
            InitializeComponent();
            currentStudent = st;
            LoadStatistics();
            label8.Text = $"View Lessons: {currentStudent.USERNAME}";
            label30.Text = $"Test Grades: {currentStudent.USERNAME}";
            label20.Text = $"Test Grades avg: {currentStudent.USERNAME}";
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStatistics()
        {
            allLessonViewList = Helper.GetAllLessonView();
            //VIEW LESSONS TOTAL
            introLB.Text = allLessonViewList.Select(x => x.LESSON_1).Sum().ToString();
            langLB.Text = allLessonViewList.Select(x => x.LESSON_2).Sum().ToString();
            jobsLB.Text = allLessonViewList.Select(x => x.LESSON_3).Sum().ToString();
            skillsLB.Text = allLessonViewList.Select(x => x.LESSON_4).Sum().ToString();
            totalLB.Text = allLessonViewList.Select(x => x.LESSON_1 + x.LESSON_2 + x.LESSON_3 + x.LESSON_4).Sum().ToString();
            //VIEW LESSONS (USER)
            userIntroLB.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_1).Sum().ToString(); 
            userLangLB.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_2).Sum().ToString(); 
            userJobsLB.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_3).Sum().ToString(); 
            userSKillsLB.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_4).Sum().ToString(); 
            userTotalLB.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_1 + x.LESSON_2 + x.LESSON_3 + x.LESSON_4).Sum().ToString(); 
        

        }
    }
}
