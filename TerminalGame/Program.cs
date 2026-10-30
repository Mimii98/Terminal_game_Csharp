using static System.Console;

namespace Zombiespiel;

class Program
{
    static void Main()
    {
        WriteLine("Take a seat and have fun lol ");
        ReadKey();
        
        Gamemenu menu = new(); // Neue Schreibweise um ein Objekt zu erzeugen.
        menu.Mainmenu(); // Hier rufen wir die Menümethode auf, damit wir erstmal im Menü landen.

    }

}
