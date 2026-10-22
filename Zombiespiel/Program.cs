using System.Threading.Tasks;

namespace Zombiespiel;

class Program
{
    static void Main()
    {
        Console.WriteLine("Take a seat and have fun lol ");
        Console.ReadKey();

    
        
        
        Gamemenu menu = new(); // Neue Schreibweiße um ein Objekt zu erzeugen.
        menu.Mainmenu(); // Hier rufen wir die Menumethode auf damit wir erstmal im Menü landen.

        // Spielloop loop = new();      // Hier wird das Spielloop Objekt erstellt und startet später das Spiel.
    
    }

}
