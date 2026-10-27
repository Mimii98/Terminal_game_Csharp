
class Gameloop
{
// Eigenschaften
public int Day {get; set;}
int Ergebnis {get; set;}
 Player player = new(); // Spielerobjekt erstellt // Neue Schreibweiß


//Methoden
 public void Einleitung() // Die Einleitung ins Spiel
    {
       
        player.Startwerte();
        
        
        // Einleitung
        Console.Clear();
        Console.WriteLine("... Loading");
        System.Threading.Thread.Sleep(2000); 
        Enter();
        Console.Clear();
        System.Console.WriteLine("... Du wachst auf, alles ist noch verschwommen und unklar");
        Enter();
        System.Console.WriteLine("Du setzt dich auf und reibst deine Augen");
        Enter();
        System.Console.WriteLine("Was möchtest du tun ??");
        


        Auswahl();
        


        // kleine Hilfsmethode
        static void Enter()
        {
            System.Console.WriteLine("Press Enter..");
            Console.ReadKey();

        }
    }


    // Noch volle Katastrophe haha :D 
    public void Auswahl()
    {
        System.Console.WriteLine("{0}", Day); // zeigt nur 0, 0, 0 an huh ?
        player.Startwerte();
        System.Console.WriteLine("");
        System.Console.WriteLine("Rausgehen(1)");
        System.Console.WriteLine("Schalfen(2)");
        System.Console.WriteLine("***WÄHLE AUS***: ");
        string? userpick = Console.ReadLine();
        if (int.TryParse(userpick, out int pick));
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



    public void Daycount()
    {
        
        MinusDay();
        Console.WriteLine("{0}", Ergebnis);

        int MinusDay()
        {
            // hier muss nochmal nachgeschaut werden hahahaaha :D 
            int zahl = 1;
            Ergebnis = Day - zahl ;
            Ergebnis = Day;
            if (Day == 0)
            {
                //Spiel vorbei. Das kläre ich später wenn der rest steht. dann kann ich besser sehen wie ich das umsetzen. 
            }
            return Ergebnis;

        }

    }


}