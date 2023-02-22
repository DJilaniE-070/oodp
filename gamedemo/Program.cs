// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Player player = SuperAdventure.ThePlayer();
        Console.Write("Hello there. Enter your name: ");
        //player.Name = Console.ReadLine() ?? String.Empty;
        player.Name = "john doe";

        Console.WriteLine("Welcome to the world of Super Adventure, " + player.Name + "!");

        Location loc = World.LocationByID(1);
        Console.WriteLine($"You're now at {loc.Name}. You can find the following things here:");
        Console.WriteLine($"{loc.Description}");
        Console.WriteLine($"The following quest is available:");
        if (loc.QuestAvailableHere != null)
        {
            Console.WriteLine($"{loc.QuestAvailableHere.Name}");
            Console.WriteLine($"{loc.QuestAvailableHere.Description}");
        }
        
        Console.WriteLine($"The following monster is available:");
        if (loc.MonsterLivingHere != null)
        {
            Console.WriteLine($"{loc.MonsterLivingHere.Name}");
        }
        
        Console.WriteLine($"{loc.Compass()}");
        
        loc.MoveFromHome();
    }
}


