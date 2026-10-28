 using static System.Console;

class Player
{  
    // Eigenschaften
    
    
    public int Hunger_wert { get; set; }
    public int Energie_wert { get; set; }


    public void Hunger()
    {
        
        Hunger_wert = 50;
        

    }

    public void Energie()
    {
        Energie_wert = 50;

    }


    // Hilfsmethode
    public void Startwerte()
        {
            WriteLine("""Hunger:{0}    Energie{1}""", Hunger_wert, Energie_wert);
        }


    





}