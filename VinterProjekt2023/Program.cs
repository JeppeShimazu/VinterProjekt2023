//Ett spel där man lämnar presenter
//Klasser med olika hus
//  (Beroende på typ av hus ska det finnas en chans att bli tagen)

//Ett system för att bli tagen med en procentuell chans

//Olika sätt att ta sig in i husen (kan göras av metoder, använder variabler)

// ------EVENTUELLA IDEER PÅ SPEL DESIGN------
// 1. Man spelar som tomten från 1 dec till 24 dec och ska komma så långt man kan (blir svårare o svårare)
// 2. Man spelar som tomten och ska lämna julklappar, man får en typ av currency för varje hus, med currency kan man köpa items som ger olika bonusar (använder en "list" som ett inventory/shop system)
// 3. Man spelar som...



// ------- START AV SPELET ------
using System;

Console.WriteLine("Hello and welcome to Santas gift delivery");
Santa mySanta = new Santa();
Mansion mansion = new();
Villa villa = new();
Apartment apartment = new();
Cabin cabin = new();

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

Console.WriteLine("Please choose what house to deliver gifts to:");
//START OF TEST ADDITION
string b = TypeOfHouse("");

House myHouse = new House();


if (b == "1")
{
    Console.WriteLine("You have chosen to enter a Cabin!");
    myHouse.Type = "Cabin";
    cabin.CabinPeople();
}
if (b == "2")
{
    Console.WriteLine("You have chosen to enter an Apartment!");
    myHouse.Type = "Apartment";
    apartment.ApartmentPeople();
}
if (b == "3")
{
    Console.WriteLine("You have chosen to enter a Villa!");
    myHouse.Type = "Villa";
    villa.VillaPeople();
}
if (b == "4")
{
    Console.WriteLine("You have chosen to enter a Mansion!");
    myHouse.Type = "Mansion";
    mansion.MansionPeople();

}

static string TypeOfHouse(string BuildingQuestion)
{
    Console.WriteLine(BuildingQuestion);
    Console.WriteLine("[1 Cabin]");
    Console.WriteLine("[2 Apartment]");
    Console.WriteLine("[3 Villa]");
    Console.WriteLine("[4 Mansion]");
    string anwser = Console.ReadLine();

    return anwser;
}
//END OF TEST ADDITION
Console.ReadLine();

//Generate detection
int Detection = 0;
if (House.People < 3)
{
        int randomNumber = Random.Shared.Next(1, 11);
        Detection = randomNumber;
}



Console.WriteLine("\n----- CHRISTMAS IS HERE -----");
Console.WriteLine($"\n Santa Name: The {mySanta.name} Santa || House type: {myHouse.Type} || People in the house: {House.People} || Detection Chance:  ");

Console.ReadLine();