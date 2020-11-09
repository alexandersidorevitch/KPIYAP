using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extern_Laba_10
{
    class GeniusStudent:Student
    {
        public GeniusStudent(string fio, int countAttendedClasses) : base(fio, countAttendedClasses) { }
        public override bool IsPassExam()
        {
            if (CountAttendedClasses == 0)
            {
                return false;
            }
            return true;
        }
    }
}
