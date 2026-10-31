using static System.Console;


class EventHosenSuche
{
    
    public void Hosensuche(Player player)
    {
        //erst wird ein Zufallscase ausgewählt:
        Random rnd = new (); int wahl = rnd.Next(1,100);

        //Dann wird der passende case ausgeführt
        switch(wahl)
        {
            case <= 50:
                Clear();
                WriteLine("""Du stromerst herum und durchsuchst ein paar Mülleimer, bis dir auffällt, dass du von einer Gruppe halbstarker Teenager umzingelt wirst. Du merkst schnell, dass sie ein Problem mit dir haben. Wird wohl an der fehlenden Hose liegen. Sie packen alle ihren mitgebrachten Baseballschläger aus und greifen dich an. Du hast keine Chance.""");
                Hilfsklasse.Zeilenumbruch();
                WriteLine("- 20 Energie");
                WriteLine("");
                Hilfsklasse.NewEnergie = player.EnergieWert - 20;
                player.EnergieWert = Hilfsklasse.NewEnergie;
                Hilfsklasse.Status(player);
                Hilfsklasse.IsGameover(player);
                WriteLine("{0}",player.Day);
                player.HatHose = false;
                break;



            case >= 30:
                Clear();
                WriteLine("""Du findest ein Stück Schokolade""");
                Hilfsklasse.NewHunger = player.HungerWert + 5;
                player.HungerWert = Hilfsklasse.NewHunger;
                WriteLine("+ 5 Hunger");
                Hilfsklasse.Status(player);
                player.HatHose = false;
                break;



        }

    }   
}
   
    