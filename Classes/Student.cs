using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSoftware.Classes
{
    public class Student
    {
        public Student(string uSERNAME,
            string pASSWORD,
            string nAME,
            string sURNAME)
        {
            USERNAME = uSERNAME;
            PASSWORD = pASSWORD;
            F_NAME = nAME;
            S_NAME = sURNAME;
        }

        public int S_ID { get; }
        public string USERNAME { get; set; }   
        public string PASSWORD { get; set; }
        public string F_NAME { get; set; }
        public string S_NAME { get; set; }
    }
}
