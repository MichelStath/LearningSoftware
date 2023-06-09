using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public class LessonView
    {
        public LessonView(int iD, int lESSON_1, int lESSON_2, int lESSON_3, int lESSON_4)
        {
            S_ID = iD;
            LESSON_1 = lESSON_1;
            LESSON_2 = lESSON_2;
            LESSON_3 = lESSON_3;
            LESSON_4 = lESSON_4;
        }

        public int S_ID { get; set; }
        public int LESSON_1 { get; set;}
        public int LESSON_2 { get; set;}
        public int LESSON_3 { get; set;}
        public int LESSON_4 { get; set;}
    }
}
