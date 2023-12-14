using System;

Console.WriteLine("Hello and welcome to Santas gift delivery");
Santa mySanta = new Santa();
Mansion mansion = new();
Villa villa = new();
Apartment apartment = new();
Cabin cabin = new();

//Bool för att bli catchad eller inte
bool caught = false;
int gifts = 0;

Console.ReadLine();

Console.WriteLine("Please choose a funny description name for your santa, example: The ______ Santa");
mySanta.name = Console.ReadLine();

Console.WriteLine($"The {mySanta.name} Santa, wow what a cool name to describe your santa!");

Console.ReadLine();
//CLEAR CONSOLE IN FUTURE
Console.WriteLine($"The {mySanta.name} Santa, Are you ready to start the game?");
Console.WriteLine("(1) Read game instructions");
Console.WriteLine("(2) Start the game");

//Start of trying to add instructions or start

string a = ReglerYesNo("");

if (a == "1")
{
    Console.WriteLine("In this game you will be entering houses, you need to get to 24 successful deliveries, you will have the choice to enter differet houses with a different amount of people in them, the more people the bigger the risk of getting caught, but successfully delivering to a large house will also grant a bigger reward, press again to start the game!");
}
if (a == "2")
{
    Console.WriteLine("MERRY CHRISTMAS! LETS GO!");
}

static string ReglerYesNo(string QuestionText)
{
    Console.WriteLine(QuestionText);
    Console.WriteLine("[1/2]");

    string anwser = Console.ReadLine();


    return anwser;
}

//End of trying to add instructions or start

Console.ReadLine();
//Om readline = 1 starta spelet
//Om readline = 2 Console.WriteLine("spel instructioner");

while (caught == false)
{

Console.WriteLine("Please choose what house to deliver gifts to:");
//START OF TEST ADDITION
string b = TypeOfHouse("");

House myHouse = new House();

int Detection = 0;
string entry = "";

if (b == "1")
{
    Console.WriteLine("You have chosen to enter a Cabin!");
    myHouse.Type = "Cabin";
    cabin.CabinPeople();
    entry = "1/10";

        int randomNumber = Random.Shared.Next(1, 11);
        Detection = randomNumber;
        if (Detection >= 2)
        {
        caught = false;
        }
        if (Detection < 2)
        {caught = true;}
}

if (b == "2")
{
    Console.WriteLine("You have chosen to enter an Apartment!");
    myHouse.Type = "Apartment";
    apartment.ApartmentPeople();
    entry = "1/8";

        int randomNumber = Random.Shared.Next(1, 9);
        Detection = randomNumber;
        if (Detection >= 2)
        {
        caught = false;
        }
        else if (Detection < 2)
        {caught = true;}

}
if (b == "3")
{
    Console.WriteLine("You have chosen to enter a Villa!");
    myHouse.Type = "Villa";
    villa.VillaPeople();
    entry = "1/6";
        int randomNumber = Random.Shared.Next(1, 7);
        Detection = randomNumber;
        if (Detection >= 2)
        {
        caught = false;
        }
        else if (Detection < 2)
        {caught = true;}

}
if (b == "4")
{
    Console.WriteLine("You have chosen to enter a Mansion!");
    myHouse.Type = "Mansion";
    mansion.MansionPeople();
    entry = "1/4";
        int randomNumber = Random.Shared.Next(1, 5);
        Detection = randomNumber;
        if (Detection >= 2)
        {
        caught = false;
        }
        else if (Detection < 2)
        {caught = true;}

}

static string TypeOfHouse(string BuildingQuestion)
{
    Console.WriteLine(BuildingQuestion);
    Console.WriteLine("[1 Cabin] (SAFE)");
    Console.WriteLine("[2 Apartment] (LESS SAFE)");
    Console.WriteLine("[3 Villa](ON THE DANGEROUS SIDE)");
    Console.WriteLine("[4 Mansion](RISKY)");
    string anwser = Console.ReadLine();

    return anwser;
}
//END OF TEST ADDITION
Console.ReadLine();
gifts += House.People;

Console.WriteLine("\n----- CHRISTMAS IS HERE -----");
Console.WriteLine($"\n Santa Name: The {mySanta.name} Santa || House type: {myHouse.Type} || People in the house: {House.People} || Detection Chance: {entry} ||");
Console.WriteLine($" Presents delivered {gifts}/24");
Console.ReadLine();

if (gifts >= 24)
{
Console.WriteLine($"Congrats The {mySanta.name} Santa! You successfully delivered the last 24 gifts in time for Christmas!!!");
Console.ReadLine();
Environment.Exit(0);
}

}

if (caught == true) 
{
Console.WriteLine($"The {mySanta.name} Santa was caught...");
Console.ReadLine();
Environment.Exit(0);
}

Console.ReadLine();