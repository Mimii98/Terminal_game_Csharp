 using static System.Console;

class Gameloop
{
int Ergebnis {get; set;}
private Player player = new();// Spielerobjekt erstellt // Neue Schreibweiß

//Methoden
 public void Intro() // Die Einleitung ins Spiel
    {
        // Einleitung
        Clear();
        WriteLine("... Loading");
        System.Threading.Thread.Sleep(3000); 
        WriteLine("""Du wachst in einer dunklen Gasse auf.Dein Kopf dröhnt und die Erinnerungen von letzter Nacht kommen dir wieder in den Kopf. Du siehst deine Frau wie sie dich anschreit und Gegenstände nach dir wirft. Sie beschuldigt dich, dass sie fremdgehen musste, weil du ein Versager und Idiot bist der nichts hinbekommt.""");
        System.Threading.Thread.Sleep(1000);
        WriteLine();
        WriteLine("Nun sitzt du da auf dem Boden, im Nassen wie ein Opfer und ohne Hose ᓚᘏᗢ. ");
        
        Auswahl();
        
    }


    public void Auswahl()
    {
        player.Startwerte();
        WriteLine("");
        WriteLine("Rausgehen(1)");
        WriteLine("Schalfen(2)");
        WriteLine("***WÄHLE AUS***: ");
        string? userpick = ReadLine();
        if (int.TryParse(userpick, out int pick))
        {
            //switch(pick)
            {
               // case (1):
                    // Methode mit dem "Raus gehen" Event ausführt
                    //break:

                //case (2):
                    //Methode die "Schlafen" Event ausführt
                    //break;

            }
        }
        
    }


}