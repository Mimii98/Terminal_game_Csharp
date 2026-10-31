 using static System.Console;

class Player
{  
    // Eigenschaften ( Eigenschaften sind dauerhaft im Speicher und werden nicht direkt gelöscht wenn sie nicht mehr gebraucht wird wie Methodenvariablen)
    // Jedenfalls solange das Objekt existiert :D
    public int HungerWert { get; set; } 
    public int EnergieWert { get; set; }
    public bool HatHose { get; set; }
    public int Day { get; set; }


    public int DayCount()
    {
        
        int ergebnis;

        ergebnis = 1 + Day;
        Day = ergebnis;

        return Day;

    }

}