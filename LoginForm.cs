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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void goToRegisterBTN_Click(object sender, EventArgs e)
        {
            var f = new RegisterForm();
            f.ShowDialog();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            var f = new HomeForm();
            f.ShowDialog();
        }
    }
}
