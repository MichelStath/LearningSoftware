using LearningSoftware.Classes;
using LearningSoftware.IntroPages;
using LearningSoftware.JobsPages;
using LearningSoftware.LanguagesPages;
using LearningSoftware.SkillsPages;
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
    public partial class ΕducationalMaterialForm : Form
    {
        enum CategoriesEnum
        {
            INTRO,
            LANGUAGES,
            SKILLS,
            JOBS,
            HOME
        }

        #region Initialize Items
        public Dictionary<int, UserControl> introDict = new Dictionary<int, UserControl>();
        public Dictionary<int, UserControl> languagesDict = new Dictionary<int, UserControl>();
        public Dictionary<int, UserControl> skillsDict = new Dictionary<int, UserControl>();
        public Dictionary<int, UserControl> jobsDict = new Dictionary<int, UserControl>();
        public Dictionary<int, UserControl> homeDict = new Dictionary<int, UserControl>();
        public IntroPage1 iPage1 = new IntroPage1();
        public IntroPage2 iPage2 = new IntroPage2();
        public LangPage1 lPage1 = new LangPage1();
        public LangPage2 lPage2 = new LangPage2();
        public SkillPage1 sPage1 = new SkillPage1();
        public SkillPage2 sPage2 = new SkillPage2();
        public JobPage1 jPage1 = new JobPage1();
        public JobPage2 jPage2 = new JobPage2();
        public HomePage1 hPage1 = new HomePage1();
        public HomePage2 hPage2 = new HomePage2();
        public Student currentStudent = new Student();
        public LessonView currentLessonView = new LessonView();

        int currPage = 1;
        CategoriesEnum currCategory = CategoriesEnum.HOME;

        #endregion


        public ΕducationalMaterialForm(Student st)
        {
            InitializeComponent();
            FeedDictionary();
            showPage(currPage, currCategory);
            currentStudent = st;
            currentLessonView = Helper.GetLessonView(currentStudent.S_ID);
        }


        private void exitBTN_Click(object sender, EventArgs e)
        {
            //Helper.updateLessonView(currentLessonView);
            this.Close();
        }

        private void introBTN_Click(object sender, EventArgs e)
        {
            currentLessonView.LESSON_1 = currentLessonView.LESSON_1 + 1;
            Helper.UpdateLessonView(currentLessonView);
            nextBTN.Enabled = true;
            prevBTN.Enabled = false;
            currPage = 1;
            currCategory = CategoriesEnum.INTRO;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void langBTN_Click(object sender, EventArgs e)
        {
            currentLessonView.LESSON_2 = currentLessonView.LESSON_2 + 1;
            Helper.UpdateLessonView(currentLessonView);
            nextBTN.Enabled = true;
            prevBTN.Enabled = false;
            currPage = 1;
            currCategory = CategoriesEnum.LANGUAGES;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void skilsBTN_Click(object sender, EventArgs e)
        {
            currentLessonView.LESSON_3 = currentLessonView.LESSON_3 + 1;
            Helper.UpdateLessonView(currentLessonView);
            nextBTN.Enabled = true;
            prevBTN.Enabled = false;
            currPage = 1;
            currCategory = CategoriesEnum.SKILLS;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void jobsBTN_Click(object sender, EventArgs e)
        {
            currentLessonView.LESSON_4 = currentLessonView.LESSON_4 + 1;
            Helper.UpdateLessonView(currentLessonView);
            nextBTN.Enabled = true;
            prevBTN.Enabled = false;
            currPage = 1;
            currCategory = CategoriesEnum.JOBS;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {

            currPage++;
            if (currPage == 2)
            {
                nextBTN.Enabled = false;
            }
            if (currPage == 2)
            {
                prevBTN.Enabled = true;
            }
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            currPage--;
            if (currPage == 1)
            {
                prevBTN.Enabled = false;
            }
            if (currPage == 1)
            {
                nextBTN.Enabled = true;
            }
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void clearMainPanel()
        {
            mainPanel.Controls.Clear();
            this.Refresh();
        }

        //ready
        private void showPage(int page, CategoriesEnum category)
        {

            switch (category)
            {
                case CategoriesEnum.INTRO:
                    var pageToShow = new UserControl();
                    bool hasValue = introDict.TryGetValue(page, out pageToShow);
                    if (hasValue)
                    {
                        mainPanel.Controls.Add(pageToShow);
                        //pageToShow.Show();
                    }
                    else Console.WriteLine("Something gone wrong");
                    break;
                case CategoriesEnum.LANGUAGES:
                    var pageToShow1 = new UserControl();
                    bool hasValue1 = languagesDict.TryGetValue(page, out pageToShow1);
                    if (hasValue1)
                    {
                        mainPanel.Controls.Add(pageToShow1);
                        //pageToShow.Show();
                    }
                    else Console.WriteLine("Something gone wrong");
                    break;
                case CategoriesEnum.SKILLS:
                    var pageToShow2 = new UserControl();
                    bool hasValue2 = skillsDict.TryGetValue(page, out pageToShow2);
                    if (hasValue2)
                    {
                        mainPanel.Controls.Add(pageToShow2);
                        //pageToShow.Show();
                    }
                    else Console.WriteLine("Something gone wrong");
                    break;
                case CategoriesEnum.JOBS:
                    var pageToShow4 = new UserControl();
                    bool hasValu4 = jobsDict.TryGetValue(page, out pageToShow4);
                    if (hasValu4)
                    {
                        mainPanel.Controls.Add(pageToShow4);
                        //pageToShow.Show();
                    }
                    else Console.WriteLine("Something gone wrong");
                    break;
                case CategoriesEnum.HOME:
                    var pageToShow5 = new UserControl();
                    bool hasValu5 = homeDict.TryGetValue(page, out pageToShow5);
                    if (hasValu5)
                    {
                        mainPanel.Controls.Add(pageToShow5);
                        //pageToShow.Show();
                    }
                    else Console.WriteLine("Something gone wrong");
                    break;
                default:
                    break;
            }
        }
        //ready
        private void FeedDictionary()
        {
            introDict.Add(1, iPage1);
            introDict.Add(2, iPage2);

            languagesDict.Add(1, lPage1);
            languagesDict.Add(2, lPage2);

            skillsDict.Add(1, sPage1);
            skillsDict.Add(2, sPage2);

            jobsDict.Add(1, jPage1);
            jobsDict.Add(2, jPage2);

            homeDict.Add(1, hPage1);
            homeDict.Add(2, hPage2);
        }

    }
}
