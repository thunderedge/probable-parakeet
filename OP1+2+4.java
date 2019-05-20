package hwdingetje;

import java.util.Scanner;

/**
 *
 * @author adeliae //pygoscelis adeliae = https://en.wikipedia.org/wiki/Ad%C3%A9lie_penguin
 */
public class HwDingetje {

    public static void main(String[] args) {
        opgave1();
        //opgave2();
        //opgave4(5);
    }
    
    
    public static void opgave1(){
        //met maar één printline?
        //ok:
        //System.out.println("*\n**\n***\n****\n*****"); //Щ(･｀ω´･Щ)
        


        //jkjk
        
        
        //zoals het moet volgens de opdracht:
        String pygoscelis = ""; //string init
        
        for(int i = 0; i < 5; i++){
            pygoscelis += "☆"; //string opbouwen
            //pygoscelis += "*"; //zonder exotische tekens
            System.out.println(pygoscelis); //en uitprinten
        }
        
    }
    
    
    public static void opgave2(){
        //TO INFINITY AND BEYOOOOOOOOOOOOOOOOOOOOND ﾟ+.(ﾉ｡'▽')ﾉ*.ｵｵｫｫ☆ﾟ･:*☆
        //i'll keep this joke running.
        
        double input; //double aanmaken voor scannerdinginputgeval
        double kelvin; //celsius + 372.51
        double wiegebruiktditbehalveamerika; //celsius * 1.8 + 32 en ja ik weet dat ik camelcase moet gebruiken, bite me
        //aah okay ik had de opdracht beter moeten lezen, convert van celsius naar fahrenheit/kevin!
        //0ﾟC == 273.15K, 0ﾟC == 32ﾟF | -273.51ﾟC == 0K,  100ﾟC == 121ﾟF

        Scanner mcScanFace = new Scanner(System.in); //scanner aanroepen omdat we user input nodig hebben
        //nee fuck updates, stop windhoos pl0x
        
        //uhh het zou helpen als je ook iets in de console laat zien zodat de gebruiker ook weet wat ie moet doen.
        System.out.println("> ﾟC?");
        System.out.print("* "); //just to be extra fancy
        
        input = mcScanFace.nextDouble(); //inputmismatchexception? really?? waar is de mismatch???
        //nvm, kreeg het omdat ik geen komma had ingetoetst
        
        kelvin = input + 273.15; //Kelvin berekenen
        wiegebruiktditbehalveamerika = input * 1.8 + 32; //Fahrenheit berekenen
        System.out.println("> "+ input + "ﾟC = " + kelvin +"K & " + wiegebruiktditbehalveamerika +"ﾟF"); 
        //en uitprinten!
    }
    
    
    public static void opgave4(int a/*ntarctica*/){
        //nog meer penguins :D
        //ik had verwacht dat de ide zou gaan klagen over het stukje wat ik eruit gecomment heb in de header lol
        
        String pygoscelis = ""; //string init
        
        //Exception in thread "main" java.lang.ArithmeticException: / by zero < yessss
        //alleen dan wel in de verkeerde opdracht.
        
        for(int i = 0; i < a; i++){
            
            for(int j = 0; j < i; j++){ //sterretjess
                pygoscelis += "*";
            }
            for(int x = 1; x < a; x++){ //dit zou voor een spatie moeten zorgen
                pygoscelis += " ";
            }
            //pygoscelis += "0"; //kijken wth er mis gaat
            System.out.println(pygoscelis); //en uitprinten
        } //uhhh'kaynvmthisallthen
       
    }
}
