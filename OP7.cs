using System;
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
            //ben begonnen met c#, heb alleen meer gewerkt met java btw

            //todo: doe dingen hier later en delete copypasta opdrachttxt

            /*opdrachttxt:
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
            public string name;
            public int studNr;
            public int age;


            public Student(string name, int studNr, int age)
            {
                this.name = name;
                this.studNr = studNr;
                this.age = age;
            }
        }

        class SportEventThingmajig
        {
            public string eventName; //hjhfkj okeeeee wat gebeurde er ook allemaal tijdens een sportdag, ik weet alleen dat ik de laatste x in fucking duindorp was terecht gekomen do not recommend


            public SportEventThingmajig()
            {

            }

        }
    }
}
