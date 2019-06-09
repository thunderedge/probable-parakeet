package com.company;

import java.util.ArrayList;

public class EventThingy{
    private String eventName;
    private ArrayList<Student> students; //arraylist met studenten die meedoen

    public EventThingy(String eventName){
        this.eventName = eventName;
        this.students = new ArrayList<>();
    }

    public void setEventName(String eventName) {
        this.eventName = eventName;
    }

    public String getEventName(){
        return this.eventName;
    }

    public void addStudent(Student student){
        this.students.add(student); //en voeg ze teoe
    }
}
