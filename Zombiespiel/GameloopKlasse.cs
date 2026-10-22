

class Gameloop
{
// Eigenschaften
public int Day {get; set;}
int Ergebnis {get; set;}

//Methoden
 public void MainLoop() // Die eigentliche Spiellogik
    {
        Player player = new(); // Spielerobjekt erstellt // Neue Schreibweiße!
        Day = 7;
        
        
        // Einleitung
        Console.Clear();
        Console.WriteLine("... Loading");

        System.Threading.Thread.Sleep(1500); 
        System.Console.WriteLine("Drücke enter..");
        Console.ReadKey();
        System.Console.WriteLine("... Du wachst auf, alles ist noch verschwommen und unklar");
        Enter();
        System.Console.WriteLine("Du setzt dich auf und reibst deine Augen");
        Enter();
        System.Console.WriteLine("");
        System.Console.WriteLine("Uff, schon wieder ein neuer Tag, Zeit um raus zu gehen");
        
        while (true)
        {
            
            
            //gerade leer



        }
        static void Enter()
        {
            System.Console.WriteLine("Enter");
            Console.ReadKey();

        }
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