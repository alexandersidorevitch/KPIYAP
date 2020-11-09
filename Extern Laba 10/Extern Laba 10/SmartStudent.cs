using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extern_Laba_10
{
    class SmartStudent:Student
    {
        public SmartStudent(string fio, int countAttendedClasses) : base(fio, countAttendedClasses, 0.7) { }
        public override bool IsPassExam()
        {
            if (CountAttendedClasses == NumberOfSharedClasses)
            {
                return true;
            }
            else if (CountAttendedClasses >= NumberOfSharedClasses / 2)
            {
                return base.IsPassExam();

            }
            return false;
        }
    }
}
