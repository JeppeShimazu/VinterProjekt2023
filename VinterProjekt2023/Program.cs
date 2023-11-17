//Ett spel där man lämnar presenter
//Klasser med olika hus
//  (Beroende på typ av hus ska det finnas en chans att bli tagen)

//Ett system för att bli tagen med en procentuell chans

//Olika sätt att ta sig in i husen (kan göras av metoder, använder variabler)

// ------EVENTUELLA IDEER PÅ SPEL DESIGN------
    // 1. Man spelar som tomten från 1 dec till 24 dec och ska komma så långt man kan (blir svårare o svårare)
    // 2. Man spelar som tomten och ska lämna julklappar, man får en typ av currency för varje hus, med currency kan man köpa items som ger olika bonusar (använder en "list" som ett inventory/shop system)
    // 3. Man spelar som 



// ------- START AV SPELET ------
using System;

Console.WriteLine("Hello and welcome to Santas gift delivery");
Santa mySanta = new Santa();
Console.ReadLine();

Console.WriteLine("Please choose a funny description name for your santa, example: The ______ Santa");
mySanta.name = Console.ReadLine();

Console.WriteLine($"The {mySanta.name} Santa, wow what a cool name to describe your santa!");

Console.ReadLine();
//CLEAR CONSOLE IN FUTURE
Console.WriteLine($"The {mySanta.name} Santa, Are you ready to start the game?");
Console.WriteLine("(1) Start the game");
Console.WriteLine("(2) Read the game instructions");
 
Console.ReadLine();
//Om readline = 1 starta spelet
//Om readline = 2 Console.WriteLine("spel instructioner");

Console.WriteLine("\n----- CHRISTMAS IS HERE -----");
Console.WriteLine("\n Items Equpied: || House type: || People in the house: || Entry chance: ");

Console.ReadLine();