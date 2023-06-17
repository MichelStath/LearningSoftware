using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public class JobFinderClass
    {
        public JobFinderClass()
        {
        }

        public JobFinderClass(int iD, int sOFTWARE, int nETWORK, int uI_UX, int aI, int tEACHER)
        {
            S_ID = iD;
            SOFTWARE = sOFTWARE;
            NETWORK = nETWORK;
            UI_UX = uI_UX;
            AI = aI;
            TEACHER = tEACHER;
        }

        public int S_ID { get; set; }
        public int SOFTWARE { get; set; }
        public int NETWORK { get; set; }
        public int UI_UX { get; set; }
        public int AI { get; set; }
        public int TEACHER { get; set; }
    }
}
