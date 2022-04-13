using static System.Console;
using RpgJogo.Models;

WriteLine("\tFinal Fantasy\n");

Knight arus = new Knight("Arus", 12, "Knight");
Wizzard jenica = new Wizzard("Jennica", 10, "White Wizzard");
Villain maleficus = new Villain("Maleficus", 50, "Devil");

WriteLine($"Personagem: {arus}");
WriteLine(arus.Attack());
WriteLine(arus.Attack("espadas", 20));
WriteLine(maleficus.VerificaDanos(arus, maleficus));

WriteLine();
WriteLine($"Personagem: {jenica}");
WriteLine(jenica);
WriteLine(jenica.Attack());
WriteLine(jenica.Attack("fogo"));
WriteLine(maleficus.VerificaDanos(jenica, maleficus));

WriteLine();
