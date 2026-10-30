 using static System.Console;

class Gameloop
{
int Ergebnis {get; set;}
private Player player = new();// Spielerobjekt erstellt // Neue Schreibweise


//Methoden
 public void Intro() // Die Einleitung ins Spiel
    {
        // Einleitung
        Clear();
        WriteLine("... Loading");
        System.Threading.Thread.Sleep(2000); 
        WriteLine("""Du wachst in einer dunklen Gasse auf. Dein Kopf dröhnt und die Erinnerungen von letzter Nacht kommen dir wieder in den Kopf. Du siehst deine Frau wie sie dich anschreit und Gegenstände nach dir wirft. Sie beschuldigt dich, dass sie fremdgehen musste, weil du ein Versager und Idiot bist, der nichts hinbekommt.""");
        System.Threading.Thread.Sleep(1000);
        WriteLine();
        WriteLine("Nun sitzt du da auf dem Boden, im Nassen wie ein Opfer und überhaupt.... wo ist deine Hose. ");
        ReadKey();
        Hilfsklasse.Zeilenumbruch();
        player.HungerWert = 50;
        player.EnergieWert = 50;
        Auswahl();
        
    }


    public void Auswahl()
    {
        while (true)
        {   
            ReadKey();
            Clear();
            WriteLine("{0}",player.Day);
            Hilfsklasse.Status(player);
            WriteLine("");
            WriteLine("Rumlungern(1)");
            WriteLine("Essen suchen(2)");
            WriteLine("Schlafen(3)");
            WriteLine("***WÄHLE AUS***");          
            string? userpick = ReadLine();
        
            
                if (int.TryParse(userpick, out int pick))
                {

                    switch(pick)
                    {
                    case (1):
                            EventKlasse.Stromern(player);
                            break;

                    case (2):
                            EventKlasse.EssenSuchen(player);
                            break;
                        
                    case (3):
                            EventKlasse.Schlafen(player);
                            break;


                    }
                    Hilfsklasse.IsGameover(player);
                    player.DayCount();
                    
                
                
                }
                
        }
        
        
    }


}