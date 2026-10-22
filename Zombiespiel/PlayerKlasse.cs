
class Player
{  
    // Eigenschaften
    

    public int Hunger_wert { get; set; }
    public int Energie_wert { get; set; }


    public void Hunger()
    {
        
        Hunger_wert = 20;
        

    }

    public void Energie()
    {
        Energie_wert = 20;

    }


    // Hilfsmethode
    public void Startwerte()
        {
            System.Console.WriteLine("{0}", Hunger_wert);
            System.Console.WriteLine("{0}", Energie_wert);
        }


    





}