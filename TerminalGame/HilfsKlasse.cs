using static System.Console;

static class Hilfsklasse
{
    public static int NewHunger;
    public static int NewEnergie;


    public static void Zeilenumbruch()
    {
        WriteLine();
        WriteLine();
    }
    public static void Status(Player player)
    {
        WriteLine("Hunger: {0}                      Energie: {1}",player.HungerWert, player.EnergieWert); 
    }

    public static void IsGameover(Player player)
    {
        if ((player.EnergieWert == 0) || (player.HungerWert == 0))  
        {
            
            WriteLine("Du bist gestorben");
            WriteLine("Tage überlebt: {0}", player.Day); // hier soll das Ergebnis von daycount() übergeben werden



        }

    }
}