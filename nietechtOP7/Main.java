package com.company;

import java.awt.*;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        EventThingy eventThingy = new EventThingy("yolo");

        eventThingy.addStudent(new Student("Raiden", 25)); //en we hebben opeens een metal gear thema
        eventThingy.addStudent(new Student("Kazuhira", 20));
        eventThingy.addStudent(new Student("Adamska", 15));
        eventThingy.addStudent(new Student("Venom", 19));
        eventThingy.addStudent(new Student("DD", 1)); //best boi
        
        System.out.println(eventThingy);
        

//        ArrayList<Student> students = new ArrayList<>();
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
