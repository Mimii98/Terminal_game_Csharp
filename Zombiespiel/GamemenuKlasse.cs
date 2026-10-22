

using System.Xml;

class Gamemenu
{
    // Eigenschaften
    
    public ConsoleKeyInfo Input {get; set;} // hier wird die Tasteneingabe gespeichert


    // Methoden
     public void Mainmenu()
    { 
        Console.Clear();
        Gameloop Loop = new(); // Erstellen eines GameLoop Objekts damit ich Methoden aus der Klasse nutzen kann. 
        Console.WriteLine("Starten(1)");
        Console.WriteLine("Anleitung(2)");
        Console.WriteLine("Beenden(3)");

        while (true)
        {
            Console.Write("Gebe eine Zahl ein: ");
            string? userinput = Console.ReadLine(); // hier wird der string gespeichert 
            if (int.TryParse(userinput, out int auswahl)) // falls es umwandelbar ist wird true zurückgegeben und der String wird in einen int umgewandelt
            // wenn nciht true dann wird der if block übersprungen. 
            {
                switch(auswahl)
                {
                    case (1):
                        Loop.Einleitung();
                        break;
                        
                    case (2):
                        Anleitung();
                        break;

                    case (3):
                        Beenden();
                        break;
                        
                    default:
                        break;
                            
                }  
                break;
            }
            else 
            {
                Console.WriteLine("Ungültige Eingabe!");
                Console.Clear();
                break;
            }       

        }
        
    }
    public void Anleitung()  // Die optionale Spieleanleitug
    {
        Console.WriteLine(" Du Spielst einen Überlebenden in einem viel zu kleinen Bunker und musst ums überleben kämpfen.");
        Console.WriteLine(" Am Anfange des Spiels hast du 20 Sättigung und 20 Energie. Eine Aktion kostet einen ganzen Tag. Du hast die Wahl zwischen raus gehen oder schlafen. Schlaf füllt deine Energie auf und rausgehen deinen Hunger. Rausgehen ist wohl das interessanteste. aber auch die teuerste Aktion. Behalte deine Werte gut im Blick. Möglicherweiße triffst du auf einen anderen überlebenden oder Zombie und musst kämpfen. Kämpfen kostet Energie.Für jeden Hit -5");
        Console.WriteLine();
        Console.WriteLine("Tipp! Überall sind Katzen versteckt :3");

        while (true)
        {
            
            Console.WriteLine("Drücke Esc");
            Input = Console.ReadKey();
            if (Input.Key is ConsoleKey.Escape)
            {   
                Console.Clear();
                break;
        
            }
            break;
        }    
        
    }
    
    public void Beenden()
    {
    Console.Write("Möchtest du das Spiel beenden?(y/n): ");
    string? eingabe = Console.ReadLine();

        while (true)
        {

            if (eingabe == ("y"))
            {
                Console.WriteLine("ᓚᘏᗢ");
                Environment.Exit(0);
            }
            else if ( eingabe == ("n"))
            {
                break;
            }
            else // ein vielleicht case gibts noch nicht. vielleicht durch einen switchblock ersetz en
            {
                Console.WriteLine("Eingabe ungültig");
                break;
            }
            break;
        }
        
    }

   
    

}