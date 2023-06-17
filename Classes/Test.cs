using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public class Test
    {
        public Test()
        {
        }

        public Test(int iD, int tEST_1, int tEST_2, int tEST_3, int tEST_4, int tEST_T)
        {
            S_ID = iD;
            TEST_1 = tEST_1;
            TEST_2 = tEST_2;
            TEST_3 = tEST_3;
            TEST_4 = tEST_4;
            TEST_T = tEST_T;
        }

        public int S_ID { get; set; }
        public int TEST_1 { get; set; }
        public int TEST_2 { get; set; }
        public int TEST_3 { get; set; }
        public int TEST_4 { get; set; }
        public int TEST_T { get; set; }

    }
}
