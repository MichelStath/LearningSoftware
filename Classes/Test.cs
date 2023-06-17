using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public enum TestEnum
    {
        INTRO,
        LANG,
        SKILLS,
        JOBS,
        TOTAL
    };

    public class Test
    {


        public Test()
        {
        }

        public Test(int iD, TestEnum tEST, int gRADE)
        {
            S_ID = iD;
            TEST = tEST;
            GRADE = gRADE;
        }

        public int S_ID { get; set; }
        public TestEnum TEST { get; set; }
        public int GRADE { get; set; }

    }
}
