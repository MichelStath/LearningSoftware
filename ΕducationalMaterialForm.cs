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
        public IntroPage1 iPage1 = new IntroPage1();
        public IntroPage2 iPage2 = new IntroPage2();
        public LangPage1 lPage1 = new LangPage1();  
        public LangPage2 lPage2 = new LangPage2();
        public SkillPage1 sPage1= new SkillPage1();
        public SkillPage2 sPage2= new SkillPage2();
        public JobPage1 jPage1 = new JobPage1();
        public JobPage2 jPage2 = new JobPage2();

        int currPage = 1;
        CategoriesEnum currCategory= CategoriesEnum.HOME;

        #endregion


        public ΕducationalMaterialForm()
        {
            InitializeComponent();
            FeedDictionary();
        }


        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void introBTN_Click(object sender, EventArgs e)
        {
            currPage = 1;
            currCategory= CategoriesEnum.INTRO;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void langBTN_Click(object sender, EventArgs e)
        {
            currPage = 1;
            currCategory= CategoriesEnum.LANGUAGES;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void skilsBTN_Click(object sender, EventArgs e)
        {
            currPage = 1;
            currCategory= CategoriesEnum.SKILLS;
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void jobsBTN_Click(object sender, EventArgs e)
        {
            currPage = 1;
            currCategory= CategoriesEnum.JOBS;
            clearMainPanel();
            showPage(currPage,currCategory);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            currPage++;
            if (currPage > 1)
            {
                prevBTN.Enabled = true;
            }
            clearMainPanel();
            showPage(currPage,currCategory);
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            currPage--;
            if (currPage == 1)
            {
                prevBTN.Enabled = false;
            }
            clearMainPanel();
            showPage(currPage, currCategory);
        }

        private void clearMainPanel()
        {
            mainPanel.Controls.Clear();
            this.Refresh();
        }

        private void showPage(int page , CategoriesEnum category)
        {

            switch (category)
            {
                case CategoriesEnum.INTRO:
                    var pageToShow = new UserControl();
                    bool hasValue = introDict.TryGetValue(page, out pageToShow);
                    if (hasValue) {
                        mainPanel.Controls.Add(pageToShow);
                        //pageToShow.Show();
                    } 
                    else Console.WriteLine("Something gone wrong");
                    break;
                case CategoriesEnum.LANGUAGES:
                    break;
                case CategoriesEnum.SKILLS:
                    break;
                case CategoriesEnum.JOBS:
                    break;
                case CategoriesEnum.HOME:
                    break;
                default:
                    break;
            }
        }

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
        }

    }
}
