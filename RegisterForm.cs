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
    public partial class RegisterForm : Form
    {
        Helper helper= new Helper();
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void registerBTN_Click(object sender, EventArgs e)
        {
            Student s = new Student(textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text);
            helper.saveStudentToDB(s);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
