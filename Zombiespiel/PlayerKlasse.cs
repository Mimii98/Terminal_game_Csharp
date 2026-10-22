
class Player
{  
    // Eigenschaften
    

    public int Hunger_wert { get; set; }
    public int Energie_wert { get; set; }


    public void Startwerte()
    {
        
        Hunger_wert = 20;
        Energie_wert = 20;

        Console.WriteLine("Hunger:{0}", Hunger_wert);
        Console.WriteLine("Energie:{0}", Energie_wert);

    }


    





}