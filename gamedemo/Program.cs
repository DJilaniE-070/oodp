// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Player player = SuperAdventure.ThePlayer();
        Console.Write("Hello there. Enter your name: ");
        player.Name = Console.ReadLine() ?? String.Empty;

        Console.WriteLine("Welcome to the world of Super Adventure, " + player.Name + "!");

        Location loc = World.LocationByID(1);
        Console.WriteLine(loc.Name);
    }
}


