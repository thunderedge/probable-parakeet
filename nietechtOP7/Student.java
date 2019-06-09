package com.company;

public class Student{ //quick refresher
    private String name;
    private int age;
    private double studentRecord;

    public Student(String name){ //constructor
        this(name, 0, 0);
    }

    public Student(String name, double studentRecord){
        this(name, 0, studentRecord);
    }

    public Student(String name, int age, double studentRecord){ //constructor, overloaded
        this.name = name;
        this.age = age;
        this.studentRecord = studentRecord;
    }

    public void setName(String name){ //setters, java y. in c# is dit zoveel makkelijker
        this.name = name;
    }

    public void setAge(int age){
        this.age = age;
    }

    public void setStudentRecord(double studentRecord) {
        this.studentRecord = studentRecord;
    }

    public String getName(){ //getters
        return this.name;
    }

    public int getAge(){
        return this.age;
    }

    public double getStudentRecord(){
        return this.studentRecord;
    }

    public String toString(){ //geeft alles uit deze class terug
        return this.name + " Record: " + this.studentRecord;
    }
}
