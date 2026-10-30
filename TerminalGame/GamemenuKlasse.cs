 using static System.Console;

// Fertig so


class Gamemenu
{
    // Eigenschaften
    
    public ConsoleKeyInfo Input {get; set;} // hier wird die Tasteneingabe gespeichert


    // Methoden
     public void Mainmenu()
    { 
        Clear();
        Gameloop Loop = new(); // Erstellen eines GameLoop-Objekts, damit ich Methoden aus der Klasse nutzen kann. 
        WriteLine("Starten(1)");
        WriteLine("Anleitung(2)");
        WriteLine("Beenden(3)");

        while (true)
        {
            WriteLine("***WÄHLE AUS***");
            string? userinput = ReadLine(); // hier wird der string gespeichert 
            if (int.TryParse(userinput, out int auswahl)) // falls es umwandelbar ist, wird true zurückgegeben und der String wird in einen int umgewandelt
            // wenn nicht true, dann wird der if-Block übersprungen. 
            {
                switch(auswahl)
                {
                    case (1):
                        Loop.Intro();
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
                WriteLine("Ungültige Eingabe!");
                Clear();
                break;
            }       

        }
        
    }
    public void Anleitung()  // Die optionale Spielanleitung
    {
        WriteLine("Ziel des Spiels:");
        WriteLine("Ziel ist es, deine Hose wiederzufinden. Erst dann bist du bereit, dich um einen Job und um eine Bleibe zu kümmern. Ohne Hose nimmt dich doch keiner ernst, Bruder");
        Hilfsklasse.Zeilenumbruch();


        while (true)
        {
            
            WriteLine("Drücke Esc");
            Input = ReadKey();
            if (Input.Key is ConsoleKey.Escape)
            {   
                Clear();
                break;
        
            }
            break;
        }    
        
    }
    


    public void Beenden()
    {
    Write("Möchtest du das Spiel beenden?(y/n): ");
    string? eingabe = ReadLine();

        while (true)
        {

            if (eingabe == ("y"))
            {
                WriteLine("ᓚᘏᗢ");
                Environment.Exit(0);
            }
            else if ( eingabe == ("n"))
            {
                break;
            }
            else
            {
                WriteLine("Eingabe ungültig");
                break;
            }
            break;
        }
        
    }

}