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
    public partial class HomeForm : Form
    {
        private string currUsername;
        Helper helper = new Helper();
        private Student currentStudent = new Student();
        public HomeForm(string currentUsername)
        {
            InitializeComponent();

            currUsername = currentUsername;
            currentStudent= helper.GetStudent(currUsername);
            label1.Text = ($"Welcome: {currentStudent.F_NAME}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new ΕducationalMaterialForm();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new EvaluationTasksForm();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new StatisticsForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
