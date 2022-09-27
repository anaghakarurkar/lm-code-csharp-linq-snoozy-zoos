using SnoozyZoos.Models;

Console.WriteLine("Welcome to the Zookeeper's Zoo Analysis 🦁!");

Console.WriteLine("***********************************************");

// List of zooAnimals

List<ZooAnimal> zooAnimals = new()
{
    new Kangeroo("Kanga", "brown", 3, Location.Outback),
    new Penguin("Pingu", "grey", 8, Location.BirdSafari),
    new Sloth("Slothy", "ash brown", 10, Location.AnimalAdventure),
    new Penguin("Pinga", "grey", 6, Location.BirdSafari),
    new Sloth("Slotha", "ash brown", 9, Location.AnimalAdventure),
    new Cobra("Dina", "black", 4, Location.ReptileHouse),
    new Sloth("Slothu", "ash brown", 11, Location.AnimalAdventure),
    new Tiger("Jiba", "stripy orange", 12, Location.TigerTerritory),
    new Tiger("Cuddles", "stripy orange", 4, Location.TigerTerritory),
    new Kangeroo("Amber", "brown", 2, Location.Outback),
    new Penguin("Wheezy", "grey", 7, Location.BirdSafari),
    new Penguin("Mumble", "grey", 11, Location.BirdSafari),
    new Kangeroo("Dave", "brown", 3, Location.Outback),
    new Cobra("Asmodeus", "black", 11, Location.ReptileHouse),
};

Console.WriteLine("Challenge 1");
Console.WriteLine("***********************************************");

var challengeOneZooAnimals = from animal in zooAnimals
                             where animal.Age > 3 && animal.Age < 8
                             select animal;

foreach (var zooAnimal in challengeOneZooAnimals)
{
    Console.WriteLine($"{zooAnimal.Name}, {zooAnimal.Age}");
}


Console.WriteLine("***********************************************");
Console.WriteLine("Challenge 2");
Console.WriteLine("***********************************************");

var challengeTwoZooAnimals = from animal in zooAnimals
                             where animal.Name.Length >= 6
                             select animal;

foreach (var zooAnimal in challengeTwoZooAnimals)
{
    Console.WriteLine($"{zooAnimal.Name.ToUpper()}");
}


Console.WriteLine("***********************************************");
Console.WriteLine("Challenge 3");
Console.WriteLine("***********************************************");

var challengeThreeZooAnimals = from animal in zooAnimals
                               orderby animal.Age descending
                               select animal;

foreach (var zooAnimal in challengeThreeZooAnimals)
{
    Console.WriteLine($"{zooAnimal.Name}, {zooAnimal.Age}");
}


Console.WriteLine("***********************************************");
Console.WriteLine("Challenge 4");
Console.WriteLine("***********************************************");

var challengeFourZooAnimals = from animal in zooAnimals
                              orderby animal.Location
                              group animal by animal.Location;


foreach (var zooAnimal in challengeFourZooAnimals)
{
    Console.WriteLine($"Zoo location is: {zooAnimal.Key}");
    foreach (var animal in zooAnimal)
    {
        Console.WriteLine($"\tHello, my name is {animal.Name}");
    }
}
Console.WriteLine("***********************************************");
