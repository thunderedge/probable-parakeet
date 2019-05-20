using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World"); < thx repl.it
    
    //brainfart.
    
    Random birb = new Random(); //random erbij halen
    int rn = birb.Next(1,7);
    //Console.WriteLine(rn); //ff kijken of ik het goed doe

    switch(rn){ //gelukkig werkt het hetzelfde als in java~
      case 1:
      case 6:
        Console.WriteLine(rn + "\nGRENS"); //copypasta uit opdrachtding
        break;
      case 2:
        Console.WriteLine(rn + "\nHet is even.");
        break;
      case 3:
        Console.WriteLine(rn + "\nHet is oneven.");
        break;
      case 4:
        Console.WriteLine(rn + "\nHet is even.");
        break;
      case 5:
        Console.WriteLine(rn + "\nHet is oneven.");
        break;      
    }
  }
}
