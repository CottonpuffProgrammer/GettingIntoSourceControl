Console.WriteLine("This program will ask for multiple inputs for multiple questions.");
Console.WriteLine("Please type your name: ");

string name;
string yesno;

name = Console.ReadLine();

Console.WriteLine("Hello " + name + "!");
Console.WriteLine("Is today your birthday?");

yesno = Console.ReadLine();

if (yesno == "yes")
{
    Console.WriteLine("Happy Birthday!");
} else if (yesno == "no")
{
    Console.WriteLine("Awww...");
} else
{
    Console.WriteLine("I didn't get a yes or no, I am a simple program and thus do not understand your input.");
}