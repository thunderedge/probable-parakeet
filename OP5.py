from datetime import * #< ssshhhh ik that i should be more specific w/ my imports

#laten we de docs erbij halen want ik heb geen idee waar ik moet beginnen
#heh notes: Division by 0 raises ZeroDivisionError. mijn fav error/exception :D

#dit is tenminste wat overzichterlijker dan de hele switch statement in de vorige versie
#what was i even doing
#ik heb een counter nodig voor elke x dat ik // typte voor een comment, jeez

uur = datetime.now().hour #hebben we nodig om de opdracht te maken
panda = input(">> Voer je naam in. \n * : ") #vraag om naam

if uur >= 6 and uur <= 11:
    print(">> Goedemorgen, " + panda + ".") #greet
elif uur >= 12 and uur <= 17:
    print(">> Goedemiddag, " + panda + ".")
else:
    print(">> Goedenavond, " + panda + ".")
