package com.company;

import java.util.ArrayList;

public class EventThingy{
    private String eventName;
    private double sRecord;
    private ArrayList<Student> students; //arraylist met studenten die meedoen

    public EventThingy(String eventName){
        this.eventName = eventName;
        this.students = new ArrayList<>();
    }

    public void setEventName(String eventName) { //setters
        this.eventName = eventName;
    }

    public String getEventName(){ //getters
        return this.eventName;
    }

    public void addStudent(Student student){
        this.students.add(student); //voegt studenten toe aan arraylist
    }

    public void addStudentRecord(String sName, double records){
        this.sRecord = records;

        for(int i = 0; i < this.students.size(); i++){ //whee for loop
            if(this.students.get(i).getName().equals(sName)){ //lopot foor list n kwjkt of naam matchet me t studnet naam.
                this.students.get(i).setStudentRecord(records); //dna udpate ie de record
            }
        }
    }

    public Student bestRecord() { //boildean, sushi really wou je osms ene nieweu daete type verzinnen?

        Student bestRecord = this.students.get(0); //referentiedingpunt

        for(Student s: this.students){
            if(s.getStudentRecord() > bestRecord.getStudentRecord()){ //kijkt f record hoger/btr is dna ref en cpoypsta dat erin ald dat do is
                bestRecord = s;
            }
        }

        return bestRecord;
    }

    public String toString(){
        String sName = ""; //init

        for(Student s: this.students){
            sName += " " + s.getName() + " Record: " + s.getStudentRecord() + "\n"; //loopt door lijst, haalt alle studenten op
        }

        return sName;
    }
}
