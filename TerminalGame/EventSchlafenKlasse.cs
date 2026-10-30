using static System.Console;
static class EventSchlafen
{

    public static void Schlafen(Player player)
   {
        Random rnd = new (); int wahl1 = rnd.Next(1,6);

        switch(wahl1)
        {
            case 1:
                Clear();
                WriteLine("""Du suchst dir ein einigermaßen trockenes Plätzchen und machst es dir gemütlich, um zu schlafen""");
                WriteLine("Die Nacht verläuft ohne Zwischenfälle ᓚᘏᗢ");
                Hilfsklasse.Zeilenumbruch();
                WriteLine(" +20 Energie -10 Hunger");
                Hilfsklasse.NewHunger = player.HungerWert - 10;
                player.HungerWert = Hilfsklasse.NewHunger;
                Hilfsklasse.NewEnergie = player.EnergieWert + 20;
                player.EnergieWert = Hilfsklasse.NewEnergie;
                break;

            case 2:
                Clear();
                WriteLine("""Du findest beim Herumstreifen eine offene Scheune und entscheidest dich dafür, die Nacht dort zu verbringen. Das Stroh ist gemütlich und weich und du brauchst nicht lange, um wegzudösen. Allerdings kannst du nicht einschlafen. Da ist so ein Gefühl..... Das Gefühl, beobachtet zu werden. """);
                WriteLine("""Du schaust dich verschlafen um. Dann entdeckst du es!!!""");
                ReadKey();
                System.Threading.Thread.Sleep(1000);
                Clear();
                WriteLine("...");
                Clear();
                System.Threading.Thread.Sleep(1500);
                WriteLine("""
                ⠀⠀⣰⢢⣀⢤⠤⡤⢄⡎⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⢀⠜⠀⢇⢼⣠⠧⠊⠀⠉⠲⡀⠀⠀⠀⣠⠤⠒⠋⠉⠀⠀⠀⠀⠀⠀⠀⠈⠙⠒⠤⡀⠀⠀⠀⠀⠀⠀⠀
                ⢠⢣⠒⠑⢦⠀⢀⠖⠐⢢⡀⠀⠈⢦⠔⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠱⢄⠀⠀⠀⠀⠀
                ⡏⠸⣄⣁⠜⠀⠐⢄⣁⡸⠁⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢣⠀⠀⠀⠀
                ⡇⠀⠀⢀⠦⡤⢼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠇⡀⠀⠀
                ⢇⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠱⠀⠀
                ⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠈⠄⠀
                ⠀⠀⠉⠒⠤⢤⣀⣀⣀⣀⠤⢞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡜⠀⠈⠂
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢱⢀⢀⡘
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠣⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠁⠀⠀⠉⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢱⢦⣄⡇⢠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠴⠃⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠸⡇⡇⢸⠑⠒⠒⠒⠶⠶⣶⢲⡇⢿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡆⡇⡇⢸⠀⠀⠀⠀⠀⠀⢸⢸⡇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⢧⢳⢸⠀⠀⠀⠀⠀⠀⢸⡘⣿⢸⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⠼⠸⠬⠃⠀⠀⠀⠀⠀⠀⠣⠏⢆⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀
                """);
                ReadKey();
                System.Threading.Thread.Sleep(1000);
                WriteLine("Es starrt dich an... Du starrst zurück");
                WriteLine("Sieht ganz schön dumm aus, denkst du dir");
                WriteLine("Du versuchst es zu verschieben, aber es bewegt sich nicht");
                WriteLine("Da es die ganze Nacht komische Geräusche macht, kannst du schlecht schlafen");
                WriteLine("Am nächsten Morgen wirst du von einer Wolke warmen Atems geweckt. Das Pferd starrt dich an und leckt dir quer durchs Gesicht");
                Hilfsklasse.Zeilenumbruch();
                WriteLine("+15 Energie -10 Hunger");
                Hilfsklasse.NewHunger = player.HungerWert - 10;
                player.HungerWert = Hilfsklasse.NewHunger;
                Hilfsklasse.NewEnergie = player.EnergieWert + 15;
                player.EnergieWert = Hilfsklasse.NewEnergie;
                player.DayCount();
                break;

            case 3:
                
                break;

            case 4:
                
                break;
            
            case 5:
                
                break;

            default:
                break;



        }
    } 
}    