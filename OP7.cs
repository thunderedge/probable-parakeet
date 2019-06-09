using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwDingetje
{
    class Program
    {
        static void Main(string[] args)
        {
            //aaaaaaah 

            //event 1:
            SportEvent event1 = new SportEvent("idk");

            event1.AddStudents(new Student("Raiden")); //en we hebben opeens een metal gear thema
            event1.AddStudents(new Student("Kazuhira"));
            event1.AddStudents(new Student("Adamska"));
            event1.AddStudents(new Student("Venom"));
            event1.AddStudents(new Student("DD")); //best boi

            event1.AddSRecord("Raiden", 32.1);
            event1.AddSRecord("Kazuhira", 20.2);
            event1.AddSRecord("Adamska", 15.3);
            event1.AddSRecord("Venom", 29.4);
            event1.AddSRecord("DD", 11.5);

            Console.WriteLine(event1.info()); //uhh dis is kinda broken atm ahahjkhdfsd

            //event 2:

            SportEvent event2 = new SportEvent("idk");

            event2.AddStudents(new Student("Raiden", 16.1));
            event2.AddStudents(new Student("Kazuhira", 32.2));
            event2.AddStudents(new Student("Adamska", 64.3));
            event2.AddStudents(new Student("Venom", 128.4));
            event2.AddStudents(new Student("DD", 256.5)); //still best boi

            Console.WriteLine(event2.info());

            /*Student s1 = new Student("Raiden"); //test
            Student s2 = new Student("Hal"); //test

            Console.WriteLine(s1.info()); dit werkt wel eeehhhh
            Console.WriteLine(s2);

            //SportEvent event1 = new SportEvent("reee");
            //Console.WriteLine(event1);*/

            Console.ReadKey();
        }

        class Student
        {
            //IK HOEF GEEN STATIC VISUAL STUDIO PLS ij wete dta ik latst heb vna typefus slkdfjsldkf
            //okay en nu dit vetlrane vna java naar c#

            public string name;
            public double sRecord;

            public Student(string name)
            {
                this.name = name;
            }

            public Student(string name, double sRecord) //overloading ahoyy
            {
                this.name = name;
                this.sRecord = sRecord;
            }

            public string info()
            {
                return this.name + "Record: " + this.sRecord;
            }
        }

        class SportEvent
        {
            public string eventName; //hjhfkj okeeeee wat gebeurde er ook allemaal tijdens een sportdag, ik weet alleen dat ik de laatste x in fucking duindorp was terecht gekomen do not recommend
            public List<Student> student;
            public double sRecord; //voor de records :p

            public SportEvent(string eventName) //waarom is dit ding eigenlijk rood... OH HET WAS EEN BREAKPOINT NVM derp
            {
                this.eventName = eventName;
                this.student = new List<Student>();
            }

            public void AddStudents(Student students)
            {
                this.student.Add(students); //studenten toevoegen aan list
            }

            public void AddSRecord(string sname, double rec)
            {
                this.sRecord = rec;

                for (int i = 0; i < student.Count; i++) //loop door list, kijkt of dingetje matcht
                {
                    if (student[i].Equals(sname))
                    {
                        student[i].sRecord = rec; //en dan record toevoegen of updaten of whateves
                    }
                }
            }

            public string info()
            {
                //return string.Join("\n", student.ToArray()); //there was an attempt lmao
            }

        }
    }
}
