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
        private List<Test> allTestList= new List<Test>();
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
            allTestList = Helper.GetAllTests();

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


            //TEST GRADES TOTAL AVG
            testIntroTotalLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.INTRO)).Select(x => x.GRADE).Average().ToString();
            langTestTotalLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.LANG)).Select(x => x.GRADE).Average().ToString();
            jobsTestTotalLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.JOBS)).Select(x => x.GRADE).Average().ToString();
            skillsTestTotalLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.SKILLS)).Select(x => x.GRADE).Average().ToString();
            generalTestTotalLB.Text = allTestList.Select(x => x.GRADE).Average().ToString();

            //TEST GRADES USERNAME
            introTestUserLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.INTRO) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).First().ToString();
            langTestUserLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.LANG) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).First().ToString();
            jobsTestUserLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.JOBS) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).First().ToString();
            skillsTestUserLB.Text = allTestList.Where(x => x.TEST.Equals(TestEnum.SKILLS) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).First().ToString();
            generalTestUserLB.Text = allTestList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).First().ToString();

            //TEST GRADES USERNAME AVG
            var introuserAVG = allTestList.Where(x => x.TEST.Equals(TestEnum.INTRO) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).Average().ToString();
            var languserAVG = allTestList.Where(x => x.TEST.Equals(TestEnum.LANG) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).Average().ToString();
            var jobsuseravg = allTestList.Where(x => x.TEST.Equals(TestEnum.JOBS) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).Average().ToString();
            var skillsuseravg = allTestList.Where(x => x.TEST.Equals(TestEnum.SKILLS) && x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).Average().ToString();

            introTestUserAVGLB.Text = introuserAVG.ToString();
            langTestUserAVGLB.Text = languserAVG.ToString();
            jobsTestUserAVGLB.Text = jobsuseravg.ToString();
            skillsTestUserAVGLB.Text =skillsuseravg.ToString();
            generalTestUserAVGLB.Text = allTestList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.GRADE).Average().ToString();

            //Test-View User Stats
            label47.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_1).First().ToString();
            label48.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_2).First().ToString();
            label49.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_3).First().ToString();
            label50.Text = allLessonViewList.Where(x => x.S_ID.Equals(currentStudent.S_ID)).Select(x => x.LESSON_4).First().ToString();

            label51.Text = introuserAVG.ToString();
            label52.Text = languserAVG.ToString();
            label53.Text = jobsuseravg.ToString();
            label54.Text = skillsuseravg.ToString();

            //test tries total
            label69.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.INTRO)).Count().ToString(); 
            label68.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.LANG)).Count().ToString();
            label67.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.JOBS)).Count().ToString();
            label66.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.SKILLS)).Count().ToString();
            label65.Text = allTestList.Count().ToString();

            //test tries student
            label61.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.INTRO) && x.S_ID.Equals(currentStudent.S_ID)).Count().ToString(); 
            label62.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.LANG) && x.S_ID.Equals(currentStudent.S_ID)).Count().ToString();
            label63.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.JOBS) && x.S_ID.Equals(currentStudent.S_ID)).Count().ToString();
            label64.Text = allTestList.Where((x) => x.TEST.Equals(TestEnum.SKILLS) && x.S_ID.Equals(currentStudent.S_ID)).Count().ToString();
            label70.Text = allTestList.Where((x) => x.S_ID.Equals(currentStudent.S_ID)).Count().ToString();



        }
    }
}
