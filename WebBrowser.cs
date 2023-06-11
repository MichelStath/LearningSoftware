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
    public partial class WebBrowser : Form
    {
        public string currnetLink { get; set; }
        public WebBrowser(string link)
        {
            InitializeComponent();
            currnetLink = link;
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(currnetLink));
        }
    }
}
