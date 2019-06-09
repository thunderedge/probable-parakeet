package com.company;

import java.awt.*;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        //nou, wacht eens ff. volgens mij denk ik te moeilijk na hierover :thonk:

        //event 1: kan records per student toevoegen dmv methode
        EventThingy yolo = new EventThingy("yolo");

        yolo.addStudent(new Student("Raiden")); //en we hebben opeens een metal gear thema
        yolo.addStudent(new Student("Kazuhira"));
        yolo.addStudent(new Student("Adamska"));
        yolo.addStudent(new Student("Venom"));
        yolo.addStudent(new Student("DD")); //best boi

        yolo.addStudentRecord("Raiden", 32.1);
        yolo.addStudentRecord("Kazuhira", 20.2);
        yolo.addStudentRecord("Adamska", 15.3);
        yolo.addStudentRecord("Venom", 29.4);
        yolo.addStudentRecord("DD", 11.5);
        
        System.out.println(yolo);

        Student brecord = yolo.bestRecord(); //doet per event kijken nog hmmmmmmmmmmmmmmmmmmm
        System.out.println("> Student w/ best record for " + yolo.getEventName() + " is: " + brecord);

        System.out.println(" ");
        System.out.println("*-*-*"); //for teh lulz
        System.out.println(" ");

        //event 2: kan records toevoegen door deze mee te geven tijdens aanmaken obj 

        EventThingy hecc = new EventThingy("hecc");

        hecc.addStudent(new Student("Raiden", 16.1));
        hecc.addStudent(new Student("Kazuhira", 32.2));
        hecc.addStudent(new Student("Adamska", 64.3));
        hecc.addStudent(new Student("Venom", 128.4));
        hecc.addStudent(new Student("DD", 256.5)); //still best boi

        System.out.println(hecc);

        Student bsrecord = hecc.bestRecord();
        System.out.println("> Student w/ best record for " + hecc.getEventName() + " is: " + bsrecord);
        

//        ArrayList<Student> students = new ArrayList<>();
//        testen is leuk
//        for(Student s : list ){
//          System.out.println(s); //uitprinten
//        }
//
//        
//        Student s1 = new Student("Raiden", 25);
//        Student s2 = new Student("Hal");
//        System.out.println(s1);
//        System.out.println(s2);
    }
}
