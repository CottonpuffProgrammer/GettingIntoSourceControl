Console.WriteLine("This program will ask for your input for multiple questions.");
Console.WriteLine("Please type your name: ");
Console.WriteLine("");

string name;
string yesno;
string age;

name = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("Is today your birthday?");
Console.WriteLine("");

yesno = Console.ReadLine();

Console.WriteLine("");
if (yesno == "yes")
{
    Console.WriteLine("Happy Birthday!");
    Console.WriteLine("How old will you be?");
} else if (yesno == "no")
{
    Console.WriteLine("Awww...");
    Console.WriteLine("Well, how old would you be if it was your birthday?");
} else
{
    Console.WriteLine("I didn't get a yes or no, I am a simple program and thus do not understand your input, however...");
    Console.WriteLine("How old would you be if it was your birthday?");
}
Console.WriteLine("");

age = Console.ReadLine();

Console.WriteLine("Neat! That is all this program has to ask.");