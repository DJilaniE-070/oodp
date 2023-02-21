using gamedemo;

public class Location{
    public string CurrentLocation;
    public int ID;
    public string? Name;
    public string? Description;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    


    public Location(int id, string Name, string Description, Item item, Quest Quest, Monster monster){
        this.ID = id;
        this.Name = Name;
        this.Description = Description;

    }
   
    
    public string Compass(){
         string s = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }
    

    public void MoveFromHome()
    {

    CurrentLocation = "Home";
    var home = World.Locations[0];
    var townSquare = World.Locations[1];
    LocationToNorth = townSquare;
    Console.WriteLine(townSquare.Name);

    Console.WriteLine("You are at: " + home.Name + ".\n " + home.Description);
    Console.WriteLine(Compass());

    Console.WriteLine("Would you like to move? y/n");
    string? answer1 = Console.ReadLine();
    if (answer1 == "y"){
        townSquare.MoveFromTownSquare();

    }
    
    }
    public void MoveFromTownSquare(){
        World.PopulateLocations();
        CurrentLocation = "Townsquare";
        var home = World.Locations[0];
        var farmhouse = World.Locations[5];
        var alchemistHut = World.Locations[3];
        var guardPost = World.Locations[2];
        Console.WriteLine("You are at: " + this.Name + ".\n " + this.Description);
        Console.WriteLine(Compass());
        Console.WriteLine("N/E/S/W?");
        string? answer2 = Console.ReadLine();
        if (answer2	== "N"){
            alchemistHut.MoveFromAlchemistHut();
        }
        else if (answer2 == "E"){
            guardPost.MoveFromGuardpost();
        }

        else if (answer2 == "S"){
            home.MoveFromHome();
        }
        else if (answer2 == "W"){
            farmhouse.MoveFromFarmer();
        }

    }
    public void MoveFromAlchemistHut(){
        World.PopulateLocations();
        CurrentLocation = "Alchemist hut";
        var alchemistsGarden = World.Locations[4];
        var townSquare = World.Locations[1];

        Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
        Console.WriteLine(Compass());
        Console.WriteLine("N/S?");
        string? answer3 = Console.ReadLine();
        if (answer3 == "N"){
            alchemistsGarden.MoveFromAlchemistGarden();
        }
        else if (answer3 == "S"){
            townSquare.MoveFromTownSquare();
        }
    }

    public void MoveFromGuardpost()
    {
        CurrentLocation = "Guard Post";
        var bridge = World.Locations[7];
        var townSquare = World.Locations[1];
        Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
        Console.WriteLine(Compass());
        string? answer6 = Console.ReadLine();
        if (answer6 == "E"){
            bridge.MoveFromBridge();
        }
        else if (answer6 == "W"){
            townSquare.MoveFromTownSquare();
        }
    }

    public void MoveFromBridge(){
        CurrentLocation = "Bridge";
        var guardPost = World.Locations[2];
        var spiderField = World.Locations[8];
        Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
        Console.WriteLine(Compass());
        string? answer7 = Console.ReadLine();
        if (answer7 == "E"){
            spiderField.MoveFromSpiderField();
        }
        else if (answer7 == "W"){
            guardPost.MoveFromGuardpost();
        }
    }


    public void MoveFromSpiderField(){
        CurrentLocation = "Spider Field";
        var bridge = World.Locations[7];
        Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
        Console.WriteLine(Compass());
        string answer8 = Console.ReadLine();
        if (answer8 == "W"){
            bridge.MoveFromBridge();
        }

    }

    public void MoveFromFarmer(){
        var farmersField = World.Locations[6];
        var townSquare = World.Locations[1];
        Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
        Console.WriteLine(Compass());
        Console.WriteLine("W/E");
        string? answer4 = Console.ReadLine();
        if (answer4 == "W"){
            farmersField.MoveFromFarmersfield();
        }
        if (answer4 == "E"){
            townSquare.MoveFromTownSquare();
        }

    }

    public void MoveFromFarmersfield(){
        var farmhouse = World.Locations[5];
        Console.WriteLine("You are at: " + this.Name + "\n" + this.Description);
        Console.WriteLine(Compass());
        string? answer5 = Console.ReadLine();
        if (answer5 == "E"){
            farmhouse.MoveFromFarmer();
        }

    }


    
   public void MoveFromAlchemistGarden(){
    var alchemistHut = World.Locations[3];
    Console.WriteLine("You are at: " + this.Name + ".\n" + this.Description);
    Console.WriteLine(Compass());
    Console.WriteLine("S");
    string? answer4 = Console.ReadLine();
    if (answer4 == "S"){
        alchemistHut.MoveFromAlchemistHut();
    }


   }

}
