Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();
if(userChoice != "out")
{ PrintHello(); }
else
{ PrintGoodBye(); }

static void PrintHello()
{ Console.WriteLine("Hello, world"); }

static void PrintGoodBye()
{ Console.WriteLine("See you later, aligator."); }
