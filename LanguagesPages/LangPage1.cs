using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LearningSoftware.LanguagesPages
{
    public partial class LangPage1 : UserControl
    {
        public Dictionary<string, string> webDict = new Dictionary<string, string>();
        public LangPage1()
        {
            InitializeComponent();
            feedDict();
        }

        private void openWebBrowser(string link)
        {
            WebBrowser wb = new WebBrowser(link);
            wb.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string lang = (sender as Label).Text;
            string pageToShow;
            bool hasValue = webDict.TryGetValue(lang, out pageToShow);
            if (hasValue)
            {
                openWebBrowser(pageToShow);
            }
            else MessageBox.Show("Something gone Wrong");
            label2.Text = lang;
        }

        private void feedDict()
        {
            webDict.Add("Ada", "https://el.wikipedia.org/wiki/Ada");
            webDict.Add("Go", "https://el.wikipedia.org/wiki/Go_(%CE%B3%CE%BB%CF%8E%CF%83%CF%83%CE%B1_%CF%80%CF%81%CE%BF%CE%B3%CF%81%CE%B1%CE%BC%CE%BC%CE%B1%CF%84%CE%B9%CF%83%CE%BC%CE%BF%CF%8D)");
            webDict.Add("Pascal", "https://el.wikipedia.org/wiki/Pascal_(%CE%B3%CE%BB%CF%8E%CF%83%CF%83%CE%B1_%CF%80%CF%81%CE%BF%CE%B3%CF%81%CE%B1%CE%BC%CE%BC%CE%B1%CF%84%CE%B9%CF%83%CE%BC%CE%BF%CF%8D)");
            webDict.Add("Perl", "https://el.wikipedia.org/wiki/Perl");
            webDict.Add("Java", "https://el.wikipedia.org/wiki/Java");
            webDict.Add("PHP", "https://el.wikipedia.org/wiki/PHP");
            webDict.Add("BASIC", "https://el.wikipedia.org/wiki/BASIC");
            webDict.Add("Kotlin", "https://www.techtarget.com/whatis/definition/Kotlin");
            webDict.Add("Prolog", "https://el.wikipedia.org/wiki/Prolog");
            webDict.Add("Lua", "https://el.wikipedia.org/wiki/Lua");
            webDict.Add("Ruby", "https://el.wikipedia.org/wiki/Ruby");
            webDict.Add("C", "https://el.wikipedia.org/wiki/C_(%CE%B3%CE%BB%CF%8E%CF%83%CF%83%CE%B1_%CF%80%CF%81%CE%BF%CE%B3%CF%81%CE%B1%CE%BC%CE%BC%CE%B1%CF%84%CE%B9%CF%83%CE%BC%CE%BF%CF%8D)");
            webDict.Add("C++", "https://el.wikipedia.org/wiki/C_plus_plus");
            webDict.Add("C#", "https://el.wikipedia.org/wiki/C_Sharp");
            webDict.Add("Objective-C", "https://el.wikipedia.org/wiki/Objective-C");
            webDict.Add("Visual Basic", "https://el.wikipedia.org/wiki/Visual_Basic");
            webDict.Add("TypeScript", "https://en.wikipedia.org/wiki/TypeScript");
            webDict.Add("JavaScript", "https://el.wikipedia.org/wiki/JavaScript");
            webDict.Add("Matlab", "https://el.wikipedia.org/wiki/Matlab");
            webDict.Add("Python", "https://el.wikipedia.org/wiki/Python");
            webDict.Add("FORTRAN", "https://el.wikipedia.org/wiki/FORTRAN");
            webDict.Add("SQL", "https://el.wikipedia.org/wiki/SQL");
        }

    }
}
