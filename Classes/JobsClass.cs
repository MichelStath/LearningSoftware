using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public class JobsClass
    {
        public JobsClass()
        {
        }

        public JobsClass(string jOB_NAME, int jOB_SCORE)
        {
            JOB_NAME = jOB_NAME;
            JOB_SCORE = jOB_SCORE;
        }

        public string JOB_NAME { get; set; }
        public int JOB_SCORE { get; set; }
    }
}
