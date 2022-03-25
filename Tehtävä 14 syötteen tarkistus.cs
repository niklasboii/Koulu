Console.WriteLine("Tehtävä 14 (N.Eloranta)");

Console.WriteLine("------------------------");

Console.WriteLine();

int A = 0;
bool res = false;
string vastaus = null;

Console.Write("Anna kokonaisluku: ");
vastaus = Console.ReadLine();

res = int.TryParse(vastaus, out A);

if (res == true)
{
Console.WriteLine("Converted '" + vastaus + "' to " + A + ".    JEE!");
}

else
{
    Console.WriteLine("Attempted conversion of '" + vastaus + "' failed.    SORRY!");
}


