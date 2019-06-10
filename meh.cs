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
            //eff mijn hersenen en mijn faalangst. oke/ let's REDO this.

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

            Console.WriteLine("Records for: " + event1.EventName);
            Console.WriteLine(event1.toString());

            //event 2:

            SportEvent event2 = new SportEvent("idk");

            event2.AddStudents(new Student("Raiden"));
            event2.AddStudents(new Student("Kazuhira"));
            event2.AddStudents(new Student("Adamska"));
            event2.AddStudents(new Student("Venom"));
            event2.AddStudents(new Student("DD")); //still best boi

            event2.AddSRecord("Raiden", 16.1);
            event2.AddSRecord("Kazuhira", 32.2);
            event2.AddSRecord("Adamska", 64.3);
            event2.AddSRecord("Venom", 128.4);
            event2.AddSRecord("DD", 256.5);

            Console.WriteLine("Records for: " + event2.EventName);
            Console.WriteLine(event2.toString());

            BestScore a = new BestScore();
            a.Compare(event1);
            a.Compare(event2);

            Console.WriteLine(a.toString());

            Console.ReadKey();

            /*Student s1 = new Student("Raiden"); //test
            Student s2 = new Student("Hal"); //test

            Console.WriteLine(s1.toString()); //test
            Console.WriteLine(s2.toString()); //test

            SportEvent event1 = new SportEvent("reee");
            Console.WriteLine(event1);*/

            /*note to self: test zooi en delete copypasta opdrachttxt later
			*
            * opdrachttxt:
            * Tijdens deze opdracht ga je een programma maken voor dataverwerking. Dit programma wordt
            * gebruikt om de resultaten van een sportdag op school bij te houden.Je dient tijdens deze opdracht
            * gebruik te maken van classes en verzamelingen(arrays / lijsten). Hoe je het programma opbouwt is aan jou.
            *
            * De gebruiker moet de volgende dingen kunnen:
            * Het aanmaken van studenten(2 punt)
            * Het aanmaken van events(2 punt)
            * Het registeren van tijden / scores van studenten op specifieke events(3 punt)
            * Een lijst tonen van de beste student voor ieder event ( 3 punt )
            */
        }

        class Student
        {
            //IK HOEF GEEN STATIC VISUAL STUDIO PLS ij wete dta ik latst heb vna typefus slkdfjsldkf
            //okay en nu dit vetlrane vna java naar c#
            
            public Student(string name) //ctrl+z all the waaaaaaay
            {
                Name = name;
            }

            /*Student(string name, int stNr)
            {
                Name = name;
                StNr = stNr;
            }

            public Student(string name, double srec) //overloading ahoyy
            {
                Name = name;
                sRecord = srec;
            }*/

            public string Name { get; set; } //zoveel overzichtelijker dan in java, ily for this c# <3

            //public int StNr { get; set; }
            
            public double sRecord { get; set; }

            public string toString()
            {
                //return Name + StNr;
                return Name;
            }
        }

        class SportEvent
        {
            public List<Student> student;
            public double sRecord; //voor de records :p

            public SportEvent(string eventName) //waarom is dit ding eigenlijk rood... OH HET WAS EEN BREAKPOINT NVM derp
            {
                EventName = eventName;
                student = new List<Student>();
            }

            public string EventName { get; set; }

            public void AddStudents(Student students)
            {
                student.Add(students); //studenten toevoegen aan list
            }

            public void AddSRecord(string sname, double rec)
            {
                sRecord = rec;

                for(int i = 0; i < student.Count; i++) //loop door list, kijkt of dingetje matcht
                {
                    if(student[i].Name.Equals(sname)) //leer eens een keertje lezen ffs, er moest nog een .name achter fffffffffff
                    {
                        student[i].sRecord = rec; //en dan record toevoegen of updaten of whateves
                    }
                }
            }

            public string toString()
            {
                string str = ""; 
                
                //heel soms heb ik een brainfart en vergeet ik hoe een bepaalde loop werkt.

                foreach(Student s in student)
				{ //sorry foreach
                    //str += s.Name + " Record: " + s.sRecord + "\n"; //ugh ik weet dat ik dit ietjes netter kan afhandelen,,,,
                    str += string.Format("{0} Record: {1} \n", s.Name, s.sRecord);
                }

                return str;
            }
        }
		
        class BestScore //ik heb een vaag idee hoe ik dit kan aanpakken??
        { //pls come back nooo my thought process yfyhfddfsldjfslk
            public List<Student> scores = new List<Student>(); 
            public void Compare(SportEvent spEvent)
            {
                Student brec = spEvent.student.ElementAt(0); //ref point
                foreach (Student s in spEvent.student)
                {
                    if (s.sRecord > brec.sRecord) //kijkt of score hoger is dan ref zo ja dan vervangen
                    {
                        brec = s;
                    }
                }
                scores.Add(brec); //en degene met de hoogste score toevoegen aan lijst 
                //uhh en nu maar hopen dat ik goed zit??
            }
            public string toString()
            {
                string str = "Best overall records:\n";

                foreach (Student s in scores)
                {
                    str += string.Format("{0} Record: {1} \n", s.Name, s.sRecord);
                }
                return str;
            }
        }
    }
}
