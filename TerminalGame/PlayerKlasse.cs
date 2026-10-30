 using static System.Console;

class Player
{  
    // Eigenschaften
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