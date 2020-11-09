using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extern_Laba_10
{
    class Student
    {
        public string FIO { get; set; }
        private int countAttendedClasses;
        public int CountAttendedClasses
        {
            get { return countAttendedClasses; }
            set
            {
                if (value > NumberOfSharedClasses)
                {
                    throw new Exception("Кол-во занятий больше чем всего есть");
                }
                countAttendedClasses = value;
            }
        }
        public int NumberOfSharedClasses { get; protected set; }
        protected double Probability { get; set; }
        protected Random Rand { get; set; }
        public virtual bool IsPassExam()
        {
            return Probability <= Rand.NextDouble();
        }

        public Student(string fio, int countAttendedClasses)
        {
            NumberOfSharedClasses = 20;
            FIO = fio;
            CountAttendedClasses = countAttendedClasses;
            Rand = new Random();
        }
        public Student(string fio, int countAttendedClasses, double probability) : this(fio, countAttendedClasses)
        {
            Probability = probability;
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}, количество посещенных занятий: {CountAttendedClasses}\nСдал: {IsPassExam()}";
        }
    }
}
