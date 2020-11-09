using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Extern_Laba_10
{
    class Program
    {
       static  void GetFromFile(Object[] students, int countUsualStudent, int countSamrtStudent, int countGeniusStudent, string path)
        {
            using (var reader = new StreamReader(path,Encoding.Default))
            {
                int i;
                for (i = 0; i < countUsualStudent; i++)
                {
                    string FIO = reader.ReadLine();
                    int countAddedClasses = int.Parse(reader.ReadLine());
                    students[i] = new UsualStudent(FIO, countAddedClasses);
                }
                for (; i < countUsualStudent + countSamrtStudent; i++)
                {
                    string FIO = reader.ReadLine();
                    int countAddedClasses = int.Parse(reader.ReadLine());
                    students[i] = new SmartStudent(FIO, countAddedClasses);
                }
                for (; i < countUsualStudent + countSamrtStudent + countGeniusStudent; i++)
                {
                    string FIO = reader.ReadLine();
                    int countAddedClasses = int.Parse(reader.ReadLine());
                    students[i] = new GeniusStudent(FIO, countAddedClasses);
                }
            }
        }
        static void Main(string[] args)
        {
            //var car = new Car("Машина", 140);
            //var ExesCar = new ExecutiveСar("Биббика", 160);

            //Console.WriteLine(car.Information());
            //Console.WriteLine(ExesCar.Information());

            //car.UpdateModel();
            //ExesCar.UpdateModel();

            //Console.WriteLine(car.Information());
            //Console.WriteLine(ExesCar.Information());


            Object[] students = new Object[10];

            GetFromFile(students, 5, 4, 1, "1.txt");

            foreach (Object student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
