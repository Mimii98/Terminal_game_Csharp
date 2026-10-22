

using System.Security.Cryptography;

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
        System.Console.WriteLine("... Du wachst auf, alles ist noch verschwommen und unklar");
        Enter();
        System.Console.WriteLine("Du setzt dich auf und reibst deine Augen");
        Enter();
        System.Console.WriteLine("Was möchtest du tun ??");
        


        // hier neuer Methodenaufruf









        // kleine Hilfsmethode
        static void Enter()
        {
            System.Console.WriteLine("Press Enter..");
            Console.ReadKey();

        }
    }



    public void Auswahl()
    {
        System.Console.WriteLine("{0}", Day);
        player.Startwerte();
        
    }



    public void Daycount()
    {
        
        MinusDay();
        Console.WriteLine("{0}", Ergebnis);

        int MinusDay()
        {
            
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