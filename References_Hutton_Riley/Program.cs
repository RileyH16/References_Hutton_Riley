// See https://aka.ms/new-console-template for more information

using References_Hutton_Riley;

//creates a new sedan object and assigns an IAutomobile object to that sedan
Sedan myFirstSedan = new Sedan(0);
IAutomobile myAutmobile = myFirstSedan;

//another new sedan
Sedan myOtherSedan = new Sedan(0);


//calls the speed and prints it to console
myFirstSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutmobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutmobile));

//calls the speed and prints it to console, then compares the two
myOtherSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myOtherSedan.Speed);
Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

Truck myTruck = new Truck(50, 500, "MGR-814");

// Calls stringify method and describes automobiles.
myFirstSedan.Stringify();
myAutmobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();