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
			//Opdracht3();
			//Opdracht6();
		}
		
		public static void Opdracht3()
		{
			Random birb = new Random(); //random erbij halen
			int rn = birb.Next(1, 7);
			//Console.WriteLine(rn); 
			//ff kijken of ik het goed doe
			
			switch (rn)
			{ //gelukkig werkt het hetzelfde als in java~
				case 1:
				case 6:
					Console.WriteLine(rn + "\nGRENS"); //copypasta zinnen uit opdrachten txt
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
		
		public static void Opdracht6()
		{
			//ik weet zeker dat ik al eens een keer eerder zoiets had moeten maken voor school
			//this is why you should keep the code you have written, sushi aerjfkdjslkfj

			//ik zou alles in een list kunnen zetten en dat weer uit printen in de console...
			//!! c# heeft ook een var , werkt alleen niet hetzelfde als in js tho but hey if it works

			string input; //voor readline
            int per;
            string naam;
            int leeftijd;
			var lijstje = new Dictionary<string, int>(); //dict aanroepen, key + value = naam , leeftijd

            //nvm dictionary is beter, waarom wou ik voor een arraylist gaan.
            //"van een groep mensen", hhhhh dat kan alles zijn
			
			Console.WriteLine("* > hoeveel personen?"); //oke dn vragen we toch eerst hoeveel er zijn
            Console.Write("*"); //for teh lulz
            input = Console.ReadLine(); //input inlezen
			
			while (!Int32.TryParse(input, out per)) //kijken of er wel een cijfer is ingevoerd, dan convert naar int
			{
				Console.WriteLine("*> geen getal ingevoerd!");
				input = Console.ReadLine();
            }

			for (int i = 0; i < per; i++) //blijft vragen afhankelijk van hoeveel personen
			{
				Console.WriteLine("* > voer een naam in: ");
				Console.Write("*");
				naam = Console.ReadLine(); 

				Console.WriteLine("* > voer de leeftijd van " + naam + " in: ");
				Console.Write("*");
				input = Console.ReadLine();

				while (!Int32.TryParse(input, out leeftijd)) //...copypasta
				{
					Console.WriteLine("*> geen getal ingevoerd!");
					input = Console.ReadLine();
                }
				
				lijstje.Add(naam, leeftijd);
				//Console.WriteLine("* >" + naam + ", " + leeftijd); //test
			}
			
			foreach(var inv in lijstje) //foreach omdat ik alleen gare posities in memory terug kreeg
			{
				//Console.WriteLine("Naam : {0}, Leeftijd: {1}", inv.Key, inv.Value); //test

				if (inv.Value > 18)
				{
					Console.WriteLine("{0}, wel", inv.Key);
				}
				else
                {
					Console.WriteLine("{0}, niet", inv.Key);
				}
			}
			
            //Console.ReadKey(); //omdat het irritant is dat de console elke keer quit als de programma done is.
		}
	}
}
