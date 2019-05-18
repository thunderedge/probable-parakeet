package hwdingetje;

import java.util.Scanner;

/**
 *
 * @author adeliae
 */

public class HwDingetje {

    public static void main(String[] args) {
        opgave1();
        //opgave2();
    }
    
    public static void opgave1(){
        //met maar één printline huh?
        //System.out.println("*\n**\n***\n****\n*****"); //Щ(･｀ω´･Щ)
        //jkjk
        //looooooooooooooooooooooooooooooooooooooooooooop:
        for(int i = 0; i < 5; i++){
           for(int j = 0; j < 4; j++){
               //print zooi uit.
           } 
        }
    }
    
    public static void opgave2(){
        //TO INFINITY AND BEYOOOOOOOOOOOOOOOOOOOOND ﾟ+.(ﾉ｡'▽')ﾉ*.ｵｵｫｫ☆ﾟ･:*☆
        //i'll keep this joke running.
        
        double kelvin = 273.15; //celsius + < wat daar staat.
        int wiegebruiktditbehalveamerika = 0; //celsius * 1.8 + 32
        //aah okay ik had de opdracht beter moeten lezen, convert van celsius naar fahrenheit/kevin!
        
        Scanner mcScanFace = new Scanner(System.in); //scanner aanroepen omdat we user input nodig hebben
        //nee fuck updates, stop windhoos
        
        //uh ja het zou helpen als je ook iets in de console laat zien zodat de gebruiker ook weet wat ie moet doen.
        System.out.println("> enter zooi");
        System.out.print("* "); //just to be extra fancy
        
        double input = mcScanFace.nextDouble(); //inputmismatchexception? really?? waar is de mismatch???
        //nvm, kreeg het omdat ik geen komma had ingetoetst
        //System.out.println(input); 
    }
}
