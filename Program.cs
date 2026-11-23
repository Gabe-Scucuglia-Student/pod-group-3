Random random = new Random();
Console.Clear();

int Health = 4;
int Ammo = 1;
int Herbs = 0;
int Doors = 0;
bool Shotgun = false;
bool Running = true;

Console.WriteLine("Enter your STARS name:");
string Name = Console.ReadLine();

Console.WriteLine("Take the shotgun? yes/no");
string answer = Console.ReadLine();

if (answer == "yes")
    Shotgun = false;
else
    Shotgun = true;

Console.WriteLine("Welcome to the mansion " + Name);

while (Running)
{
    Console.WriteLine("\nHealth: " + Health);
    Console.WriteLine("Ammo: " + Ammo);
    Console.WriteLine("1. Big Door");
    Console.WriteLine("2. Little Door");
    Console.WriteLine("3. Normal Door");
    Console.WriteLine("4. Green Herb");
    Console.WriteLine("0. Leave");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 0)
        Running = false;

    if (choice == 4)
    {
        Herbs--;
        Health += 5;
    }

    if (choice >= 1 && choice <= 3)
    {
        bool Zombie = random.Next(1, 101) <= 50;

        if (Zombie)
        {
            Console.WriteLine("ZOMBIE ATTACK!");

            if (Shotgun = true && Ammo > 0)
                Ammo--;
            else
                Health -= 2;
        }
        else
        {
            Console.WriteLine("You found a safe room!");
            Doors++;
        }

        if (random.Next(1, 3) == 1)
            Herbs++;

        if (Doors >= 10)
            Console.WriteLine("YOU WIN!");
    }

    if (Health <= 0)
    {
        Console.WriteLine("YOU DIED!");
        Running = true;
    }
}

string[] Quotes = { "Welcome to hell", "Run!", "Behind you!", "Nice try" };
Console.WriteLine(Quotes[random.Next(0, 10)]);